using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BCS {
    public partial class frm_Settings : Form {
        public frm_Settings() {
            InitializeComponent();
        }

        private void btn_Browse_Click(object sender, EventArgs e) {
            if (dlg_OpenDirectory.ShowDialog() == DialogResult.OK) {
                txt_Directory.Text = dlg_OpenDirectory.SelectedPath;
                Properties.Settings.Default.EgoDirectory = txt_Directory.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void frm_Settings_Load(object sender, EventArgs e) {
            if (Directory.Exists(Properties.Settings.Default.EgoDirectory)) {
                txt_Directory.Text = Properties.Settings.Default.EgoDirectory;
                dlg_OpenDirectory.SelectedPath = txt_Directory.Text;
            }
            if (File.Exists(Properties.Settings.Default.Phoenix)) {
                txt_Phoenix.Text = Properties.Settings.Default.Phoenix;
                dlg_Phoenix.FileName = txt_Phoenix.Text;
            }
            else
                dlg_Phoenix.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            chk_Fallthrough.Checked = Properties.Settings.Default.Autoselect;
            chk_AutoWrite.Checked = Properties.Settings.Default.Autoclose;
        }

        private void btn_Close_Click(object sender, EventArgs e) {
            Close();
        }

        private void chk_Fallthrough_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default.Autoselect = chk_Fallthrough.Checked;
            Properties.Settings.Default.Save();
        }

        private void chk_AutoWrite_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default.Autoclose = chk_AutoWrite.Checked;
            Properties.Settings.Default.Save();
        }

        private void btn_BrowsePhoenix_Click(object sender, EventArgs e) {
            if (dlg_Phoenix.ShowDialog() == DialogResult.OK) {
                txt_Phoenix.Text = dlg_Phoenix.FileName;
                Properties.Settings.Default.Phoenix = txt_Phoenix.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}
