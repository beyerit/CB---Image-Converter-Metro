namespace CB___Image_Converter_Metro
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSelect = new MetroFramework.Controls.MetroTile();
            this.chbNative = new MetroFramework.Controls.MetroCheckBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lblPixel = new MetroFramework.Controls.MetroLink();
            this.btnChangeRes = new MetroFramework.Controls.MetroButton();
            this.btnFlipHorizontal = new MetroFramework.Controls.MetroButton();
            this.btnFlipVertical = new MetroFramework.Controls.MetroButton();
            this.btnGreyscale = new MetroFramework.Controls.MetroButton();
            this.btnPreview = new MetroFramework.Controls.MetroButton();
            this.btnRotateClock = new MetroFramework.Controls.MetroButton();
            this.btnRotateAnti = new MetroFramework.Controls.MetroButton();
            this.btnRevert = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbFileFormat = new MetroFramework.Controls.MetroComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changeResolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reImportImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pfadKopierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rotateImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roteImage270ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipImageHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipImageVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.convertImageBlackwhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.succ1 = new MetroFramework.Controls.MetroLabel();
            this.succ2 = new MetroFramework.Controls.MetroLink();
            this.lblImageName = new MetroFramework.Controls.MetroLink();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSelection = new MetroFramework.Controls.MetroLink();
            this.pnControlButtons = new System.Windows.Forms.Panel();
            this.btnSettings = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            this.pnControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.chbNative);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(23, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 160);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "select image";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CB___Image_Converter_Metro.Properties.Resources._24;
            this.pictureBox3.Location = new System.Drawing.Point(199, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.ActiveControl = null;
            this.btnSelect.Location = new System.Drawing.Point(82, 41);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(147, 56);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.TileImage = global::CB___Image_Converter_Metro.Properties.Resources._5325;
            this.btnSelect.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.btnSelect, "select image");
            this.btnSelect.UseSelectable = true;
            this.btnSelect.UseTileImage = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // chbNative
            // 
            this.chbNative.AutoSize = true;
            this.chbNative.Checked = true;
            this.chbNative.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbNative.Location = new System.Drawing.Point(102, 121);
            this.chbNative.Name = "chbNative";
            this.chbNative.Size = new System.Drawing.Size(87, 15);
            this.chbNative.TabIndex = 3;
            this.chbNative.Text = "Pre-Convert";
            this.chbNative.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chbNative.UseSelectable = true;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblPixel
            // 
            this.lblPixel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPixel.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lblPixel.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lblPixel.Location = new System.Drawing.Point(408, 577);
            this.lblPixel.Name = "lblPixel";
            this.lblPixel.Size = new System.Drawing.Size(416, 23);
            this.lblPixel.TabIndex = 13;
            this.lblPixel.Text = "0 x 0";
            this.lblPixel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.lblPixel, "Change resolution...");
            this.lblPixel.UseSelectable = true;
            this.lblPixel.Visible = false;
            this.lblPixel.Click += new System.EventHandler(this.LblPixel_Click);
            // 
            // btnChangeRes
            // 
            this.btnChangeRes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChangeRes.BackgroundImage = global::CB___Image_Converter_Metro.Properties.Resources.IconGroup5366;
            this.btnChangeRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangeRes.Location = new System.Drawing.Point(96, 3);
            this.btnChangeRes.Name = "btnChangeRes";
            this.btnChangeRes.Size = new System.Drawing.Size(32, 33);
            this.btnChangeRes.TabIndex = 26;
            this.btnChangeRes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.btnChangeRes, "Change resolution");
            this.btnChangeRes.UseSelectable = true;
            this.btnChangeRes.Click += new System.EventHandler(this.btnChangeRes_Click);
            // 
            // btnFlipHorizontal
            // 
            this.btnFlipHorizontal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFlipHorizontal.BackgroundImage = global::CB___Image_Converter_Metro.Properties.Resources.IconGroup5344;
            this.btnFlipHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFlipHorizontal.Location = new System.Drawing.Point(134, 3);
            this.btnFlipHorizontal.Name = "btnFlipHorizontal";
            this.btnFlipHorizontal.Size = new System.Drawing.Size(32, 33);
            this.btnFlipHorizontal.TabIndex = 25;
            this.btnFlipHorizontal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.btnFlipHorizontal, "Flip horizontally");
            this.btnFlipHorizontal.UseSelectable = true;
            this.btnFlipHorizontal.Click += new System.EventHandler(this.btnFlipHorizontal_Click);
            // 
            // btnFlipVertical
            // 
            this.btnFlipVertical.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFlipVertical.BackgroundImage = global::CB___Image_Converter_Metro.Properties.Resources.IconGroup5345;
            this.btnFlipVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFlipVertical.Location = new System.Drawing.Point(248, 3);
            this.btnFlipVertical.Name = "btnFlipVertical";
            this.btnFlipVertical.Size = new System.Drawing.Size(32, 33);
            this.btnFlipVertical.TabIndex = 24;
            this.btnFlipVertical.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.btnFlipVertical, "Flip vertically");
            this.btnFlipVertical.UseSelectable = true;
            this.btnFlipVertical.Click += new System.EventHandler(this.btnFlipVertical_Click);
            // 
            // btnGreyscale
            // 
            this.btnGreyscale.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGreyscale.BackgroundImage = global::CB___Image_Converter_Metro.Properties.Resources.IconGroup70;
            this.btnGreyscale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGreyscale.Location = new System.Drawing.Point(286, 3);
            this.btnGreyscale.Name = "btnGreyscale";
            this.btnGreyscale.Size = new System.Drawing.Size(32, 33);
            this.btnGreyscale.TabIndex = 23;
            this.btnGreyscale.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.btnGreyscale, "Convert image to greyscale");
            this.btnGreyscale.UseSelectable = true;
            this.btnGreyscale.Click += new System.EventHandler(this.btnGreyscale_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPreview.BackgroundImage = global::CB___Image_Converter_Metro.Properties.Resources.IconGroup177;
            this.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreview.Location = new System.Drawing.Point(324, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(32, 33);
            this.btnPreview.TabIndex = 22;
            this.btnPreview.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.btnPreview, "Preview image");
            this.btnPreview.UseSelectable = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnRotateClock
            // 
            this.btnRotateClock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRotateClock.BackgroundImage = global::CB___Image_Converter_Metro.Properties.Resources.IconGroup5311;
            this.btnRotateClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRotateClock.Location = new System.Drawing.Point(210, 3);
            this.btnRotateClock.Name = "btnRotateClock";
            this.btnRotateClock.Size = new System.Drawing.Size(32, 33);
            this.btnRotateClock.TabIndex = 21;
            this.btnRotateClock.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.btnRotateClock, "Rotate clock-wise");
            this.btnRotateClock.UseSelectable = true;
            this.btnRotateClock.Click += new System.EventHandler(this.btnRotateClock_Click);
            // 
            // btnRotateAnti
            // 
            this.btnRotateAnti.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRotateAnti.BackgroundImage = global::CB___Image_Converter_Metro.Properties.Resources.IconGroup5315;
            this.btnRotateAnti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRotateAnti.Location = new System.Drawing.Point(172, 3);
            this.btnRotateAnti.Name = "btnRotateAnti";
            this.btnRotateAnti.Size = new System.Drawing.Size(32, 33);
            this.btnRotateAnti.TabIndex = 20;
            this.btnRotateAnti.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.btnRotateAnti, "Rotate anti-clockwise");
            this.btnRotateAnti.UseSelectable = true;
            this.btnRotateAnti.Click += new System.EventHandler(this.btnRotateAnti_Click);
            // 
            // btnRevert
            // 
            this.btnRevert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRevert.BackgroundImage = global::CB___Image_Converter_Metro.Properties.Resources.IconGroup167391;
            this.btnRevert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRevert.Location = new System.Drawing.Point(58, 3);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(32, 33);
            this.btnRevert.TabIndex = 19;
            this.btnRevert.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.btnRevert, "Re-import image (revert changes)");
            this.btnRevert.UseSelectable = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(82, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 56);
            this.btnSave.TabIndex = 1;
            this.btnSave.TileImage = global::CB___Image_Converter_Metro.Properties.Resources._16761;
            this.btnSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.btnSave, "save image");
            this.btnSave.UseSelectable = true;
            this.btnSave.UseTileImage = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbFileFormat);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(23, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 110);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "file format";
            // 
            // cmbFileFormat
            // 
            this.cmbFileFormat.FormattingEnabled = true;
            this.cmbFileFormat.ItemHeight = 23;
            this.cmbFileFormat.Items.AddRange(new object[] {
            "JPEG (*.jpg)",
            "PNG (*.png)",
            "Bitmap (*.bmp)",
            "GIF (*.gif)",
            "TIFF (*.tiff)",
            "Icon (*.ico)",
            "WMF (*.wmf)",
            "EMF (*.emf)",
            "EXIF (*.exif)",
            "PDF (*.pdf)"});
            this.cmbFileFormat.Location = new System.Drawing.Point(82, 46);
            this.cmbFileFormat.Name = "cmbFileFormat";
            this.cmbFileFormat.PromptText = "JPEG (*.jpg)";
            this.cmbFileFormat.Size = new System.Drawing.Size(147, 29);
            this.cmbFileFormat.TabIndex = 1;
            this.cmbFileFormat.Tag = "";
            this.cmbFileFormat.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbFileFormat.UseSelectable = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(23, 400);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 126);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "save";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewToolStripMenuItem,
            this.toolStripSeparator5,
            this.infoToolStripMenuItem,
            this.toolStripSeparator1,
            this.changeResolutionToolStripMenuItem,
            this.reImportImageToolStripMenuItem,
            this.toolStripSeparator2,
            this.openFolderToolStripMenuItem,
            this.pfadKopierenToolStripMenuItem,
            this.toolStripSeparator3,
            this.rotateImageToolStripMenuItem,
            this.roteImage270ToolStripMenuItem,
            this.flipImageHorizontallyToolStripMenuItem,
            this.flipImageVerticallyToolStripMenuItem,
            this.toolStripSeparator4,
            this.convertImageBlackwhiteToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(219, 276);
            this.metroContextMenu1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(215, 6);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.infoToolStripMenuItem.Text = "Image properties";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // changeResolutionToolStripMenuItem
            // 
            this.changeResolutionToolStripMenuItem.Name = "changeResolutionToolStripMenuItem";
            this.changeResolutionToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.changeResolutionToolStripMenuItem.Text = "Change resolution";
            this.changeResolutionToolStripMenuItem.Click += new System.EventHandler(this.ChangeResolutionToolStripMenuItem_Click);
            // 
            // reImportImageToolStripMenuItem
            // 
            this.reImportImageToolStripMenuItem.Name = "reImportImageToolStripMenuItem";
            this.reImportImageToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.reImportImageToolStripMenuItem.Text = "Re-import image";
            this.reImportImageToolStripMenuItem.Click += new System.EventHandler(this.ReImportImageToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.openFolderToolStripMenuItem.Text = "Open folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenFolderToolStripMenuItem_Click);
            // 
            // pfadKopierenToolStripMenuItem
            // 
            this.pfadKopierenToolStripMenuItem.Name = "pfadKopierenToolStripMenuItem";
            this.pfadKopierenToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.pfadKopierenToolStripMenuItem.Text = "Copy path";
            this.pfadKopierenToolStripMenuItem.Click += new System.EventHandler(this.PfadKopierenToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            // 
            // rotateImageToolStripMenuItem
            // 
            this.rotateImageToolStripMenuItem.Name = "rotateImageToolStripMenuItem";
            this.rotateImageToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.rotateImageToolStripMenuItem.Text = "Rotate image 90°";
            this.rotateImageToolStripMenuItem.Click += new System.EventHandler(this.RotateImageToolStripMenuItem_Click);
            // 
            // roteImage270ToolStripMenuItem
            // 
            this.roteImage270ToolStripMenuItem.Name = "roteImage270ToolStripMenuItem";
            this.roteImage270ToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.roteImage270ToolStripMenuItem.Text = "Rote image 180°";
            this.roteImage270ToolStripMenuItem.Click += new System.EventHandler(this.RoteImage270ToolStripMenuItem_Click);
            // 
            // flipImageHorizontallyToolStripMenuItem
            // 
            this.flipImageHorizontallyToolStripMenuItem.Name = "flipImageHorizontallyToolStripMenuItem";
            this.flipImageHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.flipImageHorizontallyToolStripMenuItem.Text = "Flip image horizontally";
            this.flipImageHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.FlipImageHorizontallyToolStripMenuItem_Click);
            // 
            // flipImageVerticallyToolStripMenuItem
            // 
            this.flipImageVerticallyToolStripMenuItem.Name = "flipImageVerticallyToolStripMenuItem";
            this.flipImageVerticallyToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.flipImageVerticallyToolStripMenuItem.Text = "Flip image vertically";
            this.flipImageVerticallyToolStripMenuItem.Click += new System.EventHandler(this.FlipImageVerticallyToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(215, 6);
            // 
            // convertImageBlackwhiteToolStripMenuItem
            // 
            this.convertImageBlackwhiteToolStripMenuItem.Name = "convertImageBlackwhiteToolStripMenuItem";
            this.convertImageBlackwhiteToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.convertImageBlackwhiteToolStripMenuItem.Text = "Convert image to greyscale";
            this.convertImageBlackwhiteToolStripMenuItem.Click += new System.EventHandler(this.ConvertImageBlackwhiteToolStripMenuItem_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.Location = new System.Drawing.Point(490, 312);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(253, 23);
            this.metroProgressBar1.TabIndex = 7;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressBar1.Value = 40;
            this.metroProgressBar1.Visible = false;
            this.metroProgressBar1.Click += new System.EventHandler(this.MetroProgressBar1_Click);
            // 
            // succ1
            // 
            this.succ1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.succ1.AutoSize = true;
            this.succ1.Location = new System.Drawing.Point(499, 290);
            this.succ1.Name = "succ1";
            this.succ1.Size = new System.Drawing.Size(235, 19);
            this.succ1.TabIndex = 8;
            this.succ1.Text = "Konvertierungsvorgang abgeschlossen.";
            this.succ1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.succ1.Visible = false;
            // 
            // succ2
            // 
            this.succ2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.succ2.Location = new System.Drawing.Point(551, 313);
            this.succ2.Name = "succ2";
            this.succ2.Size = new System.Drawing.Size(141, 23);
            this.succ2.TabIndex = 9;
            this.succ2.Text = "Speicherort öffnen...";
            this.succ2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.succ2.UseSelectable = true;
            this.succ2.Visible = false;
            this.succ2.Click += new System.EventHandler(this.Succ2_Click);
            // 
            // lblImageName
            // 
            this.lblImageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImageName.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lblImageName.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lblImageName.Location = new System.Drawing.Point(408, 38);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(416, 30);
            this.lblImageName.TabIndex = 14;
            this.lblImageName.Text = "Filename";
            this.lblImageName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblImageName.UseSelectable = true;
            this.lblImageName.Visible = false;
            this.lblImageName.Click += new System.EventHandler(this.LblImageName_Click);
            // 
            // lblSelection
            // 
            this.lblSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelection.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lblSelection.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lblSelection.Location = new System.Drawing.Point(408, 306);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(416, 30);
            this.lblSelection.TabIndex = 16;
            this.lblSelection.Text = "0 files selected";
            this.lblSelection.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblSelection.UseSelectable = true;
            this.lblSelection.Visible = false;
            this.lblSelection.Click += new System.EventHandler(this.lblSelection_Click);
            // 
            // pnControlButtons
            // 
            this.pnControlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnControlButtons.Controls.Add(this.btnChangeRes);
            this.pnControlButtons.Controls.Add(this.btnFlipHorizontal);
            this.pnControlButtons.Controls.Add(this.btnFlipVertical);
            this.pnControlButtons.Controls.Add(this.btnGreyscale);
            this.pnControlButtons.Controls.Add(this.btnPreview);
            this.pnControlButtons.Controls.Add(this.btnRotateClock);
            this.pnControlButtons.Controls.Add(this.btnRotateAnti);
            this.pnControlButtons.Controls.Add(this.btnRevert);
            this.pnControlButtons.Location = new System.Drawing.Point(408, 534);
            this.pnControlButtons.Name = "pnControlButtons";
            this.pnControlButtons.Size = new System.Drawing.Size(416, 40);
            this.pnControlButtons.TabIndex = 20;
            this.pnControlButtons.Visible = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::CB___Image_Converter_Metro.Properties.Resources._16826;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Location = new System.Drawing.Point(71, 546);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(32, 33);
            this.btnSettings.TabIndex = 15;
            this.btnSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSettings.UseSelectable = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Location = new System.Drawing.Point(426, 431);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::CB___Image_Converter_Metro.Properties.Resources._1001;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Location = new System.Drawing.Point(23, 546);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(32, 33);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(408, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.BackgroundImageChanged += new System.EventHandler(this.PictureBox1_BackgroundImageChanged);
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox1_DragEnter);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 615);
            this.Controls.Add(this.pnControlButtons);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.lblPixel);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.succ2);
            this.Controls.Add(this.succ1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(886, 615);
            this.Name = "FormMain";
            this.Text = "CB - Image Converter";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.metroContextMenu1.ResumeLayout(false);
            this.pnControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTile btnSelect;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox cmbFileFormat;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTile btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel succ1;
        private MetroFramework.Controls.MetroLink succ2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private MetroFramework.Controls.MetroLink lblPixel;
        private System.Windows.Forms.ToolStripMenuItem pfadKopierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reImportImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeResolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem rotateImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipImageVerticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipImageHorizontallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roteImage270ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem convertImageBlackwhiteToolStripMenuItem;
        private MetroFramework.Controls.MetroLink lblImageName;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private MetroFramework.Controls.MetroButton btnSettings;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroCheckBox chbNative;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MetroFramework.Controls.MetroLink lblSelection;
        private MetroFramework.Controls.MetroButton btnRevert;
        private System.Windows.Forms.Panel pnControlButtons;
        private MetroFramework.Controls.MetroButton btnRotateClock;
        private MetroFramework.Controls.MetroButton btnRotateAnti;
        private MetroFramework.Controls.MetroButton btnPreview;
        private MetroFramework.Controls.MetroButton btnGreyscale;
        private MetroFramework.Controls.MetroButton btnFlipVertical;
        private MetroFramework.Controls.MetroButton btnFlipHorizontal;
        private MetroFramework.Controls.MetroButton btnChangeRes;
    }
}

