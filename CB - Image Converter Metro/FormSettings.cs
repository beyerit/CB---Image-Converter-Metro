using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CB___Image_Converter_Metro
{
    public partial class FormSettings : MetroFramework.Forms.MetroForm
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        public int getLang()
        {
            return cmbLanguage.SelectedIndex;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HideToolbar = chbToolbar.Checked;
            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "German") cmbLanguage.SelectedIndex = 1;
            if (Properties.Settings.Default.Language == "русский") cmbLanguage.SelectedIndex = 2;
            chbToolbar.Checked = Properties.Settings.Default.HideToolbar;
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedIndex == 0)
            {
                lblLanguage.Text = "Language";
                btnCancel.Text = "&Cancel";
                lblOther.Text = "Other";
                chbToolbar.Text = "Hide Toolbar";
            }

            if (cmbLanguage.SelectedIndex == 1)
            {
                lblLanguage.Text = "Sprache";
                btnCancel.Text = "&Abbrechen";
                lblOther.Text = "Sonstiges";
                chbToolbar.Text = "Toolbar ausblenden";
            }

            if (cmbLanguage.SelectedIndex == 2)
            {
                lblLanguage.Text = "язык";
                btnCancel.Text = "&отмена";
                lblOther.Text = "Другой";
                chbToolbar.Text = "Скрыть панель инструментов";
            }
        }
    }
}
