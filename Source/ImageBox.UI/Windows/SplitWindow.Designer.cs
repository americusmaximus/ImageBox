
namespace ImageBox.UI.Windows
{
    partial class SplitWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitWindow));
            this.ImageBoxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.imageBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.OriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.PartitioningGroupBox = new System.Windows.Forms.GroupBox();
            this.SplitButton = new System.Windows.Forms.Button();
            this.VerticalPartsValueLabel = new System.Windows.Forms.Label();
            this.HorizontalPartsValueLabel = new System.Windows.Forms.Label();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PartitioningHeightLabel = new System.Windows.Forms.Label();
            this.PartitioningWidthLabel = new System.Windows.Forms.Label();
            this.DimensionsGroupBox = new System.Windows.Forms.GroupBox();
            this.HeightValueLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthValueLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.ImageFormatComboBox = new System.Windows.Forms.ComboBox();
            this.ImageBoxMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).BeginInit();
            this.PartitioningGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).BeginInit();
            this.DimensionsGroupBox.SuspendLayout();
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
            this.MainToolStripSeparator,
            this.ExitToolStripMenuItem});
            this.imageBoxToolStripMenuItem.Name = "imageBoxToolStripMenuItem";
            this.imageBoxToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.imageBoxToolStripMenuItem.Text = "&ImageBox";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = global::ImageBox.UI.Properties.Resources.OpenFile_16x;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
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
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.OriginalPictureBox);
            this.MainSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.PartitioningGroupBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.DimensionsGroupBox);
            this.MainSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainSplitContainer.Size = new System.Drawing.Size(784, 538);
            this.MainSplitContainer.SplitterDistance = 261;
            this.MainSplitContainer.TabIndex = 1;
            // 
            // OriginalPictureBox
            // 
            this.OriginalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OriginalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.OriginalPictureBox.Name = "OriginalPictureBox";
            this.OriginalPictureBox.Size = new System.Drawing.Size(261, 538);
            this.OriginalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalPictureBox.TabIndex = 0;
            this.OriginalPictureBox.TabStop = false;
            // 
            // PartitioningGroupBox
            // 
            this.PartitioningGroupBox.Controls.Add(this.ImageFormatComboBox);
            this.PartitioningGroupBox.Controls.Add(this.SplitButton);
            this.PartitioningGroupBox.Controls.Add(this.VerticalPartsValueLabel);
            this.PartitioningGroupBox.Controls.Add(this.HorizontalPartsValueLabel);
            this.PartitioningGroupBox.Controls.Add(this.HeightNumericUpDown);
            this.PartitioningGroupBox.Controls.Add(this.WidthNumericUpDown);
            this.PartitioningGroupBox.Controls.Add(this.PartitioningHeightLabel);
            this.PartitioningGroupBox.Controls.Add(this.PartitioningWidthLabel);
            this.PartitioningGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartitioningGroupBox.Location = new System.Drawing.Point(0, 80);
            this.PartitioningGroupBox.Name = "PartitioningGroupBox";
            this.PartitioningGroupBox.Size = new System.Drawing.Size(519, 458);
            this.PartitioningGroupBox.TabIndex = 1;
            this.PartitioningGroupBox.TabStop = false;
            this.PartitioningGroupBox.Text = "Partitioning";
            // 
            // SplitButton
            // 
            this.SplitButton.Enabled = false;
            this.SplitButton.Location = new System.Drawing.Point(381, 42);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(126, 23);
            this.SplitButton.TabIndex = 6;
            this.SplitButton.Text = "Split!";
            this.SplitButton.UseVisualStyleBackColor = true;
            this.SplitButton.Click += new System.EventHandler(this.SplitButtonClick);
            // 
            // VerticalPartsValueLabel
            // 
            this.VerticalPartsValueLabel.AutoSize = true;
            this.VerticalPartsValueLabel.Location = new System.Drawing.Point(152, 47);
            this.VerticalPartsValueLabel.Name = "VerticalPartsValueLabel";
            this.VerticalPartsValueLabel.Size = new System.Drawing.Size(0, 13);
            this.VerticalPartsValueLabel.TabIndex = 5;
            // 
            // HorizontalPartsValueLabel
            // 
            this.HorizontalPartsValueLabel.AutoSize = true;
            this.HorizontalPartsValueLabel.Location = new System.Drawing.Point(152, 21);
            this.HorizontalPartsValueLabel.Name = "HorizontalPartsValueLabel";
            this.HorizontalPartsValueLabel.Size = new System.Drawing.Size(0, 13);
            this.HorizontalPartsValueLabel.TabIndex = 4;
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Enabled = false;
            this.HeightNumericUpDown.Location = new System.Drawing.Point(56, 45);
            this.HeightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightNumericUpDown.Name = "HeightNumericUpDown";
            this.HeightNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.HeightNumericUpDown.TabIndex = 3;
            this.HeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightNumericUpDown.ValueChanged += new System.EventHandler(this.HeightNumericUpDownValueChanged);
            // 
            // WidthNumericUpDown
            // 
            this.WidthNumericUpDown.Enabled = false;
            this.WidthNumericUpDown.Location = new System.Drawing.Point(56, 19);
            this.WidthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNumericUpDown.Name = "WidthNumericUpDown";
            this.WidthNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.WidthNumericUpDown.TabIndex = 2;
            this.WidthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNumericUpDown.ValueChanged += new System.EventHandler(this.WidthNumericUpDownValueChanged);
            // 
            // PartitioningHeightLabel
            // 
            this.PartitioningHeightLabel.AutoSize = true;
            this.PartitioningHeightLabel.Location = new System.Drawing.Point(6, 47);
            this.PartitioningHeightLabel.Name = "PartitioningHeightLabel";
            this.PartitioningHeightLabel.Size = new System.Drawing.Size(38, 13);
            this.PartitioningHeightLabel.TabIndex = 1;
            this.PartitioningHeightLabel.Text = "Height";
            // 
            // PartitioningWidthLabel
            // 
            this.PartitioningWidthLabel.AutoSize = true;
            this.PartitioningWidthLabel.Location = new System.Drawing.Point(6, 21);
            this.PartitioningWidthLabel.Name = "PartitioningWidthLabel";
            this.PartitioningWidthLabel.Size = new System.Drawing.Size(35, 13);
            this.PartitioningWidthLabel.TabIndex = 0;
            this.PartitioningWidthLabel.Text = "Width";
            // 
            // DimensionsGroupBox
            // 
            this.DimensionsGroupBox.Controls.Add(this.HeightValueLabel);
            this.DimensionsGroupBox.Controls.Add(this.HeightLabel);
            this.DimensionsGroupBox.Controls.Add(this.WidthValueLabel);
            this.DimensionsGroupBox.Controls.Add(this.WidthLabel);
            this.DimensionsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DimensionsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.DimensionsGroupBox.Name = "DimensionsGroupBox";
            this.DimensionsGroupBox.Size = new System.Drawing.Size(519, 80);
            this.DimensionsGroupBox.TabIndex = 0;
            this.DimensionsGroupBox.TabStop = false;
            this.DimensionsGroupBox.Text = "Dimensions";
            // 
            // HeightValueLabel
            // 
            this.HeightValueLabel.AutoSize = true;
            this.HeightValueLabel.Location = new System.Drawing.Point(53, 53);
            this.HeightValueLabel.Name = "HeightValueLabel";
            this.HeightValueLabel.Size = new System.Drawing.Size(0, 13);
            this.HeightValueLabel.TabIndex = 3;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(6, 53);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "Height:";
            // 
            // WidthValueLabel
            // 
            this.WidthValueLabel.AutoSize = true;
            this.WidthValueLabel.Location = new System.Drawing.Point(53, 27);
            this.WidthValueLabel.Name = "WidthValueLabel";
            this.WidthValueLabel.Size = new System.Drawing.Size(0, 13);
            this.WidthValueLabel.TabIndex = 1;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(6, 27);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 0;
            this.WidthLabel.Text = "Width:";
            // 
            // ImageFormatComboBox
            // 
            this.ImageFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImageFormatComboBox.Enabled = false;
            this.ImageFormatComboBox.FormattingEnabled = true;
            this.ImageFormatComboBox.Location = new System.Drawing.Point(381, 18);
            this.ImageFormatComboBox.Name = "ImageFormatComboBox";
            this.ImageFormatComboBox.Size = new System.Drawing.Size(126, 21);
            this.ImageFormatComboBox.TabIndex = 7;
            // 
            // SplitWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.ImageBoxMenuStrip);
            this.MainMenuStrip = this.ImageBoxMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SplitWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImageBox";
            this.Load += new System.EventHandler(this.SplitWindowLoad);
            this.ImageBoxMenuStrip.ResumeLayout(false);
            this.ImageBoxMenuStrip.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).EndInit();
            this.PartitioningGroupBox.ResumeLayout(false);
            this.PartitioningGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).EndInit();
            this.DimensionsGroupBox.ResumeLayout(false);
            this.DimensionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ImageBoxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem imageBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator MainToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog MainOpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog MainFolderBrowserDialog;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.PictureBox OriginalPictureBox;
        private System.Windows.Forms.GroupBox PartitioningGroupBox;
        private System.Windows.Forms.GroupBox DimensionsGroupBox;
        private System.Windows.Forms.Label HeightValueLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthValueLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.NumericUpDown WidthNumericUpDown;
        private System.Windows.Forms.Label PartitioningHeightLabel;
        private System.Windows.Forms.Label PartitioningWidthLabel;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown;
        private System.Windows.Forms.Label VerticalPartsValueLabel;
        private System.Windows.Forms.Label HorizontalPartsValueLabel;
        private System.Windows.Forms.Button SplitButton;
        private System.Windows.Forms.ComboBox ImageFormatComboBox;
    }
}