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
    public partial class FormPreview : MetroFramework.Forms.MetroForm
    {
        public FormPreview(Image img)
        {
            InitializeComponent();
            pictureBox1.Image = img;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPreview_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "German")
            {
                this.Text = "Vorschau";
                btnClose.Text = "&Schließen";
            }

            else if (Properties.Settings.Default.Language == "Russian")
            {
                this.Text = "предварительный просмотр";
                btnClose.Text = "&близко";
            }

            else
            {
                this.Text = "Preview";
                btnClose.Text = "&Close";
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.Close();

            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }
    }
}
