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
    public partial class FormResolution : MetroFramework.Forms.MetroForm
    {
        FormMain frmmain = new FormMain();

        public int newX, newY;
        double ratio, ratio2;
        bool widthLastChanged = true;


        public FormResolution(int stx, int sty, bool nativeimport)
        {
            InitializeComponent();

            numericUpDown1.Value = stx;
            numericUpDown2.Value = sty;

            numericUpDown1.Maximum = stx;
            numericUpDown2.Maximum = sty;

            metroTrackBar1.Maximum = stx;
            metroTrackBar1.Value = stx;

            ratio = Convert.ToDouble(sty) / Convert.ToDouble(stx);
            ratio2 = Convert.ToDouble(stx) / Convert.ToDouble(sty);

            if (!nativeimport)
            {
                pictureBox1.Visible = true;
                lblNote.Visible = true;
            }
        }

        private void FormResolution_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "German")
            {
                this.Text = "Auflösung ändern";
                lblHeigth.Text = "Höhe";
                lblWidth.Text = "Breite";
                metroCheckBox1.Text = "Seitenverhältnis beibehalten";
                btnCancel.Text = "A&bbrechen";
                btnApply.Text = "&Anwenden";
                lblNote.Text = "Hinweis: Bild-Animationen können verloren gehen!";
            }

            else if (Properties.Settings.Default.Language == "Russian")
            {
                this.Text = "Изменить разрешение";
                lblHeigth.Text = "высота";
                lblWidth.Text = "ширина";
                metroCheckBox1.Text = "Сохранить соотношение сторон";
                btnCancel.Text = "&отмена";
                btnApply.Text = "&применять";
                lblNote.Text = "Примечание: анимация изображения может быть потеряна!";
            }

            else
            {
                this.Text = "Change resolution";
                lblHeigth.Text = "Heigth";
                lblWidth.Text = "Width";
                metroCheckBox1.Text = "Keep ratio";
                btnCancel.Text = "&Cancel";
                btnApply.Text = "&Apply";
                lblNote.Text = "Note: Image-Animations can get lost!";
            }
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            if (widthLastChanged)
            {
                getHeigth();
            }

            else
            {
                getWidth();
            }

            newX = Convert.ToInt32(numericUpDown1.Value);
            newY = Convert.ToInt32(numericUpDown2.Value);

            this.Close();
        }

        private void MetroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getHeigth();
            }
        }

        private void getHeigth()
        {
            if (metroCheckBox1.Checked)
            {
                try
                {
                    double nmbRes = Convert.ToDouble(numericUpDown1.Value);
                    double tempRes = nmbRes * ratio;

                    numericUpDown2.Value = Convert.ToInt32(tempRes);
                }

                catch { }
            }
        }

        private void getWidth()
        {
            if (metroCheckBox1.Checked)
            {
                try
                {
                    double nmbRes = Convert.ToDouble(numericUpDown2.Value);
                    double tempRes = nmbRes * ratio2;

                    numericUpDown1.Value = Convert.ToInt32(tempRes);
                }

                catch { }
            }
        }

        private void numericUpDown2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getWidth();
            }
        }

        private void metroTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = metroTrackBar1.Value;
            getHeigth();

            lblPercent.Text = (metroTrackBar1.Value * 100) / metroTrackBar1.Maximum + "%";
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            widthLastChanged = false;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            widthLastChanged = true;
        }
    }
}
