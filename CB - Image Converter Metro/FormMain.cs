using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.IO;
using System.Windows.Media.Imaging;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace CB___Image_Converter_Metro
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        System.Drawing.Image image;
        string openLocation = "";
        string fileLocation = "";
        public bool preconvert = true;
        int fileSuccessCounter = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstLaunch)
            {
                if (System.Globalization.CultureInfo.InstalledUICulture.EnglishName.StartsWith("German"))
                {
                    langGER();
                    Properties.Settings.Default.Language = "German";
                }

                else if (System.Globalization.CultureInfo.InstalledUICulture.EnglishName.StartsWith("Russian"))
                {
                    langRUS();
                    Properties.Settings.Default.Language = "Russian";
                }

                else
                {
                    langENG();
                    Properties.Settings.Default.Language = "English";
                }

                Properties.Settings.Default.FirstLaunch = false;
                Properties.Settings.Default.Save();
            }

            else
            {
                if (Properties.Settings.Default.Language == "German") langGER();

                if (Properties.Settings.Default.Language == "Russian") langRUS();

                if (Properties.Settings.Default.Language == "English") langENG();
            }
            

            cmbFileFormat.SelectedIndex = 0;

            try
            {
                if (!File.Exists("itextsharp.dll"))
                {
                    cmbFileFormat.Items.Remove("PDF (*.pdf)");
                }
            }

            catch { }
        }

        #region Language

        private void langGER()
        {
            groupBox2.Text = "Bild auswählen";
            groupBox3.Text = "Dateiformat";
            groupBox4.Text = "Speichern";
            metroToolTip1.SetToolTip(btnSave, "Bild speichern");
            metroToolTip1.SetToolTip(btnSelect, "Bild auswählen");
            previewToolStripMenuItem.Text = "Vorschau";
            infoToolStripMenuItem.Text = "Bild Eigenschaften";
            reImportImageToolStripMenuItem.Text = "Bild neu importieren";
            openFolderToolStripMenuItem.Text = "Ordner öffnen";
            pfadKopierenToolStripMenuItem.Text = "Pfad kopieren";
            metroToolTip1.SetToolTip(lblPixel, "Auflösung ändern...");
            chbNative.Text = "Vor-Konvertieren";
            changeResolutionToolStripMenuItem.Text = "Auflösung ändern";
            rotateImageToolStripMenuItem.Text = "Bild drehen 90°";
            roteImage270ToolStripMenuItem.Text = "Bild drehen 180°";
            flipImageVerticallyToolStripMenuItem.Text = "Bild Vertikal spiegeln";
            flipImageHorizontallyToolStripMenuItem.Text = "Bild Horizontal spiegeln";
            convertImageBlackwhiteToolStripMenuItem.Text = "Bild in Graustufen konvertieren";

            chbNative.Location = new Point(90, 121);
            pictureBox3.Location = new Point(205, 120);

            metroToolTip1.SetToolTip(btnRevert, "Bild re-importieren (Änderungen verwerfen)");
            metroToolTip1.SetToolTip(btnChangeRes, "Auflösung ändern");
            metroToolTip1.SetToolTip(btnFlipHorizontal, "Horizontal spiegeln");
            metroToolTip1.SetToolTip(btnRotateAnti, "Drehen (gegen Uhrzeigersinn)");
            metroToolTip1.SetToolTip(btnRotateClock, "Drehen (im Uhrzeigersinn)");
            metroToolTip1.SetToolTip(btnFlipVertical, "Vertikal spiegeln");
            metroToolTip1.SetToolTip(btnGreyscale, "Bild in Graustufen konvertieren");
            metroToolTip1.SetToolTip(btnPreview, "Bildvorschau anzeigen");

            Properties.Settings.Default.Language = "German";
            Properties.Settings.Default.Save();
        }

        private void langENG()
        {
            groupBox2.Text = "select image";
            groupBox3.Text = "file format";
            groupBox4.Text = "save";
            metroToolTip1.SetToolTip(btnSave, "save image");
            metroToolTip1.SetToolTip(btnSelect, "select image");
            previewToolStripMenuItem.Text = "Preview";
            infoToolStripMenuItem.Text = "Image properties";
            reImportImageToolStripMenuItem.Text = "Re-import image";
            openFolderToolStripMenuItem.Text = "Open folder";
            pfadKopierenToolStripMenuItem.Text = "Copy path";
            metroToolTip1.SetToolTip(lblPixel, "Change resolution...");
            chbNative.Text = "Pre-Convert";
            changeResolutionToolStripMenuItem.Text = "Change resolution";
            rotateImageToolStripMenuItem.Text = "Rotate image 90°";
            roteImage270ToolStripMenuItem.Text = "Rotate image 180°";
            flipImageVerticallyToolStripMenuItem.Text = "Flip image vertically";
            flipImageHorizontallyToolStripMenuItem.Text = "Flip image horizontally";
            convertImageBlackwhiteToolStripMenuItem.Text = "Convert image to grayscale";

            chbNative.Location = new Point(107, 121);
            pictureBox3.Location = new Point(198, 120);

            metroToolTip1.SetToolTip(btnRevert, "Re-import image (revert changes)");
            metroToolTip1.SetToolTip(btnChangeRes, "Change resolution");
            metroToolTip1.SetToolTip(btnFlipHorizontal, "Flip horizontally");
            metroToolTip1.SetToolTip(btnRotateAnti, "Rotate anti-clockwise");
            metroToolTip1.SetToolTip(btnRotateClock, "Rotate clockwise");
            metroToolTip1.SetToolTip(btnFlipVertical, "Flip vertically");
            metroToolTip1.SetToolTip(btnGreyscale, "Convert image to greyscale");
            metroToolTip1.SetToolTip(btnPreview, "Preview image");

            Properties.Settings.Default.Language = "English";
            Properties.Settings.Default.Save();
        }

        private void langRUS()
        {
            groupBox2.Text = "картина";
            groupBox3.Text = "формат файла";
            groupBox4.Text = "экономить";
            metroToolTip1.SetToolTip(btnSave, "Сохранить изображение");
            metroToolTip1.SetToolTip(btnSelect, "Выбрать изображение");
            previewToolStripMenuItem.Text = "предварительный просмотр";
            infoToolStripMenuItem.Text = "Свойства изображения";
            reImportImageToolStripMenuItem.Text = "Импортируйте изображение снова";
            openFolderToolStripMenuItem.Text = "Открыть папку";
            pfadKopierenToolStripMenuItem.Text = "Копировать путь";
            metroToolTip1.SetToolTip(lblPixel, "Изменить разрешение...");
            chbNative.Text = "Предварительно Преобразовать";
            changeResolutionToolStripMenuItem.Text = "Изменить разрешение";
            rotateImageToolStripMenuItem.Text = "Повернуть картинку 90°";
            roteImage270ToolStripMenuItem.Text = "Повернуть картинку 180°";
            flipImageVerticallyToolStripMenuItem.Text = "Зеркальное отображение по вертикали";
            flipImageHorizontallyToolStripMenuItem.Text = "Зеркальное отображение по горизонтали";
            convertImageBlackwhiteToolStripMenuItem.Text = "Преобразовать изображение в оттенки серого";

            chbNative.Location = new Point(45, 121);
            pictureBox3.Location = new Point(250, 120);

            metroToolTip1.SetToolTip(btnRevert, "Повторно импортировать изображение (отменить изменения)");
            metroToolTip1.SetToolTip(btnChangeRes, "изменить разрешение");
            metroToolTip1.SetToolTip(btnFlipHorizontal, "Отразить по горизонтали");
            metroToolTip1.SetToolTip(btnRotateAnti, "Вращать против часовой стрелки)");
            metroToolTip1.SetToolTip(btnRotateClock, "повернуть по часовой стрелке)");
            metroToolTip1.SetToolTip(btnFlipVertical, "Отразить по вертикали");
            metroToolTip1.SetToolTip(btnGreyscale, "Преобразование изображения в оттенки серого");
            metroToolTip1.SetToolTip(btnPreview, "Показать изображение для предварительного просмотра");

            Properties.Settings.Default.Language = "Russian";
            Properties.Settings.Default.Save();
        }

        #endregion

        #region Image functions

        private void RotateImage90()
        {
            try
            {
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                pictureBox1.Image = image;
                lblPixel.Text = image.Width + " x " + image.Height;
            }

            catch { }
        }

        private void RotateImage270()
        {
            try
            {
                image.RotateFlip(RotateFlipType.Rotate270FlipNone);

                pictureBox1.Image = image;
                lblPixel.Text = image.Width + " x " + image.Height;
            }

            catch { }
        }

        private void PreviewImage()
        {
            if (pictureBox1.Image != null)
            {
                Form frmPre = new FormPreview(pictureBox1.Image);
                frmPre.ShowDialog();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PreviewImage();
        }

        private void ReimportImage()
        {
            if (openFileDialog1.FileName != "")
            {
                try
                {
                    loading();
                    string extension = Path.GetExtension(openFileDialog1.FileName);

                    if (!chbNative.Checked)
                    {
                        System.Drawing.Image srcImage;
                        srcImage = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                        image = System.Drawing.Image.FromFile(openFileDialog1.FileName);

                        pictureBox1.Image = srcImage;
                        metroToolTip1.SetToolTip(pictureBox1, openFileDialog1.FileName);

                        btnSave.Enabled = true;

                        image = srcImage;
                        pictureBox1.Image = srcImage;
                        metroToolTip1.SetToolTip(pictureBox1, openFileDialog1.FileName);

                        string path = openFileDialog1.FileName;
                        btnSave.Enabled = true;

                        metroProgressBar1.Visible = false;
                        openLocation = Path.GetDirectoryName(openFileDialog1.FileName);

                        lblPixel.Text = srcImage.Width + " x " + srcImage.Height;
                        lblPixel.Visible = true;
                        infoToolStripMenuItem.Visible = true;
                        openFolderToolStripMenuItem.Visible = true;
                        pfadKopierenToolStripMenuItem.Visible = true;

                        preconvert = false;
                    }

                    else
                    {
                        BitmapDecoder bmpDec = BitmapDecoder.Create(new Uri(openFileDialog1.FileName),
                        BitmapCreateOptions.DelayCreation, BitmapCacheOption.None);
                        BitmapEncoder bmpEnc = new BmpBitmapEncoder();
                        bmpEnc.Frames.Add(bmpDec.Frames[0]);
                        Stream ms = new MemoryStream();
                        bmpEnc.Save(ms);
                        System.Drawing.Image srcImage = Bitmap.FromStream(ms);

                        image = srcImage;
                        pictureBox1.Image = srcImage;
                        metroToolTip1.SetToolTip(pictureBox1, openFileDialog1.FileName);

                        string path = openFileDialog1.FileName;
                        btnSave.Enabled = true;

                        metroProgressBar1.Visible = false;
                        openLocation = Path.GetDirectoryName(openFileDialog1.FileName);

                        lblPixel.Text = srcImage.Width + " x " + srcImage.Height;
                        lblPixel.Visible = true;
                        infoToolStripMenuItem.Visible = true;
                        openFolderToolStripMenuItem.Visible = true;
                        pfadKopierenToolStripMenuItem.Visible = true;

                        preconvert = true;
                    }
                }

                catch { }
            }
        }

        private void ChangeRes()
        {
            try
            {
                FormResolution frmres = new FormResolution(image.Width, image.Height, preconvert);
                frmres.ShowDialog();

                image = resizeImage(pictureBox1.Image, new Size(frmres.newX, frmres.newY));
                pictureBox1.Image = image;
                lblPixel.Text = image.Width + " x " + image.Height;

                preconvert = true;

            }

            catch { }
        }

        private void ConvertToGreyscale()
        {
            loading();

            try
            {
                System.Drawing.Image tempimg = image;

                Bitmap tempbmp = new Bitmap(tempimg);

                image = MakeGreyscale(tempbmp);
                pictureBox1.Image = MakeGreyscale(tempbmp);

                metroProgressBar1.Visible = false;
            }

            catch
            {
                metroProgressBar1.Visible = false;
            }
        }

        public static Bitmap MakeGreyscale(Bitmap original)
        {
            try
            {
                Bitmap newBitmap = new Bitmap(original.Width, original.Height);
                Graphics g = Graphics.FromImage(newBitmap);
                ColorMatrix colorMatrix = new ColorMatrix(
                   new float[][]
                   {
                     new float[] {.3f, .3f, .3f, 0, 0},
                     new float[] {.59f, .59f, .59f, 0, 0},
                     new float[] {.11f, .11f, .11f, 0, 0},
                     new float[] {0, 0, 0, 1, 0},
                     new float[] {0, 0, 0, 0, 1}
                   });

                ImageAttributes attributes = new ImageAttributes();

                attributes.SetColorMatrix(colorMatrix);

                g.DrawImage(original, new System.Drawing.Rectangle(0, 0, original.Width, original.Height),
                   0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

                g.Dispose();
                return newBitmap;
            }

            catch
            {
                return null;
            }
        }

        private void HorizontalFlip()
        {
            try
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);

                pictureBox1.Image = image;
                lblPixel.Text = image.Width + " x " + image.Height;
            }

            catch { }
        }

        private void VerticalFlip()
        {
            try
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipY);

                pictureBox1.Image = image;
                lblPixel.Text = image.Width + " x " + image.Height;
            }

            catch { }
        }

        #endregion

        #region GUI

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "English")
            {
                openFileDialog1.Filter = "General Files (*.jpg; *.png; *.bmp; *.gif; *.tiff; *.ico; *.wmf; *.emf; *.exif; *.heic)|*.jpg; *.png; *.bmp; *.gif; *.tiff; *.ico; *.wmf; *.emf; *.exif; *.heic|" +
                    "RAW Files (*.raw; *.dng; *.tif; *.cr2; *.cr3; *.erf; *.raf; *.rwl; *.nef; *.nrw; *.pef; *.srw; *.x3f; *.dcr; *.dcs; *.kdc; *.mef; *.iiq; *.mfw; *.3fr; *.fff; *.x3f; *.cs1; *.cs4; *.cs6; *.arw; *.srf; *.sr2)|*.raw; *.dng; *.tif; *.cr2; *.cr3; *.erf; *.raf; *.rwl; *.nef; *.nrw; " +
                    "*.pef; *.srw; *.x3f; *.dcr; *.dcs; *.kdc; *.mef; *.iiq; *.mfw; *.3fr; *.fff; *.x3f; *.cs1; *.cs4; *.cs6; *.arw; *.srf; *.sr2|all files (*.*)|*.*";
            }

            if (Properties.Settings.Default.Language == "German")
            {
                openFileDialog1.Filter = "Gängige Dateien (*.jpg; *.png; *.bmp; *.gif; *.tiff; *.ico; *.wmf; *.emf; *.exif; *.heic)|*.jpg; *.png; *.bmp; *.gif; *.tiff; *.ico; *.wmf; *.emf; *.exif; *.heic|" +
                    "Roh-Dateien (*.raw; *.dng; *.tif; *.cr2; *.cr3; *.erf; *.raf; *.rwl; *.nef; *.nrw; *.pef; *.srw; *.x3f; *.dcr; *.dcs; *.kdc; *.mef; *.iiq; *.mfw; *.3fr; *.fff; *.x3f; *.cs1; *.cs4; *.cs6; *.arw; *.srf; *.sr2|*.raw; *.dng; *.tif; *.cr2; *.cr3; *.erf; *.raf; *.rwl; *.nef; *.nrw; " +
                    "*.pef; *.srw; *.x3f; *.dcr; *.dcs; *.kdc; *.mef; *.iiq; *.mfw; *.3fr; *.fff; *.x3f; *.cs1; *.cs4; *.cs6; *.arw; *.srf; *.sr2|alle Dateien (*.*)|*.*";
            }

            if (Properties.Settings.Default.Language == "Russian")
            {
                openFileDialog1.Filter = "Нормальные файлы (*.jpg; *.png; *.bmp; *.gif; *.tiff; *.ico; *.wmf; *.emf; *.exif; *.heic)|*.jpg; *.png; *.bmp; *.gif; *.tiff; *.ico; *.wmf; *.emf; *.exif; *.heic|" +
                    "сырые файлы (*.raw; *.dng; *.tif; *.cr2; *.cr3; *.erf; *.raf; *.rwl; *.nef; *.nrw; *.pef; *.srw; *.x3f; *.dcr; *.dcs; *.kdc; *.mef; *.iiq; *.mfw; *.3fr; *.fff; *.x3f; *.cs1; *.cs4; *.cs6; *.arw; *.srf; *.sr2|*.raw; *.dng; *.tif; *.cr2; *.cr3; *.erf; *.raf; *.rwl; *.nef; *.nrw; " +
                    "*.pef; *.srw; *.x3f; *.dcr; *.dcs; *.kdc; *.mef; *.iiq; *.mfw; *.3fr; *.fff; *.x3f; *.cs1; *.cs4; *.cs6; *.arw; *.srf; *.sr2|все файлы (*.*)|*.*";
            }

            try
            {
                try
                {
                    if (openLocation != "")
                    {
                        openFileDialog1.InitialDirectory = openLocation;
                    }
                }

                catch { }

               if (openFileDialog1.ShowDialog() == DialogResult.OK)
               {
                    succ1.Visible = false;
                    succ2.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox2.Image = null;
                    lblImageName.Visible = false;
                    lblPixel.Visible = false;
                    pnControlButtons.Visible = false;

                    if (openFileDialog1.FileNames.Length == 1)
                    {
                        loading();
                        string extension = Path.GetExtension(openFileDialog1.FileName);

                        if (!chbNative.Checked)
                        {
                            System.Drawing.Image srcImage;
                            srcImage = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                            image = System.Drawing.Image.FromFile(openFileDialog1.FileName);

                            pictureBox1.Image = srcImage;
                            metroToolTip1.SetToolTip(pictureBox1, openFileDialog1.FileName);

                            btnSave.Enabled = true;

                            image = srcImage;
                            pictureBox1.Image = srcImage;
                            metroToolTip1.SetToolTip(pictureBox1, openFileDialog1.FileName);

                            string path = openFileDialog1.FileName;
                            btnSave.Enabled = true;

                            metroProgressBar1.Visible = false;
                            openLocation = Path.GetDirectoryName(openFileDialog1.FileName);

                            lblPixel.Text = srcImage.Width + " x " + srcImage.Height;
                            lblPixel.Visible = true;

                            pictureBox1.ContextMenuStrip = metroContextMenu1;

                            lblImageName.Text = Path.GetFileName(openFileDialog1.FileName);
                            lblImageName.Visible = true;

                            preconvert = false;
                        }

                        else
                        {
                            BitmapDecoder bmpDec = BitmapDecoder.Create(new Uri(openFileDialog1.FileName),
                            BitmapCreateOptions.DelayCreation, BitmapCacheOption.None);
                            BitmapEncoder bmpEnc = new BmpBitmapEncoder();
                            bmpEnc.Frames.Add(bmpDec.Frames[0]);
                            Stream ms = new MemoryStream();
                            bmpEnc.Save(ms);
                            System.Drawing.Image srcImage = Bitmap.FromStream(ms);

                            image = srcImage;
                            pictureBox1.Image = srcImage;
                            metroToolTip1.SetToolTip(pictureBox1, openFileDialog1.FileName);

                            string path = openFileDialog1.FileName;
                            btnSave.Enabled = true;

                            metroProgressBar1.Visible = false;
                            openLocation = Path.GetDirectoryName(openFileDialog1.FileName);

                            lblPixel.Text = srcImage.Width + " x " + srcImage.Height;
                            lblPixel.Visible = true;

                            pictureBox1.ContextMenuStrip = metroContextMenu1;

                            lblImageName.Text = Path.GetFileName(openFileDialog1.FileName);
                            lblImageName.Visible = true;

                            preconvert = true;
                        }

                        pictureBox1.Visible = true;
                        lblSelection.Visible = false;

                        if (Properties.Settings.Default.HideToolbar == false) pnControlButtons.Visible = true;
                    }

                    else if (openFileDialog1.FileNames.Length > 1)
                    {
                        btnSave.Enabled = true;
                        lblSelection.Text = openFileDialog1.FileNames.Length + " files selected";

                        if (Properties.Settings.Default.Language == "German") lblSelection.Text = openFileDialog1.FileNames.Length + " Dateien ausgewählt";
                        if (Properties.Settings.Default.Language == "Russian") lblSelection.Text = openFileDialog1.FileNames.Length + " Выбранные файлы";

                        lblSelection.Visible = true;

                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;

                        folderBrowserDialog1.SelectedPath = Path.GetDirectoryName(openFileDialog1.FileNames[0]);
                    }
               }
            }

            catch (Exception ex)
            {
                metroProgressBar1.Visible = false;

                if (Properties.Settings.Default.Language == "English")
                {
                    MessageBox.Show("An error occured. Maybe try running this program as administrator.\n\nError message:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Properties.Settings.Default.Language == "German")
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten. Eventuell müssen Sie das Programm als Administrattor ausführen.\n\nFehlermeldung:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Properties.Settings.Default.Language == "Russian")
                {
                    MessageBox.Show("Там была ошибка. Вам может потребоваться запустить программу от имени администратора.\n\nСообщение об ошибке:\n" + ex.Message, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.FileNames.Length == 1)
                {
                    try
                    {
                        if (fileLocation != "")
                        {
                            saveFileDialog1.InitialDirectory = fileLocation;
                        }

                        saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName);
                    }

                    catch { }

                    if (cmbFileFormat.SelectedItem.ToString() == "Bitmap (*.bmp)")
                    {
                        saveFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp";

                        if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            success();
                        }
                    }

                    else if (cmbFileFormat.SelectedItem.ToString() == "JPEG (*.jpg)")
                    {
                        saveFileDialog1.Filter = "JPEG (*.jpg)|*.jpg";

                        if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                            success();
                        }
                    }

                    else if (cmbFileFormat.SelectedItem.ToString() == "PNG (*.png)")
                    {
                        saveFileDialog1.Filter = "PNG (*.png)|*.png";

                        if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);

                            success();
                        }
                    }

                    else if (cmbFileFormat.SelectedItem.ToString() == "TIFF (*.tiff)")
                    {
                        saveFileDialog1.Filter = "TIFF (*.tiff)|*.tiff";

                        if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {


                            image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Tiff);

                            success();
                        }
                    }

                    else if (cmbFileFormat.SelectedItem.ToString() == "GIF (*.gif)")
                    {
                        saveFileDialog1.Filter = "GIF (*.gif)|*.gif";

                        if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {


                            image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif);

                            success();
                        }
                    }

                    else if (cmbFileFormat.SelectedItem.ToString() == "Icon (*.ico)")
                    {
                        saveFileDialog1.Filter = "Icon (*.ico)|*.ico";

                        if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Icon);

                            success();
                        }
                    }

                    else if (cmbFileFormat.SelectedItem.ToString() == "WMF (*.wmf)")
                    {
                        saveFileDialog1.Filter = "WMF (*.wmf)|*.wmf";

                        if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {


                            image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Wmf);

                            success();
                        }
                    }

                    else if (cmbFileFormat.SelectedItem.ToString() == "EMF (*.emf)")
                    {
                        saveFileDialog1.Filter = "EMF (*.emf)|*.emf";

                        if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {


                            image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Emf);

                            success();
                        }
                    }

                    else if (cmbFileFormat.SelectedItem.ToString() == "EXIF (*.exif)")
                    {
                        saveFileDialog1.Filter = "EXIF (*.exif)|*.exif";

                        if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {


                            image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Exif);

                            success();
                        }
                    }

                    else if (cmbFileFormat.SelectedItem.ToString() == "PDF (*.pdf)")
                    {

                        saveFileDialog1.Filter = "PDF (*.pdf)|*.pdf";

                        if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            Document doc = new Document(PageSize.A4);
                            PdfWriter.GetInstance(doc, new FileStream(saveFileDialog1.FileName, FileMode.Create));
                            doc.Open();
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Bmp);

                            pdfImage.ScaleToFit(doc.PageSize);
                            pdfImage.SetAbsolutePosition(0, 0);

                            doc.Add(pdfImage);
                            doc.Close();

                            success();
                        }

                    }
                }

                else if (openFileDialog1.FileNames.Length > 1) BulkConversion();

            }

            catch (Exception ex)
            {
                if (Properties.Settings.Default.Language == "English")
                {
                    MessageBox.Show("An error occured\n\n"+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Properties.Settings.Default.Language == "German")
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten.\n\n"+ ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Properties.Settings.Default.Language == "Russian")
                {
                    MessageBox.Show("Там была ошибка.\n\n"+ ex.Message, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BulkConversion()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                fileSuccessCounter = 0;

                try
                {
                    foreach (String file in openFileDialog1.FileNames)
                    {
                        System.Drawing.Image img;

                        if (chbNative.Checked)
                        {
                            BitmapDecoder bmpDec = BitmapDecoder.Create(new Uri(file), BitmapCreateOptions.DelayCreation, BitmapCacheOption.None);
                            BitmapEncoder bmpEnc = new BmpBitmapEncoder();
                            bmpEnc.Frames.Add(bmpDec.Frames[0]);
                            Stream ms = new MemoryStream();
                            bmpEnc.Save(ms);
                            img = Bitmap.FromStream(ms);
                        }

                        else img = System.Drawing.Image.FromFile(file);

                        if (cmbFileFormat.SelectedItem.ToString() == "Bitmap (*.bmp)")
                            img.Save(folderBrowserDialog1.SelectedPath + @"\" + Path.GetFileNameWithoutExtension(file) + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);

                        else if (cmbFileFormat.SelectedItem.ToString() == "JPEG (*.jpg)")
                            img.Save(folderBrowserDialog1.SelectedPath + @"\" + Path.GetFileNameWithoutExtension(file) + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

                        else if (cmbFileFormat.SelectedItem.ToString() == "PNG (*.png)")
                            img.Save(folderBrowserDialog1.SelectedPath + @"\" + Path.GetFileNameWithoutExtension(file) + ".png", System.Drawing.Imaging.ImageFormat.Png);

                        else if (cmbFileFormat.SelectedItem.ToString() == "GIF (*.gif)")
                            img.Save(folderBrowserDialog1.SelectedPath + @"\" + Path.GetFileNameWithoutExtension(file) + ".gif", System.Drawing.Imaging.ImageFormat.Gif);

                        else if (cmbFileFormat.SelectedItem.ToString() == "Icon (*.ico)")
                            img.Save(folderBrowserDialog1.SelectedPath + @"\" + Path.GetFileNameWithoutExtension(file) + ".ico", System.Drawing.Imaging.ImageFormat.Icon);

                        else if (cmbFileFormat.SelectedItem.ToString() == "TIFF (*.tiff)")
                            img.Save(folderBrowserDialog1.SelectedPath + @"\" + Path.GetFileNameWithoutExtension(file) + ".tiff", System.Drawing.Imaging.ImageFormat.Tiff);

                        else if (cmbFileFormat.SelectedItem.ToString() == "WMF (*.wmf)")
                            img.Save(folderBrowserDialog1.SelectedPath + @"\" + Path.GetFileNameWithoutExtension(file) + ".tiff", System.Drawing.Imaging.ImageFormat.Wmf);

                        else if (cmbFileFormat.SelectedItem.ToString() == "EMF (*.emf)")
                            img.Save(folderBrowserDialog1.SelectedPath + @"\" + Path.GetFileNameWithoutExtension(file) + ".tiff", System.Drawing.Imaging.ImageFormat.Emf);

                        else if (cmbFileFormat.SelectedItem.ToString() == "EXIF (*.exif)")
                            img.Save(folderBrowserDialog1.SelectedPath + @"\" + Path.GetFileNameWithoutExtension(file) + ".tiff", System.Drawing.Imaging.ImageFormat.Exif);

                        else if (cmbFileFormat.SelectedItem.ToString() == "PDF (*.pdf)")
                        {
                            Document doc = new Document(PageSize.A4);
                            PdfWriter.GetInstance(doc, new FileStream(folderBrowserDialog1.SelectedPath + @"\" + Path.GetFileNameWithoutExtension(file) + ".pdf", FileMode.Create));
                            doc.Open();
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(img, System.Drawing.Imaging.ImageFormat.Bmp);

                            pdfImage.ScaleToFit(doc.PageSize);
                            pdfImage.SetAbsolutePosition(0, 0);

                            doc.Add(pdfImage);
                            doc.Close();
                        }

                        fileSuccessCounter++;
                    }

                    if (Properties.Settings.Default.Language == "English") MessageBox.Show(fileSuccessCounter + " files have been successfully converted");
                    else if (Properties.Settings.Default.Language == "German") MessageBox.Show(fileSuccessCounter + " Dateien wurden erfolgreich konvertiert");
                    else if (Properties.Settings.Default.Language == "Russian") MessageBox.Show(fileSuccessCounter + " файлы были успешно конвертированы");
                }

                catch
                {

                }

            } 
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FormInfo frmInfo = new FormInfo();

            frmInfo.ShowDialog();
        }

        private void MetroProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void success()
        {
            try
            {
                lblPixel.Visible = false;

                if (Path.GetExtension(saveFileDialog1.FileName) != ".pdf")
                {
                    System.Drawing.Image imgprev = System.Drawing.Image.FromFile(saveFileDialog1.FileName);

                    pictureBox2.Image = imgprev;
                }

                if (Properties.Settings.Default.Language == "English")
                {
                    succ1.Text = "Image convertion progress finished.";
                    succ2.Text = "Open file location...";
                }

                else if (Properties.Settings.Default.Language == "German")
                {
                    succ1.Text = "Bild Konvertierungsvorgang abgeschlossen.";
                    succ2.Text = "Speicherort öffnen...";
                }

                else
                {
                    succ1.Text = "Процесс преобразования изображения завершен.";
                    succ2.Text = "Открытое местоположение ...";
                }

                fileLocation = Path.GetDirectoryName(saveFileDialog1.FileName);
                metroToolTip1.SetToolTip(pictureBox2, saveFileDialog1.FileName);
                succ1.Visible = true;
                succ2.Visible = true;
                pictureBox2.Visible = true;

                pictureBox1.Image = null;
                metroToolTip1.SetToolTip(pictureBox1, null);

                pictureBox1.ContextMenuStrip = null;

                pnControlButtons.Visible = false;
            }

            catch
            { }
        }

        private void Succ2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", string.Format("/select,\"{0}\"", saveFileDialog1.FileName));
            }

            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    FileInfo flinf = new FileInfo(openFileDialog1.FileName);


                    if (Properties.Settings.Default.Language == "English")
                    {
                        MessageBox.Show("Path: " + openFileDialog1.FileName + "\n\nResolution (Width x Height): " + image.Width + " x " + image.Height + " pixel\n\nResolution: " + (image.Width * image.Height) / 1000000.0 + " mega pixels\n\nPixel format: " + image.PixelFormat +"\n\nFile size: " + (flinf.Length / 1000) + " KB\n\nFile format: " + Path.GetExtension(openFileDialog1.SafeFileName), "Image properties: " + openFileDialog1.SafeFileName, MessageBoxButtons.OK);
                    }

                    else if (Properties.Settings.Default.Language == "German")
                    {
                        MessageBox.Show("Pfad: " + openFileDialog1.FileName + "\n\nAuflösung (Breite x Höhe): " + image.Width + " x " + image.Height + " pixel\n\nAuflösung: "+ (image.Width * image.Height) / 1000000.0 + " Megapixel\n\nPixel Format: " + image.PixelFormat + "\n\nDateigröße: " + (flinf.Length / 1000) + " KB\n\nDateityp: " + Path.GetExtension(openFileDialog1.SafeFileName), "Bild Eigenschaften: " + openFileDialog1.SafeFileName, MessageBoxButtons.OK);
                    }

                    else
                    {
                        MessageBox.Show("путь: " + openFileDialog1.FileName + "\n\nРазрешение (ширина x высота): " + image.Width + " x " + image.Height + "пиксель\n\nРазрешение: " + (image.Width * image.Height) / 1000000.0 + " мегапиксельную\n\nПиксельный формат: " + image.PixelFormat + "Размер файла: " + (flinf.Length / 1000) + " KB\n\nТип файла: " + Path.GetExtension(openFileDialog1.SafeFileName), "Свойства изображения: " + openFileDialog1.SafeFileName, MessageBoxButtons.OK);
                    }
                }
            }

            catch { }
        }

        private void PictureBox1_BackgroundImageChanged(object sender, EventArgs e)
        {
            
        }

        public static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
        {
            return (System.Drawing.Image)(new Bitmap(imgToResize, size));
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void LblPixel_Click(object sender, EventArgs e)
        {
            ChangeRes();
        }

        private void PfadKopierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(openFileDialog1.FileName);
            }

            catch { }
        }

        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Path.GetDirectoryName(openFileDialog1.FileName));
            }

            catch { }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "German")
            {
                MessageBox.Show("Vor-Konvertieren\n\n\nBeim Vor-Konvertieren wird das importierte Bild als Bitmap vor konvertiert. " +
                    "Wenn Sie Transparente oder Animierte Bilder (wie z.B. *.png, *.tiff, *.gif, ...) importieren wollen, sollten Sie das Vor-Konvertieren deaktivieren. " +
                    "Rohbilder (wie z.B. *.raw, *.cr2, ...) müssen jedoch Vor-Konvertiert werden.\n\nSollte sich ein Bild nicht importieren lassen, " +
                    "stellen Sie sicher, dass das Vor-Konvertieren aktviert ist.", "Hilfe über das Vor-Konvertieren", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (Properties.Settings.Default.Language == "Russian")
            {
                MessageBox.Show("Предварительно Преобразовать\n\n\nВо время предварительного преобразования импортированное изображение преобразуется как растровое изображение ранее. " +
                    "Если вы хотите импортировать баннеры или анимированные изображения (например, * .png, * .tiff, * .gif, ...), вы должны отключить предварительную конвертацию. " +
                    "Однако необработанные изображения (такие как * .raw, * .cr2, ...) необходимо предварительно преобразовать.\n\nЕсли изображение не может быть импортировано, убедитесь," +
                    " что предварительное преобразование включено.", "Hilfe über das Vor-Konvertieren", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Pre-Convert\n\n\nIn Pre-Convert mode all imported images will be pre converterted as bitmap images. " +
                    "If you want to import transparent or animated images (eg. *.png, *.tiff, *.gif, ...) you should deactivate the Pre-Convert function. " +
                    "RAW images (eg. *.raw, *.cr2, ...) on the other hand need to be pre converted.\n\nIf an image can not be imported, " +
                    "make sure that the Pre-Convert funtion is enabled.", "Help about Pre-Convert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loading()
        {
            metroProgressBar1.Visible = true;
        }

        private void ReImportImageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ReimportImage();
        }

        private void ChangeResolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeRes();
        }

        private void RotateImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateImage90();
        }

        private void FlipImageVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerticalFlip();
        }

        private void FlipImageHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HorizontalFlip();
        }

        private void RoteImage270ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                image.RotateFlip(RotateFlipType.Rotate180FlipNone);

                pictureBox1.Image = image;
                lblPixel.Text = image.Width + " x " + image.Height;
            }

            catch { }
        }

        private void ConvertImageBlackwhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertToGreyscale();
        }
        

        private void LblImageName_Click(object sender, EventArgs e)
        {
            infoToolStripMenuItem.PerformClick();
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            succ1.Visible = false;
            succ2.Visible = false;
            pictureBox2.Visible = false;
            pictureBox2.Image = null;
            lblImageName.Visible = false;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
                openFileDialog1.FileName = file;

            openDragDrop();
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void openDragDrop()
        {
            try
            {
                try
                {
                    if (openLocation != "")
                    {
                        openFileDialog1.InitialDirectory = openLocation;
                    }
                }

                catch { }

                loading();
                string extension = Path.GetExtension(openFileDialog1.FileName);

                if (!chbNative.Checked)
                {
                    System.Drawing.Image srcImage;
                    srcImage = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                    image = System.Drawing.Image.FromFile(openFileDialog1.FileName);

                    pictureBox1.Image = srcImage;
                    metroToolTip1.SetToolTip(pictureBox1, openFileDialog1.FileName);

                    btnSave.Enabled = true;

                    image = srcImage;
                    pictureBox1.Image = srcImage;
                    metroToolTip1.SetToolTip(pictureBox1, openFileDialog1.FileName);

                    string path = openFileDialog1.FileName;
                    btnSave.Enabled = true;

                    metroProgressBar1.Visible = false;
                    openLocation = Path.GetDirectoryName(openFileDialog1.FileName);

                    lblPixel.Text = srcImage.Width + " x " + srcImage.Height;
                    lblPixel.Visible = true;

                    pictureBox1.ContextMenuStrip = metroContextMenu1;

                    lblImageName.Text = Path.GetFileName(openFileDialog1.FileName);
                    lblImageName.Visible = true;

                    preconvert = false;
                }

                else
                {
                    BitmapDecoder bmpDec = BitmapDecoder.Create(new Uri(openFileDialog1.FileName),
                    BitmapCreateOptions.DelayCreation, BitmapCacheOption.None);
                    BitmapEncoder bmpEnc = new BmpBitmapEncoder();
                    bmpEnc.Frames.Add(bmpDec.Frames[0]);
                    Stream ms = new MemoryStream();
                    bmpEnc.Save(ms);
                    System.Drawing.Image srcImage = Bitmap.FromStream(ms);

                    image = srcImage;
                    pictureBox1.Image = srcImage;
                    metroToolTip1.SetToolTip(pictureBox1, openFileDialog1.FileName);

                    string path = openFileDialog1.FileName;
                    btnSave.Enabled = true;

                    metroProgressBar1.Visible = false;
                    openLocation = Path.GetDirectoryName(openFileDialog1.FileName);

                    lblPixel.Text = srcImage.Width + " x " + srcImage.Height;
                    lblPixel.Visible = true;

                    pictureBox1.ContextMenuStrip = metroContextMenu1;

                    lblImageName.Text = Path.GetFileName(openFileDialog1.FileName);
                    lblImageName.Visible = true;

                    preconvert = true;
                }

                if (!Properties.Settings.Default.HideToolbar) pnControlButtons.Visible = true;
            }

            catch (Exception ex)
            {
                metroProgressBar1.Visible = false;

                if (Properties.Settings.Default.Language == "English")
                {
                    MessageBox.Show("An error occured. Maybe try running this program as administrator.\n\nError message:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Properties.Settings.Default.Language == "German")
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten. Eventuell müssen Sie das Programm als Administrattor ausführen.\n\nFehlermeldung:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Properties.Settings.Default.Language == "Russian")
                {
                    MessageBox.Show("Там была ошибка. Вам может потребоваться запустить программу от имени администратора.\n\nСообщение об ошибке:\n" + ex.Message, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            succ1.Visible = false;
            succ2.Visible = false;
            pictureBox2.Visible = false;
            pictureBox2.Image = null;
            lblImageName.Visible = false;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
                openFileDialog1.FileName = file;

            openDragDrop();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreviewImage();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            previewToolStripMenuItem.PerformClick();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSettings frmSet = new FormSettings();

            if (frmSet.ShowDialog() == DialogResult.OK)
            {
                if (frmSet.getLang() == 0)
                {
                    langENG(); Properties.Settings.Default.Language = "English";
                }

                if (frmSet.getLang() == 1)
                {
                    langGER(); Properties.Settings.Default.Language = "German";
                }

                if (frmSet.getLang() == 2)
                {
                    langRUS(); Properties.Settings.Default.Language = "Russian";
                }

                if (Properties.Settings.Default.HideToolbar == true) pnControlButtons.Visible = false;
            }
        }

        private void lblSelection_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Path.GetDirectoryName(openFileDialog1.FileNames[0]));
            }

            catch { }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            ReimportImage();
        }

        private void btnRotateAnti_Click(object sender, EventArgs e)
        {
            RotateImage270();
        }

        private void btnRotateClock_Click(object sender, EventArgs e)
        {
            RotateImage90();
        }

        private void btnChangeRes_Click(object sender, EventArgs e)
        {
            ChangeRes();
        }

        private void btnGreyscale_Click(object sender, EventArgs e)
        {
            ConvertToGreyscale();
        }

        private void btnFlipHorizontal_Click(object sender, EventArgs e)
        {
            HorizontalFlip();
        }

        private void btnFlipVertical_Click(object sender, EventArgs e)
        {
            VerticalFlip();
        }

        #endregion
    }
}
