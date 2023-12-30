namespace CB___Image_Converter_Metro
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new MetroFramework.Controls.MetroTile();
            this.cmbLanguage = new MetroFramework.Controls.MetroComboBox();
            this.lblLanguage = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroTile();
            this.lblOther = new MetroFramework.Controls.MetroLabel();
            this.chbToolbar = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.ActiveControl = null;
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(400, 258);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 39);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.ItemHeight = 23;
            this.cmbLanguage.Items.AddRange(new object[] {
            "English",
            "Deutsch",
            "русский"});
            this.cmbLanguage.Location = new System.Drawing.Point(62, 122);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.PromptText = "English";
            this.cmbLanguage.Size = new System.Drawing.Size(209, 29);
            this.cmbLanguage.TabIndex = 0;
            this.cmbLanguage.Tag = "";
            this.cmbLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbLanguage.UseSelectable = true;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(58, 85);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(66, 19);
            this.lblLanguage.TabIndex = 4;
            this.lblLanguage.Text = "Language";
            this.lblLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveControl = null;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(30, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 39);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(58, 175);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(43, 19);
            this.lblOther.TabIndex = 6;
            this.lblOther.Text = "Other";
            this.lblOther.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // chbToolbar
            // 
            this.chbToolbar.AutoSize = true;
            this.chbToolbar.Location = new System.Drawing.Point(62, 208);
            this.chbToolbar.Name = "chbToolbar";
            this.chbToolbar.Size = new System.Drawing.Size(90, 15);
            this.chbToolbar.TabIndex = 7;
            this.chbToolbar.Text = "Hide Toolbar";
            this.chbToolbar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chbToolbar.UseSelectable = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 315);
            this.Controls.Add(this.chbToolbar);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.btnOK);
            this.Name = "FormSettings";
            this.Resizable = false;
            this.Text = "Settings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnOK;
        private MetroFramework.Controls.MetroComboBox cmbLanguage;
        private MetroFramework.Controls.MetroLabel lblLanguage;
        private MetroFramework.Controls.MetroTile btnCancel;
        private MetroFramework.Controls.MetroLabel lblOther;
        private MetroFramework.Controls.MetroCheckBox chbToolbar;
    }
}