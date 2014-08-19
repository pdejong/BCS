using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BCS {
    /// <summary>
    /// (c) Piet de Jong
    /// </summary>
    public partial class frm_Main : Form {
        private PService.Study m_Study;
       
        public frm_Main() {
            InitializeComponent();
        }

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
                foreach (Image im in iml_ImagesOD.Images) im.Dispose();
                foreach (Image im in iml_ImagesOS.Images) im.Dispose();
            }
            base.Dispose(disposing);
        }


        private void SelectImage(PService.Image OD, PService.Image OS, PService.Study Study) {
            //string ImageName = Path.Combine(Properties.Settings.Default.EgoDirectory, Path.GetFileNameWithoutExtension(FileName) + OD.Laterality + ".jpg");
            using (PService.PSearchSvcClient client = new PService.PSearchSvcClient()) {
                Data DOS = null, DOD = null;
                PService.PeripheralDegreesModule POS = null, POD = null;
                if (OS != null) {
                    try { POS = client.GetPeripheralDegrees(OS.ImageId, true); } catch { }
                    DOS = new Data(client.GetBCS(OS.ImageId));
                }
                if (OD != null) {
                    try { POD = client.GetPeripheralDegrees(OD.ImageId, true); }
                    catch { }
                    DOD = new Data(client.GetBCS(OD.ImageId));
                }
                string filename = Path.Combine(Properties.Settings.Default.EgoDirectory, Study.StudyId + ".ker");
                using (StreamWriter sw = File.AppendText(filename)) {
                    sw.WriteLine("Woehlk Contactlinsen Schönkirchen     Version 1.2.2/17.11.11");
                    sw.WriteLine(Study.Device);
                    sw.WriteLine(Study.PatientsFirstName);
                    sw.WriteLine(Study.PatientsLastName);
                    sw.WriteLine(Study.PatientsBirthDate.ToString("dd.MM.yy"));
                    sw.WriteLine("----------------------------");
                    sw.WriteLine(Study.StudyDate.ToString("dd.MM.yy"));
                    sw.WriteLine(Study.StudyDate.ToString("HH.mm"));
                    sw.WriteLine("----------------------------");
                    sw.WriteLine("Ey_Para:");
                    if (OS != null) {
                        WriteEyPara(sw, OS, DOS, POS);
                        sw.WriteLine("-----");
                    }
                    if (OD != null) {
                        WriteEyPara(sw, OD, DOD, POD);
                    }
                    for (int i = 0; i < 10; i++) sw.WriteLine("-----");
                    sw.WriteLine("----------------------------");
                    sw.WriteLine("Ey_Exze:");
                    if (OS != null) {
                        WriteEyExze(sw, OS, DOS, POS);
                        sw.WriteLine("-----");
                    }
                    if (OD != null) {
                        WriteEyExze(sw, OD, DOD, POD);
                    }
                    for (int i = 0; i < 8; i++) sw.WriteLine("-----");
                    sw.WriteLine("----------------------------");
                    if (OS != null) {
                        WriteRest(sw, OS, DOS, POS);
                    }
                    if (OD != null) {
                        WriteRest(sw, OD, DOD, POD);
                    }
                }
                if (OS != null) WriteImage(OS, Study);
                if (OD != null) WriteImage(OD, Study);
            }
        }

        private static void WriteImage(PService.Image Img, PService.Study Study) {
            byte[] buffer = new byte[65536];
            int l;
            using (BinaryWriter bw = new BinaryWriter(File.Create(Path.Combine(Properties.Settings.Default.EgoDirectory, Study.StudyId + Img.Laterality + ".jpg"))))
            using (BinaryReader br = new BinaryReader(File.OpenRead(Path.ChangeExtension(Img.Root, "top"))))
                //using (BinaryReader br = new BinaryReader(client.GetImage(image.ImageId)))
                while ((l = br.Read(buffer, 0, buffer.Length)) > 0) bw.Write(buffer, 0, l);
        }

        private static void WriteRest(StreamWriter sw, PService.Image Img, Data Data, PService.PeripheralDegreesModule Module) {
            sw.WriteLine("CorneaF{0}", Img.Laterality);
            int seg = 0;
            float y = 0f, ymax = 7.4f;
            for (int i = 0; i < Data.Elevation.Count; i++) {
                sw.WriteLine("Seg:{0,2}  y= {1,5:0.00}  x= {2,12:0.000000000000}", seg, y, Data.Elevation[i]);
                y += 0.2f;
                if (y >= ymax) {
                    y = 0f;
                    seg++;
                }
            }
            sw.WriteLine("----------------------------");
            sw.WriteLine("Center {0}", Img.Laterality);
            sw.WriteLine("Iris Center    : x={0}", Data.LimbusDecentration.X);
            sw.WriteLine("Iris Center    : y={0}", Data.LimbusDecentration.Y);
            sw.WriteLine("Iris Diameter  : {0}", Data.IrisDiameter);
            sw.WriteLine("Pupil  Center  : x={0}", Data.PupilDecentration.X);
            sw.WriteLine("Pupil  Center  : y={0}", Data.PupilDecentration.Y);
            sw.WriteLine("Pupil  Diameter: {0}", Data.PupilDiameter);
            sw.WriteLine("----------------------------");
            sw.WriteLine("CL.Para_{0}: ", Img.Laterality);
            sw.WriteLine(Data.Flat.Radius);
            sw.WriteLine(Data.Steep.Radius);
            if (Module != null) {
                sw.WriteLine("{0} // Temporal 30 deg", Module.SagittalRadiusdegrees[2].Temporal);
                sw.WriteLine("{0} // Superior 30 deg", Module.SagittalRadiusdegrees[2].Superior);
                sw.WriteLine("{0} // Nasal 30 deg", Module.SagittalRadiusdegrees[2].Nasal);
                sw.WriteLine("{0} // Inferior 30 deg", Module.SagittalRadiusdegrees[2].Inferior);
            }
        }

        private static void WriteEyExze(StreamWriter sw, PService.Image Img, Data Data, PService.PeripheralDegreesModule Module) {
            sw.WriteLine(Img.Laterality);
            sw.WriteLine(Data.Flat.Power);
            sw.WriteLine(Data.Steep.Power);
            if (Module != null) {
                sw.WriteLine("{0} // Temporal 25 deg", Module.Asphericitydegrees[1].Temporal);
                sw.WriteLine("{0} // Superior 25 deg", Module.Asphericitydegrees[1].Superior);
                sw.WriteLine("{0} // Nasal 25 deg", Module.Asphericitydegrees[1].Nasal);
                sw.WriteLine("{0} // Inferior 25 deg", Module.Asphericitydegrees[1].Inferior);
            }
            sw.WriteLine(Data.Steep.Angle);
        }

        private static void WriteEyPara(StreamWriter sw, PService.Image Img, Data Data, PService.PeripheralDegreesModule Module) {
            sw.WriteLine(Img.Laterality);
            sw.WriteLine(Data.Flat.Radius);
            sw.WriteLine(Data.Steep.Radius);
            if (Module != null) {
                sw.WriteLine("{0} // Temporal 30 deg", Module.SagittalRadiusdegrees[2].Temporal);
                sw.WriteLine("{0} // Superior 30 deg", Module.SagittalRadiusdegrees[2].Superior);
                sw.WriteLine("{0} // Nasal 30 deg", Module.SagittalRadiusdegrees[2].Nasal);
                sw.WriteLine("{0} // Inferior 30 deg", Module.SagittalRadiusdegrees[2].Inferior);
            }
            sw.WriteLine(Data.Flat.Angle);
        }

        private void lv_ImagesOD_ItemActivate(object sender, EventArgs e) {
            PService.Image image = ((ListView)sender).SelectedItems[0].Tag as PService.Image;
            System.Diagnostics.Process.Start(Properties.Settings.Default.Phoenix, image.Root);
        }


        private void tb_Close_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void tb_Settings_Click(object sender, EventArgs e) {
            using (frm_Settings frm = new frm_Settings()) {
                frm.ShowDialog();
            }
        }

        private void tb_LatestStudy_Click(object sender, EventArgs e) {
            using (PService.PSearchSvcClient client = new PService.PSearchSvcClient()) {
                List<PService.Study> studies = new List<PService.Study>(client.SearchStudies(10,0));
                PService.Study study = studies.Find(st => "Keratoscope".Equals(st.Device) || "Scheimpflug Camera".Equals(st.Device));
                if (study != null) m_Study = study;
                btn_GetImages_Click(sender, e);
            }
        }

        private void btn_GetImages_Click(object sender, EventArgs e) {
            lv_ImagesOD.Items.Clear();
            iml_ImagesOD.Images.Clear();
            lv_ImagesOS.Items.Clear();
            iml_ImagesOS.Images.Clear();
            using (PService.PSearchSvcClient client = new PService.PSearchSvcClient()) {
                foreach (PService.Image image in client.FindImages(m_Study.StudyId, null)) {
                    ListViewItem item = new ListViewItem(image.ImageId);
                    item.Tag = image;
                    Image thumbnail = Image.FromStream(client.GetImage(image.ImageId)).GetThumbnailImage(150, 113, null, IntPtr.Zero);
                    if ("OD".Equals(image.Laterality)) {
                        iml_ImagesOD.Images.Add(thumbnail);
                        lv_ImagesOD.Items.Add(item);
                        item.ImageIndex = iml_ImagesOD.Images.Count - 1;
                        if (lv_ImagesOD.SelectedItems.Count == 0) item.Selected = true;
                    }
                    else {
                        iml_ImagesOS.Images.Add(thumbnail);
                        lv_ImagesOS.Items.Add(item);
                        item.ImageIndex = iml_ImagesOS.Images.Count - 1;
                        if (lv_ImagesOS.SelectedItems.Count == 0) item.Selected = true;
                    }
                }
                if (Properties.Settings.Default.Autoclose) {
                    btn_Close_Click(sender, e);
                }
            }
        }

        private void btn_SearchStudyID_Click(object sender, EventArgs e) {
            cmb_Studies.Items.Clear();
            using (PService.PSearchSvcClient client = new PService.PSearchSvcClient()) {
                foreach (PService.Study study in client.FindStudies(((PService.Patient)cmb_Patients.SelectedItem).PatientId)) {
                    if ("Keratoscope".Equals(study.Device) || "Scheimpflug Camera".Equals(study.Device))
                        cmb_Studies.Items.Add(study);
                }
                if (cmb_Studies.Items.Count > 0) cmb_Studies.SelectedIndex = 0;
                if (cmb_Studies.Items.Count > 1) cmb_Studies.DroppedDown = true;
            }
        }

        private void btn_SearchPatientID_Click(object sender, EventArgs e) {
            cmb_Patients.Items.Clear();
            using (PService.PSearchSvcClient client = new PService.PSearchSvcClient()) {
                foreach (PService.Patient patient in client.SearchPatients(txt_FirstName.Text.Trim(), txt_LastName.Text.Trim())) {
                    cmb_Patients.Items.Add(patient);
                }
                if (cmb_Patients.Items.Count > 0) cmb_Patients.SelectedIndex = 0;
                if (cmb_Patients.Items.Count > 1) cmb_Patients.DroppedDown = true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e) {
            lv_Studies.Items.Clear();
            using (PService.PSearchSvcClient client = new PService.PSearchSvcClient()) {
                List<PService.Study> studies = new List<PService.Study>(client.SearchStudiesByDate(dt_From.Value, dt_To.Value, null));
                studies.RemoveAll(st => !("Keratoscope".Equals(st.Device) || "Scheimpflug Camera".Equals(st.Device)));
                foreach (PService.Study st in studies) {
                    ListViewItem item = new ListViewItem(new string[]{ 
                        st.PatientsFirstName + " " + st.PatientsLastName, 
                        st.PatientsBirthDate.ToString("dd.MM.yyyy"),
                        st.StudyDate.ToString("dd.MM.yyyy HH.mm.ss"),
                        st.Device });
                    item.Tag = st;
                    lv_Studies.Items.Add(item);
                    try {
                        if (lv_Studies.SelectedItems.Count == 0 && item != null) item.Selected = true;
                    }
                    catch (NullReferenceException) { }
                }
            }
        }

        private void frm_Main_Load(object sender, EventArgs e) {
            cmb_Device.SelectedIndex = 0;
        }

        private void cmb_Patients_SelectedIndexChanged(object sender, EventArgs e) {
            if (Properties.Settings.Default.Autoselect && cmb_Patients.SelectedItem != null)
                btn_SearchStudyID_Click(sender, e);
        }

        private void cmb_Studies_SelectedIndexChanged(object sender, EventArgs e) {
            if (Properties.Settings.Default.Autoselect && cmb_Studies.SelectedItem != null) {
                m_Study = cmb_Studies.SelectedItem as PService.Study;
                btn_GetImages_Click(sender, e);
            }
        }

        private void lv_Studies_SelectedIndexChanged(object sender, EventArgs e) {
            if (Properties.Settings.Default.Autoselect && lv_Studies.SelectedItems.Count > 0) {
                m_Study = lv_Studies.SelectedItems[0].Tag as PService.Study;
                btn_GetImages_Click(sender, e);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e) {
            if (m_Study == null) return;
            string[] files = Directory.GetFiles(Properties.Settings.Default.EgoDirectory, string.Format("{0}*", m_Study.StudyId));
            foreach (string file in files) File.Delete(file);
            try {
                PService.Image OD = null, OS = null;
                if (lv_ImagesOD.SelectedItems.Count > 0) OD = lv_ImagesOD.SelectedItems[0].Tag as PService.Image;
                if (lv_ImagesOS.SelectedItems.Count > 0) OS = lv_ImagesOS.SelectedItems[0].Tag as PService.Image;
                SelectImage(OD, OS, m_Study);
                Close();
            }
            catch {
                MessageBox.Show("Da ist ein Problem aufgetreten mit der Topogaphie. Öffnen sie die Topographie in Phoenix");
                foreach (string file in files) File.Delete(file);
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e) {
            lv_ImagesOD.Items.Clear();
            lv_ImagesOS.Items.Clear();
            iml_ImagesOD.Images.Clear();
            iml_ImagesOS.Images.Clear();
        }

    }
}
