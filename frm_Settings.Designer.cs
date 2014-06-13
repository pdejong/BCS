namespace BCS {
    partial class frm_Settings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Settings));
            this.lbl_Directory = new System.Windows.Forms.Label();
            this.txt_Directory = new System.Windows.Forms.TextBox();
            this.dlg_OpenDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_CLose = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.chk_Fallthrough = new System.Windows.Forms.CheckBox();
            this.chk_AutoWrite = new System.Windows.Forms.CheckBox();
            this.btn_BrowsePhoenix = new System.Windows.Forms.Button();
            this.txt_Phoenix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dlg_Phoenix = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbl_Directory
            // 
            this.lbl_Directory.AutoSize = true;
            this.lbl_Directory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Directory.Location = new System.Drawing.Point(12, 9);
            this.lbl_Directory.Name = "lbl_Directory";
            this.lbl_Directory.Size = new System.Drawing.Size(168, 13);
            this.lbl_Directory.TabIndex = 0;
            this.lbl_Directory.Text = "Bon Eyetop Anwendnungs Ordner";
            // 
            // txt_Directory
            // 
            this.txt_Directory.Location = new System.Drawing.Point(15, 34);
            this.txt_Directory.Name = "txt_Directory";
            this.txt_Directory.Size = new System.Drawing.Size(376, 20);
            this.txt_Directory.TabIndex = 1;
            // 
            // btn_CLose
            // 
            this.btn_CLose.Image = global::BCS.Properties.Resources.img_OK;
            this.btn_CLose.Location = new System.Drawing.Point(412, 107);
            this.btn_CLose.Name = "btn_CLose";
            this.btn_CLose.Size = new System.Drawing.Size(48, 36);
            this.btn_CLose.TabIndex = 3;
            this.btn_CLose.UseVisualStyleBackColor = true;
            this.btn_CLose.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Image = global::BCS.Properties.Resources.img_Open;
            this.btn_Browse.Location = new System.Drawing.Point(412, 31);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(48, 36);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // chk_Fallthrough
            // 
            this.chk_Fallthrough.AutoSize = true;
            this.chk_Fallthrough.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk_Fallthrough.Location = new System.Drawing.Point(15, 110);
            this.chk_Fallthrough.Name = "chk_Fallthrough";
            this.chk_Fallthrough.Size = new System.Drawing.Size(112, 17);
            this.chk_Fallthrough.TabIndex = 4;
            this.chk_Fallthrough.Text = "Auto selezionieren";
            this.chk_Fallthrough.UseVisualStyleBackColor = true;
            this.chk_Fallthrough.CheckedChanged += new System.EventHandler(this.chk_Fallthrough_CheckedChanged);
            // 
            // chk_AutoWrite
            // 
            this.chk_AutoWrite.AutoSize = true;
            this.chk_AutoWrite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk_AutoWrite.Location = new System.Drawing.Point(15, 133);
            this.chk_AutoWrite.Name = "chk_AutoWrite";
            this.chk_AutoWrite.Size = new System.Drawing.Size(132, 17);
            this.chk_AutoWrite.TabIndex = 5;
            this.chk_AutoWrite.Text = "Automatisch schlieβen";
            this.chk_AutoWrite.UseVisualStyleBackColor = true;
            this.chk_AutoWrite.CheckedChanged += new System.EventHandler(this.chk_AutoWrite_CheckedChanged);
            // 
            // btn_BrowsePhoenix
            // 
            this.btn_BrowsePhoenix.Image = global::BCS.Properties.Resources.img_Open;
            this.btn_BrowsePhoenix.Location = new System.Drawing.Point(412, 70);
            this.btn_BrowsePhoenix.Name = "btn_BrowsePhoenix";
            this.btn_BrowsePhoenix.Size = new System.Drawing.Size(48, 36);
            this.btn_BrowsePhoenix.TabIndex = 8;
            this.btn_BrowsePhoenix.UseVisualStyleBackColor = true;
            this.btn_BrowsePhoenix.Click += new System.EventHandler(this.btn_BrowsePhoenix_Click);
            // 
            // txt_Phoenix
            // 
            this.txt_Phoenix.Location = new System.Drawing.Point(15, 86);
            this.txt_Phoenix.Name = "txt_Phoenix";
            this.txt_Phoenix.Size = new System.Drawing.Size(376, 20);
            this.txt_Phoenix.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bon Eyetop Ordner";
            // 
            // dlg_Phoenix
            // 
            this.dlg_Phoenix.Filter = "Executables (*.exe)|*.exe|All files (*.*)|*.*";
            // 
            // frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(472, 164);
            this.Controls.Add(this.btn_BrowsePhoenix);
            this.Controls.Add(this.txt_Phoenix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_AutoWrite);
            this.Controls.Add(this.chk_Fallthrough);
            this.Controls.Add(this.btn_CLose);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.txt_Directory);
            this.Controls.Add(this.lbl_Directory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.frm_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Directory;
        private System.Windows.Forms.TextBox txt_Directory;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.FolderBrowserDialog dlg_OpenDirectory;
        private System.Windows.Forms.Button btn_CLose;
        private System.Windows.Forms.CheckBox chk_Fallthrough;
        private System.Windows.Forms.CheckBox chk_AutoWrite;
        private System.Windows.Forms.Button btn_BrowsePhoenix;
        private System.Windows.Forms.TextBox txt_Phoenix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog dlg_Phoenix;
    }
}