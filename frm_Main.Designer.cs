namespace BCS {
    partial class frm_Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tb_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_Latest = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_Device = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_To = new System.Windows.Forms.DateTimePicker();
            this.dt_From = new System.Windows.Forms.DateTimePicker();
            this.lv_Studies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_GetImages = new System.Windows.Forms.Button();
            this.btn_GetStudies = new System.Windows.Forms.Button();
            this.btn_GetPatientId = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Patients = new System.Windows.Forms.ComboBox();
            this.cmb_Studies = new System.Windows.Forms.ComboBox();
            this.lbl_PatientID = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lv_ImagesOS = new System.Windows.Forms.ListView();
            this.iml_ImagesOS = new System.Windows.Forms.ImageList(this.components);
            this.lv_ImagesOD = new System.Windows.Forms.ListView();
            this.iml_ImagesOD = new System.Windows.Forms.ImageList(this.components);
            this.btn_Close = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_Settings,
            this.tb_Close,
            this.tb_Latest});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tb_Settings
            // 
            this.tb_Settings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Settings.Name = "tb_Settings";
            this.tb_Settings.Size = new System.Drawing.Size(61, 20);
            this.tb_Settings.Text = "Settings";
            this.tb_Settings.Click += new System.EventHandler(this.tb_Settings_Click);
            // 
            // tb_Close
            // 
            this.tb_Close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tb_Close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Close.Name = "tb_Close";
            this.tb_Close.Size = new System.Drawing.Size(65, 20);
            this.tb_Close.Text = "Beenden";
            this.tb_Close.Click += new System.EventHandler(this.tb_Close_Click);
            // 
            // tb_Latest
            // 
            this.tb_Latest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Latest.Name = "tb_Latest";
            this.tb_Latest.Size = new System.Drawing.Size(111, 20);
            this.tb_Latest.Text = "Latest acquisition";
            this.tb_Latest.Click += new System.EventHandler(this.tb_LatestStudy_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 193);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage1.Controls.Add(this.btn_Search);
            this.tabPage1.Controls.Add(this.cmb_Device);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dt_To);
            this.tabPage1.Controls.Add(this.dt_From);
            this.tabPage1.Controls.Add(this.lv_Studies);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 167);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Date";
            // 
            // btn_Search
            // 
            this.btn_Search.Image = global::BCS.Properties.Resources.img_OK;
            this.btn_Search.Location = new System.Drawing.Point(457, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(48, 36);
            this.btn_Search.TabIndex = 26;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_Device
            // 
            this.cmb_Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Device.FormattingEnabled = true;
            this.cmb_Device.Items.AddRange(new object[] {
            "Keratoscope",
            "Scheimpflug Camera"});
            this.cmb_Device.Location = new System.Drawing.Point(8, 7);
            this.cmb_Device.Name = "cmb_Device";
            this.cmb_Device.Size = new System.Drawing.Size(170, 21);
            this.cmb_Device.TabIndex = 24;
            this.cmb_Device.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "-";
            // 
            // dt_To
            // 
            this.dt_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_To.Location = new System.Drawing.Point(331, 6);
            this.dt_To.Name = "dt_To";
            this.dt_To.Size = new System.Drawing.Size(110, 20);
            this.dt_To.TabIndex = 21;
            // 
            // dt_From
            // 
            this.dt_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_From.Location = new System.Drawing.Point(199, 6);
            this.dt_From.Name = "dt_From";
            this.dt_From.Size = new System.Drawing.Size(110, 20);
            this.dt_From.TabIndex = 20;
            // 
            // lv_Studies
            // 
            this.lv_Studies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_Studies.FullRowSelect = true;
            this.lv_Studies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Studies.HideSelection = false;
            this.lv_Studies.Location = new System.Drawing.Point(8, 45);
            this.lv_Studies.Name = "lv_Studies";
            this.lv_Studies.Size = new System.Drawing.Size(497, 92);
            this.lv_Studies.TabIndex = 19;
            this.lv_Studies.UseCompatibleStateImageBehavior = false;
            this.lv_Studies.View = System.Windows.Forms.View.Details;
            this.lv_Studies.SelectedIndexChanged += new System.EventHandler(this.lv_Studies_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Patient";
            this.columnHeader1.Width = 193;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Geburtsdatum";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Datum";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gerät";
            this.columnHeader4.Width = 104;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Controls.Add(this.btn_GetImages);
            this.tabPage2.Controls.Add(this.btn_GetStudies);
            this.tabPage2.Controls.Add(this.btn_GetPatientId);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cmb_Patients);
            this.tabPage2.Controls.Add(this.cmb_Studies);
            this.tabPage2.Controls.Add(this.lbl_PatientID);
            this.tabPage2.Controls.Add(this.lbl_LastName);
            this.tabPage2.Controls.Add(this.txt_LastName);
            this.tabPage2.Controls.Add(this.lbl_FirstName);
            this.tabPage2.Controls.Add(this.txt_FirstName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 167);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer";
            // 
            // btn_GetImages
            // 
            this.btn_GetImages.Image = global::BCS.Properties.Resources.img_OK;
            this.btn_GetImages.Location = new System.Drawing.Point(457, 92);
            this.btn_GetImages.Name = "btn_GetImages";
            this.btn_GetImages.Size = new System.Drawing.Size(48, 36);
            this.btn_GetImages.TabIndex = 27;
            this.btn_GetImages.UseVisualStyleBackColor = true;
            this.btn_GetImages.Click += new System.EventHandler(this.btn_GetImages_Click);
            // 
            // btn_GetStudies
            // 
            this.btn_GetStudies.Image = global::BCS.Properties.Resources.img_OK;
            this.btn_GetStudies.Location = new System.Drawing.Point(457, 54);
            this.btn_GetStudies.Name = "btn_GetStudies";
            this.btn_GetStudies.Size = new System.Drawing.Size(48, 36);
            this.btn_GetStudies.TabIndex = 26;
            this.btn_GetStudies.UseVisualStyleBackColor = true;
            this.btn_GetStudies.Click += new System.EventHandler(this.btn_SearchStudyID_Click);
            // 
            // btn_GetPatientId
            // 
            this.btn_GetPatientId.Image = global::BCS.Properties.Resources.img_OK;
            this.btn_GetPatientId.Location = new System.Drawing.Point(457, 19);
            this.btn_GetPatientId.Name = "btn_GetPatientId";
            this.btn_GetPatientId.Size = new System.Drawing.Size(48, 36);
            this.btn_GetPatientId.TabIndex = 25;
            this.btn_GetPatientId.UseVisualStyleBackColor = true;
            this.btn_GetPatientId.Click += new System.EventHandler(this.btn_SearchPatientID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Study";
            // 
            // cmb_Patients
            // 
            this.cmb_Patients.FormattingEnabled = true;
            this.cmb_Patients.Location = new System.Drawing.Point(103, 66);
            this.cmb_Patients.Name = "cmb_Patients";
            this.cmb_Patients.Size = new System.Drawing.Size(340, 21);
            this.cmb_Patients.TabIndex = 23;
            this.cmb_Patients.SelectedIndexChanged += new System.EventHandler(this.cmb_Patients_SelectedIndexChanged);
            // 
            // cmb_Studies
            // 
            this.cmb_Studies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Studies.FormattingEnabled = true;
            this.cmb_Studies.Location = new System.Drawing.Point(103, 105);
            this.cmb_Studies.Name = "cmb_Studies";
            this.cmb_Studies.Size = new System.Drawing.Size(340, 21);
            this.cmb_Studies.TabIndex = 22;
            this.cmb_Studies.SelectedIndexChanged += new System.EventHandler(this.cmb_Studies_SelectedIndexChanged);
            // 
            // lbl_PatientID
            // 
            this.lbl_PatientID.AutoSize = true;
            this.lbl_PatientID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_PatientID.Location = new System.Drawing.Point(5, 66);
            this.lbl_PatientID.Name = "lbl_PatientID";
            this.lbl_PatientID.Size = new System.Drawing.Size(54, 13);
            this.lbl_PatientID.TabIndex = 19;
            this.lbl_PatientID.Text = "Patient ID";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_LastName.Location = new System.Drawing.Point(245, 12);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LastName.TabIndex = 17;
            this.lbl_LastName.Text = "Last Name";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(248, 28);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(195, 20);
            this.txt_LastName.TabIndex = 16;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_FirstName.Location = new System.Drawing.Point(8, 12);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 15;
            this.lbl_FirstName.Text = "First Name";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(8, 28);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(226, 20);
            this.txt_FirstName.TabIndex = 14;
            // 
            // lv_ImagesOS
            // 
            this.lv_ImagesOS.HideSelection = false;
            this.lv_ImagesOS.LargeImageList = this.iml_ImagesOS;
            this.lv_ImagesOS.Location = new System.Drawing.Point(255, 223);
            this.lv_ImagesOS.MultiSelect = false;
            this.lv_ImagesOS.Name = "lv_ImagesOS";
            this.lv_ImagesOS.Size = new System.Drawing.Size(254, 77);
            this.lv_ImagesOS.TabIndex = 16;
            this.lv_ImagesOS.TileSize = new System.Drawing.Size(64, 64);
            this.lv_ImagesOS.UseCompatibleStateImageBehavior = false;
            this.lv_ImagesOS.View = System.Windows.Forms.View.Tile;
            this.lv_ImagesOS.ItemActivate += new System.EventHandler(this.lv_ImagesOD_ItemActivate);
            // 
            // iml_ImagesOS
            // 
            this.iml_ImagesOS.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.iml_ImagesOS.ImageSize = new System.Drawing.Size(64, 64);
            this.iml_ImagesOS.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lv_ImagesOD
            // 
            this.lv_ImagesOD.HideSelection = false;
            this.lv_ImagesOD.LargeImageList = this.iml_ImagesOD;
            this.lv_ImagesOD.Location = new System.Drawing.Point(12, 223);
            this.lv_ImagesOD.MultiSelect = false;
            this.lv_ImagesOD.Name = "lv_ImagesOD";
            this.lv_ImagesOD.Size = new System.Drawing.Size(237, 77);
            this.lv_ImagesOD.TabIndex = 15;
            this.lv_ImagesOD.TileSize = new System.Drawing.Size(64, 64);
            this.lv_ImagesOD.UseCompatibleStateImageBehavior = false;
            this.lv_ImagesOD.View = System.Windows.Forms.View.Tile;
            this.lv_ImagesOD.ItemActivate += new System.EventHandler(this.lv_ImagesOD_ItemActivate);
            // 
            // iml_ImagesOD
            // 
            this.iml_ImagesOD.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.iml_ImagesOD.ImageSize = new System.Drawing.Size(64, 64);
            this.iml_ImagesOD.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_Close
            // 
            this.btn_Close.Image = global::BCS.Properties.Resources.img_OK;
            this.btn_Close.Location = new System.Drawing.Point(461, 306);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(48, 36);
            this.btn_Close.TabIndex = 27;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(527, 341);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lv_ImagesOS);
            this.Controls.Add(this.lv_ImagesOD);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tb_Settings;
        private System.Windows.Forms.ToolStripMenuItem tb_Close;
        private System.Windows.Forms.ToolStripMenuItem tb_Latest;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmb_Patients;
        private System.Windows.Forms.ComboBox cmb_Studies;
        private System.Windows.Forms.Label lbl_PatientID;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GetImages;
        private System.Windows.Forms.Button btn_GetStudies;
        private System.Windows.Forms.Button btn_GetPatientId;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_Device;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_To;
        private System.Windows.Forms.DateTimePicker dt_From;
        private System.Windows.Forms.ListView lv_Studies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lv_ImagesOS;
        private System.Windows.Forms.ListView lv_ImagesOD;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ImageList iml_ImagesOS;
        private System.Windows.Forms.ImageList iml_ImagesOD;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}