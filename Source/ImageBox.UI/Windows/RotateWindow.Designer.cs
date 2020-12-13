
namespace ImageBox.UI.Windows
{
    partial class RotateWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RotateWindow));
            this.ImageBoxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.imageBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainColorDialog = new System.Windows.Forms.ColorDialog();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.AngleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColorPictureBox = new System.Windows.Forms.PictureBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.AngleLabel = new System.Windows.Forms.Label();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.OriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.ModifiedPictureBox = new System.Windows.Forms.PictureBox();
            this.ImageBoxMenuStrip.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AngleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifiedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBoxMenuStrip
            // 
            this.ImageBoxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageBoxToolStripMenuItem});
            this.ImageBoxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ImageBoxMenuStrip.Name = "ImageBoxMenuStrip";
            this.ImageBoxMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.ImageBoxMenuStrip.TabIndex = 0;
            // 
            // imageBoxToolStripMenuItem
            // 
            this.imageBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.MainToolStripSeparator,
            this.ExitToolStripMenuItem});
            this.imageBoxToolStripMenuItem.Name = "imageBoxToolStripMenuItem";
            this.imageBoxToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.imageBoxToolStripMenuItem.Text = "ImageBox";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = global::ImageBox.UI.Properties.Resources.OpenFile_16x;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = global::ImageBox.UI.Properties.Resources.ExportFile_16x;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // MainToolStripSeparator
            // 
            this.MainToolStripSeparator.Name = "MainToolStripSeparator";
            this.MainToolStripSeparator.Size = new System.Drawing.Size(100, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // MainOpenFileDialog
            // 
            this.MainOpenFileDialog.Filter = resources.GetString("MainOpenFileDialog.Filter");
            // 
            // MainSaveFileDialog
            // 
            this.MainSaveFileDialog.Filter = resources.GetString("MainSaveFileDialog.Filter");
            // 
            // MainColorDialog
            // 
            this.MainColorDialog.Color = System.Drawing.Color.Transparent;
            this.MainColorDialog.FullOpen = true;
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.AngleNumericUpDown);
            this.SettingsGroupBox.Controls.Add(this.ColorPictureBox);
            this.SettingsGroupBox.Controls.Add(this.ColorLabel);
            this.SettingsGroupBox.Controls.Add(this.AngleLabel);
            this.SettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsGroupBox.Location = new System.Drawing.Point(0, 24);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(784, 52);
            this.SettingsGroupBox.TabIndex = 1;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // AngleNumericUpDown
            // 
            this.AngleNumericUpDown.DecimalPlaces = 2;
            this.AngleNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AngleNumericUpDown.Location = new System.Drawing.Point(52, 24);
            this.AngleNumericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.AngleNumericUpDown.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.AngleNumericUpDown.Name = "AngleNumericUpDown";
            this.AngleNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.AngleNumericUpDown.TabIndex = 3;
            this.AngleNumericUpDown.ValueChanged += new System.EventHandler(this.AngleNumericUpDownValueChanged);
            // 
            // ColorPictureBox
            // 
            this.ColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPictureBox.Location = new System.Drawing.Point(158, 19);
            this.ColorPictureBox.Name = "ColorPictureBox";
            this.ColorPictureBox.Size = new System.Drawing.Size(25, 25);
            this.ColorPictureBox.TabIndex = 2;
            this.ColorPictureBox.TabStop = false;
            this.ColorPictureBox.Click += new System.EventHandler(this.ColorPictureBoxClick);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(121, 26);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(31, 13);
            this.ColorLabel.TabIndex = 1;
            this.ColorLabel.Text = "Color";
            // 
            // AngleLabel
            // 
            this.AngleLabel.AutoSize = true;
            this.AngleLabel.Location = new System.Drawing.Point(12, 26);
            this.AngleLabel.Name = "AngleLabel";
            this.AngleLabel.Size = new System.Drawing.Size(34, 13);
            this.AngleLabel.TabIndex = 0;
            this.AngleLabel.Text = "Angle";
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 76);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.OriginalPictureBox);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.ModifiedPictureBox);
            this.MainSplitContainer.Size = new System.Drawing.Size(784, 486);
            this.MainSplitContainer.SplitterDistance = 392;
            this.MainSplitContainer.TabIndex = 2;
            // 
            // OriginalPictureBox
            // 
            this.OriginalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OriginalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.OriginalPictureBox.Name = "OriginalPictureBox";
            this.OriginalPictureBox.Size = new System.Drawing.Size(392, 486);
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
            this.ModifiedPictureBox.Size = new System.Drawing.Size(388, 486);
            this.ModifiedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ModifiedPictureBox.TabIndex = 0;
            this.ModifiedPictureBox.TabStop = false;
            // 
            // RotateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.ImageBoxMenuStrip);
            this.MainMenuStrip = this.ImageBoxMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "RotateWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImageBox";
            this.Load += new System.EventHandler(this.RotateWindowLoad);
            this.ImageBoxMenuStrip.ResumeLayout(false);
            this.ImageBoxMenuStrip.PerformLayout();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AngleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).EndInit();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifiedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ImageBoxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem imageBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator MainToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog MainOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog MainSaveFileDialog;
        private System.Windows.Forms.ColorDialog MainColorDialog;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.PictureBox OriginalPictureBox;
        private System.Windows.Forms.PictureBox ModifiedPictureBox;
        private System.Windows.Forms.NumericUpDown AngleNumericUpDown;
        private System.Windows.Forms.PictureBox ColorPictureBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label AngleLabel;
    }
}