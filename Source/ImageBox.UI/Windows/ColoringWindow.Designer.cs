
namespace ImageBox.UI.Windows
{
    partial class ColoringWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColoringWindow));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CustomGroupBox = new System.Windows.Forms.GroupBox();
            this.BlueTrackBar = new System.Windows.Forms.TrackBar();
            this.GreenTrackBar = new System.Windows.Forms.TrackBar();
            this.RedLabel = new System.Windows.Forms.Label();
            this.RedPictureBox = new System.Windows.Forms.PictureBox();
            this.BrightnessValueLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.SaturationValueLabel = new System.Windows.Forms.Label();
            this.GreenPictureBox = new System.Windows.Forms.PictureBox();
            this.ContrastValueLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.BrightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.BluePictureBox = new System.Windows.Forms.PictureBox();
            this.SaturationTrackBar = new System.Windows.Forms.TrackBar();
            this.RedTrackBar = new System.Windows.Forms.TrackBar();
            this.ContrastTrackBar = new System.Windows.Forms.TrackBar();
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.RedValueLabel = new System.Windows.Forms.Label();
            this.SaturationLabel = new System.Windows.Forms.Label();
            this.GreenValueLabel = new System.Windows.Forms.Label();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.BlueValueLabel = new System.Windows.Forms.Label();
            this.PresetGroupBox = new System.Windows.Forms.GroupBox();
            this.PresetValueLabel = new System.Windows.Forms.Label();
            this.PresetTrackBar = new System.Windows.Forms.TrackBar();
            this.PresetComboBox = new System.Windows.Forms.ComboBox();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.OriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.ModifiedPictureBox = new System.Windows.Forms.PictureBox();
            this.MainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImageBoxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.imageBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainPanel.SuspendLayout();
            this.CustomGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).BeginInit();
            this.PresetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PresetTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifiedPictureBox)).BeginInit();
            this.ImageBoxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CustomGroupBox);
            this.MainPanel.Controls.Add(this.PresetGroupBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 436);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(884, 126);
            this.MainPanel.TabIndex = 0;
            // 
            // CustomGroupBox
            // 
            this.CustomGroupBox.Controls.Add(this.BlueTrackBar);
            this.CustomGroupBox.Controls.Add(this.GreenTrackBar);
            this.CustomGroupBox.Controls.Add(this.RedLabel);
            this.CustomGroupBox.Controls.Add(this.RedPictureBox);
            this.CustomGroupBox.Controls.Add(this.BrightnessValueLabel);
            this.CustomGroupBox.Controls.Add(this.GreenLabel);
            this.CustomGroupBox.Controls.Add(this.SaturationValueLabel);
            this.CustomGroupBox.Controls.Add(this.GreenPictureBox);
            this.CustomGroupBox.Controls.Add(this.ContrastValueLabel);
            this.CustomGroupBox.Controls.Add(this.BlueLabel);
            this.CustomGroupBox.Controls.Add(this.BrightnessTrackBar);
            this.CustomGroupBox.Controls.Add(this.BluePictureBox);
            this.CustomGroupBox.Controls.Add(this.SaturationTrackBar);
            this.CustomGroupBox.Controls.Add(this.RedTrackBar);
            this.CustomGroupBox.Controls.Add(this.ContrastTrackBar);
            this.CustomGroupBox.Controls.Add(this.BrightnessLabel);
            this.CustomGroupBox.Controls.Add(this.RedValueLabel);
            this.CustomGroupBox.Controls.Add(this.SaturationLabel);
            this.CustomGroupBox.Controls.Add(this.GreenValueLabel);
            this.CustomGroupBox.Controls.Add(this.ContrastLabel);
            this.CustomGroupBox.Controls.Add(this.BlueValueLabel);
            this.CustomGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomGroupBox.Location = new System.Drawing.Point(200, 0);
            this.CustomGroupBox.Name = "CustomGroupBox";
            this.CustomGroupBox.Size = new System.Drawing.Size(684, 126);
            this.CustomGroupBox.TabIndex = 23;
            this.CustomGroupBox.TabStop = false;
            this.CustomGroupBox.Text = "Custom";
            // 
            // BlueTrackBar
            // 
            this.BlueTrackBar.LargeChange = 10;
            this.BlueTrackBar.Location = new System.Drawing.Point(79, 87);
            this.BlueTrackBar.Maximum = 1000;
            this.BlueTrackBar.Name = "BlueTrackBar";
            this.BlueTrackBar.Size = new System.Drawing.Size(187, 45);
            this.BlueTrackBar.TabIndex = 9;
            this.BlueTrackBar.Value = 100;
            this.BlueTrackBar.Scroll += new System.EventHandler(this.BlueTrackBarScroll);
            // 
            // GreenTrackBar
            // 
            this.GreenTrackBar.LargeChange = 10;
            this.GreenTrackBar.Location = new System.Drawing.Point(79, 49);
            this.GreenTrackBar.Maximum = 1000;
            this.GreenTrackBar.Name = "GreenTrackBar";
            this.GreenTrackBar.Size = new System.Drawing.Size(187, 45);
            this.GreenTrackBar.TabIndex = 10;
            this.GreenTrackBar.Value = 100;
            this.GreenTrackBar.Scroll += new System.EventHandler(this.GreenTrackBarScroll);
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Location = new System.Drawing.Point(6, 25);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(27, 13);
            this.RedLabel.TabIndex = 0;
            this.RedLabel.Text = "Red";
            // 
            // RedPictureBox
            // 
            this.RedPictureBox.BackColor = System.Drawing.Color.Red;
            this.RedPictureBox.Location = new System.Drawing.Point(48, 18);
            this.RedPictureBox.Name = "RedPictureBox";
            this.RedPictureBox.Size = new System.Drawing.Size(25, 25);
            this.RedPictureBox.TabIndex = 3;
            this.RedPictureBox.TabStop = false;
            // 
            // BrightnessValueLabel
            // 
            this.BrightnessValueLabel.AutoSize = true;
            this.BrightnessValueLabel.Location = new System.Drawing.Point(561, 87);
            this.BrightnessValueLabel.Name = "BrightnessValueLabel";
            this.BrightnessValueLabel.Size = new System.Drawing.Size(28, 13);
            this.BrightnessValueLabel.TabIndex = 22;
            this.BrightnessValueLabel.Text = "0.00";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Location = new System.Drawing.Point(6, 56);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(36, 13);
            this.GreenLabel.TabIndex = 4;
            this.GreenLabel.Text = "Green";
            // 
            // SaturationValueLabel
            // 
            this.SaturationValueLabel.AutoSize = true;
            this.SaturationValueLabel.Location = new System.Drawing.Point(561, 56);
            this.SaturationValueLabel.Name = "SaturationValueLabel";
            this.SaturationValueLabel.Size = new System.Drawing.Size(28, 13);
            this.SaturationValueLabel.TabIndex = 21;
            this.SaturationValueLabel.Text = "1.00";
            // 
            // GreenPictureBox
            // 
            this.GreenPictureBox.BackColor = System.Drawing.Color.Green;
            this.GreenPictureBox.Location = new System.Drawing.Point(48, 49);
            this.GreenPictureBox.Name = "GreenPictureBox";
            this.GreenPictureBox.Size = new System.Drawing.Size(25, 25);
            this.GreenPictureBox.TabIndex = 5;
            this.GreenPictureBox.TabStop = false;
            // 
            // ContrastValueLabel
            // 
            this.ContrastValueLabel.AutoSize = true;
            this.ContrastValueLabel.Location = new System.Drawing.Point(561, 25);
            this.ContrastValueLabel.Name = "ContrastValueLabel";
            this.ContrastValueLabel.Size = new System.Drawing.Size(28, 13);
            this.ContrastValueLabel.TabIndex = 20;
            this.ContrastValueLabel.Text = "1.00";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Location = new System.Drawing.Point(6, 87);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(28, 13);
            this.BlueLabel.TabIndex = 6;
            this.BlueLabel.Text = "Blue";
            // 
            // BrightnessTrackBar
            // 
            this.BrightnessTrackBar.Location = new System.Drawing.Point(369, 80);
            this.BrightnessTrackBar.Maximum = 100;
            this.BrightnessTrackBar.Minimum = -100;
            this.BrightnessTrackBar.Name = "BrightnessTrackBar";
            this.BrightnessTrackBar.Size = new System.Drawing.Size(187, 45);
            this.BrightnessTrackBar.TabIndex = 19;
            this.BrightnessTrackBar.Scroll += new System.EventHandler(this.BrightnessTrackBarScroll);
            // 
            // BluePictureBox
            // 
            this.BluePictureBox.BackColor = System.Drawing.Color.Blue;
            this.BluePictureBox.Location = new System.Drawing.Point(48, 80);
            this.BluePictureBox.Name = "BluePictureBox";
            this.BluePictureBox.Size = new System.Drawing.Size(25, 25);
            this.BluePictureBox.TabIndex = 7;
            this.BluePictureBox.TabStop = false;
            // 
            // SaturationTrackBar
            // 
            this.SaturationTrackBar.Location = new System.Drawing.Point(368, 49);
            this.SaturationTrackBar.Maximum = 1000;
            this.SaturationTrackBar.Name = "SaturationTrackBar";
            this.SaturationTrackBar.Size = new System.Drawing.Size(187, 45);
            this.SaturationTrackBar.TabIndex = 18;
            this.SaturationTrackBar.Value = 100;
            this.SaturationTrackBar.Scroll += new System.EventHandler(this.SaturationTrackBarScroll);
            // 
            // RedTrackBar
            // 
            this.RedTrackBar.LargeChange = 10;
            this.RedTrackBar.Location = new System.Drawing.Point(79, 18);
            this.RedTrackBar.Maximum = 1000;
            this.RedTrackBar.Name = "RedTrackBar";
            this.RedTrackBar.Size = new System.Drawing.Size(187, 45);
            this.RedTrackBar.TabIndex = 8;
            this.RedTrackBar.Value = 100;
            this.RedTrackBar.Scroll += new System.EventHandler(this.RedTrackBarScroll);
            // 
            // ContrastTrackBar
            // 
            this.ContrastTrackBar.Location = new System.Drawing.Point(368, 18);
            this.ContrastTrackBar.Maximum = 200;
            this.ContrastTrackBar.Name = "ContrastTrackBar";
            this.ContrastTrackBar.Size = new System.Drawing.Size(187, 45);
            this.ContrastTrackBar.TabIndex = 17;
            this.ContrastTrackBar.Value = 100;
            this.ContrastTrackBar.Scroll += new System.EventHandler(this.ContrastTrackBarScroll);
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.Location = new System.Drawing.Point(307, 87);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(56, 13);
            this.BrightnessLabel.TabIndex = 16;
            this.BrightnessLabel.Text = "Brightness";
            // 
            // RedValueLabel
            // 
            this.RedValueLabel.AutoSize = true;
            this.RedValueLabel.Location = new System.Drawing.Point(272, 25);
            this.RedValueLabel.Name = "RedValueLabel";
            this.RedValueLabel.Size = new System.Drawing.Size(33, 13);
            this.RedValueLabel.TabIndex = 11;
            this.RedValueLabel.Text = "100%";
            // 
            // SaturationLabel
            // 
            this.SaturationLabel.AutoSize = true;
            this.SaturationLabel.Location = new System.Drawing.Point(307, 56);
            this.SaturationLabel.Name = "SaturationLabel";
            this.SaturationLabel.Size = new System.Drawing.Size(55, 13);
            this.SaturationLabel.TabIndex = 15;
            this.SaturationLabel.Text = "Saturation";
            // 
            // GreenValueLabel
            // 
            this.GreenValueLabel.AutoSize = true;
            this.GreenValueLabel.Location = new System.Drawing.Point(272, 56);
            this.GreenValueLabel.Name = "GreenValueLabel";
            this.GreenValueLabel.Size = new System.Drawing.Size(33, 13);
            this.GreenValueLabel.TabIndex = 12;
            this.GreenValueLabel.Text = "100%";
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.Location = new System.Drawing.Point(316, 25);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(46, 13);
            this.ContrastLabel.TabIndex = 14;
            this.ContrastLabel.Text = "Contrast";
            // 
            // BlueValueLabel
            // 
            this.BlueValueLabel.AutoSize = true;
            this.BlueValueLabel.Location = new System.Drawing.Point(272, 87);
            this.BlueValueLabel.Name = "BlueValueLabel";
            this.BlueValueLabel.Size = new System.Drawing.Size(33, 13);
            this.BlueValueLabel.TabIndex = 13;
            this.BlueValueLabel.Text = "100%";
            // 
            // PresetGroupBox
            // 
            this.PresetGroupBox.Controls.Add(this.PresetValueLabel);
            this.PresetGroupBox.Controls.Add(this.PresetTrackBar);
            this.PresetGroupBox.Controls.Add(this.PresetComboBox);
            this.PresetGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.PresetGroupBox.Location = new System.Drawing.Point(0, 0);
            this.PresetGroupBox.Name = "PresetGroupBox";
            this.PresetGroupBox.Size = new System.Drawing.Size(200, 126);
            this.PresetGroupBox.TabIndex = 24;
            this.PresetGroupBox.TabStop = false;
            this.PresetGroupBox.Text = "Presets";
            // 
            // PresetValueLabel
            // 
            this.PresetValueLabel.AutoSize = true;
            this.PresetValueLabel.Location = new System.Drawing.Point(166, 56);
            this.PresetValueLabel.Name = "PresetValueLabel";
            this.PresetValueLabel.Size = new System.Drawing.Size(28, 13);
            this.PresetValueLabel.TabIndex = 23;
            this.PresetValueLabel.Text = "1.00";
            this.PresetValueLabel.Visible = false;
            // 
            // PresetTrackBar
            // 
            this.PresetTrackBar.Location = new System.Drawing.Point(12, 49);
            this.PresetTrackBar.Name = "PresetTrackBar";
            this.PresetTrackBar.Size = new System.Drawing.Size(148, 45);
            this.PresetTrackBar.TabIndex = 1;
            this.PresetTrackBar.Visible = false;
            this.PresetTrackBar.Scroll += new System.EventHandler(this.PresetTrackBarScroll);
            // 
            // PresetComboBox
            // 
            this.PresetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PresetComboBox.FormattingEnabled = true;
            this.PresetComboBox.Location = new System.Drawing.Point(12, 17);
            this.PresetComboBox.Name = "PresetComboBox";
            this.PresetComboBox.Size = new System.Drawing.Size(182, 21);
            this.PresetComboBox.TabIndex = 0;
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.OriginalPictureBox);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.ModifiedPictureBox);
            this.MainSplitContainer.Size = new System.Drawing.Size(884, 412);
            this.MainSplitContainer.SplitterDistance = 442;
            this.MainSplitContainer.TabIndex = 1;
            // 
            // OriginalPictureBox
            // 
            this.OriginalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OriginalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.OriginalPictureBox.Name = "OriginalPictureBox";
            this.OriginalPictureBox.Size = new System.Drawing.Size(442, 412);
            this.OriginalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalPictureBox.TabIndex = 0;
            this.OriginalPictureBox.TabStop = false;
            // 
            // ModifiedPictureBox
            // 
            this.ModifiedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModifiedPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifiedPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ModifiedPictureBox.Name = "ModifiedPictureBox";
            this.ModifiedPictureBox.Size = new System.Drawing.Size(438, 412);
            this.ModifiedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ModifiedPictureBox.TabIndex = 0;
            this.ModifiedPictureBox.TabStop = false;
            // 
            // MainOpenFileDialog
            // 
            this.MainOpenFileDialog.Filter = resources.GetString("MainOpenFileDialog.Filter");
            // 
            // ImageBoxMenuStrip
            // 
            this.ImageBoxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageBoxToolStripMenuItem});
            this.ImageBoxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ImageBoxMenuStrip.Name = "ImageBoxMenuStrip";
            this.ImageBoxMenuStrip.Size = new System.Drawing.Size(884, 24);
            this.ImageBoxMenuStrip.TabIndex = 2;
            // 
            // imageBoxToolStripMenuItem
            // 
            this.imageBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.MainToolStripSeparator,
            this.exitToolStripMenuItem});
            this.imageBoxToolStripMenuItem.Name = "imageBoxToolStripMenuItem";
            this.imageBoxToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.imageBoxToolStripMenuItem.Text = "&ImageBox";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::ImageBox.UI.Properties.Resources.OpenFile_16x;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::ImageBox.UI.Properties.Resources.ExportFile_16x;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // MainToolStripSeparator
            // 
            this.MainToolStripSeparator.Name = "MainToolStripSeparator";
            this.MainToolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // MainSaveFileDialog
            // 
            this.MainSaveFileDialog.Filter = resources.GetString("MainSaveFileDialog.Filter");
            // 
            // ColoringWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ImageBoxMenuStrip);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "ColoringWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImageBox";
            this.Load += new System.EventHandler(this.ColoringWindowLoad);
            this.MainPanel.ResumeLayout(false);
            this.CustomGroupBox.ResumeLayout(false);
            this.CustomGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).EndInit();
            this.PresetGroupBox.ResumeLayout(false);
            this.PresetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PresetTrackBar)).EndInit();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifiedPictureBox)).EndInit();
            this.ImageBoxMenuStrip.ResumeLayout(false);
            this.ImageBoxMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.PictureBox OriginalPictureBox;
        private System.Windows.Forms.PictureBox ModifiedPictureBox;
        private System.Windows.Forms.OpenFileDialog MainOpenFileDialog;
        private System.Windows.Forms.MenuStrip ImageBoxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem imageBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator MainToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox RedPictureBox;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.PictureBox BluePictureBox;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.PictureBox GreenPictureBox;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.TrackBar GreenTrackBar;
        private System.Windows.Forms.TrackBar BlueTrackBar;
        private System.Windows.Forms.TrackBar RedTrackBar;
        private System.Windows.Forms.Label BlueValueLabel;
        private System.Windows.Forms.Label GreenValueLabel;
        private System.Windows.Forms.Label RedValueLabel;
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.Label SaturationLabel;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.TrackBar BrightnessTrackBar;
        private System.Windows.Forms.TrackBar SaturationTrackBar;
        private System.Windows.Forms.TrackBar ContrastTrackBar;
        private System.Windows.Forms.Label BrightnessValueLabel;
        private System.Windows.Forms.Label SaturationValueLabel;
        private System.Windows.Forms.Label ContrastValueLabel;
        private System.Windows.Forms.GroupBox CustomGroupBox;
        private System.Windows.Forms.GroupBox PresetGroupBox;
        private System.Windows.Forms.ComboBox PresetComboBox;
        private System.Windows.Forms.Label PresetValueLabel;
        private System.Windows.Forms.TrackBar PresetTrackBar;
        private System.Windows.Forms.SaveFileDialog MainSaveFileDialog;
    }
}