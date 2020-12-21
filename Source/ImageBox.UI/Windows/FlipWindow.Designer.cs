
namespace ImageBox.UI.Windows
{
    partial class FlipWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlipWindow));
            this.ImageBoxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ImageBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainColorDialog = new System.Windows.Forms.ColorDialog();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.FlipTypeComboBox = new System.Windows.Forms.ComboBox();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.DragDropLabel = new System.Windows.Forms.Label();
            this.OriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.ModifiedPictureBox = new System.Windows.Forms.PictureBox();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ImageBoxMenuStrip.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifiedPictureBox)).BeginInit();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageBoxMenuStrip
            // 
            this.ImageBoxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImageBoxToolStripMenuItem});
            this.ImageBoxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ImageBoxMenuStrip.Name = "ImageBoxMenuStrip";
            this.ImageBoxMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.ImageBoxMenuStrip.TabIndex = 0;
            // 
            // ImageBoxToolStripMenuItem
            // 
            this.ImageBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.MainToolStripSeparator,
            this.ExitToolStripMenuItem});
            this.ImageBoxToolStripMenuItem.Name = "ImageBoxToolStripMenuItem";
            this.ImageBoxToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ImageBoxToolStripMenuItem.Text = "ImageBox";
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
            this.SettingsGroupBox.Controls.Add(this.FlipTypeComboBox);
            this.SettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsGroupBox.Location = new System.Drawing.Point(0, 24);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(784, 52);
            this.SettingsGroupBox.TabIndex = 1;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // FlipTypeComboBox
            // 
            this.FlipTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlipTypeComboBox.FormattingEnabled = true;
            this.FlipTypeComboBox.Location = new System.Drawing.Point(12, 19);
            this.FlipTypeComboBox.Name = "FlipTypeComboBox";
            this.FlipTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.FlipTypeComboBox.TabIndex = 0;
            this.FlipTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FlipTypeComboBoxSelectedIndexChanged);
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 76);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.DragDropLabel);
            this.MainSplitContainer.Panel1.Controls.Add(this.OriginalPictureBox);
            this.MainSplitContainer.Panel1.SizeChanged += new System.EventHandler(this.MainSplitContainerOriginalSizeChanged);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.ModifiedPictureBox);
            this.MainSplitContainer.Size = new System.Drawing.Size(784, 464);
            this.MainSplitContainer.SplitterDistance = 392;
            this.MainSplitContainer.TabIndex = 2;
            // 
            // DragDropLabel
            // 
            this.DragDropLabel.AutoSize = true;
            this.DragDropLabel.Location = new System.Drawing.Point(102, 236);
            this.DragDropLabel.Name = "DragDropLabel";
            this.DragDropLabel.Size = new System.Drawing.Size(187, 13);
            this.DragDropLabel.TabIndex = 2;
            this.DragDropLabel.Text = "Open an image or Drag && Drop it here.";
            // 
            // OriginalPictureBox
            // 
            this.OriginalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OriginalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.OriginalPictureBox.Name = "OriginalPictureBox";
            this.OriginalPictureBox.Size = new System.Drawing.Size(392, 464);
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
            this.ModifiedPictureBox.Size = new System.Drawing.Size(388, 464);
            this.ModifiedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ModifiedPictureBox.TabIndex = 0;
            this.ModifiedPictureBox.TabStop = false;
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 540);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(784, 22);
            this.MainStatusStrip.TabIndex = 3;
            // 
            // MainToolStripStatusLabel
            // 
            this.MainToolStripStatusLabel.Name = "MainToolStripStatusLabel";
            this.MainToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // FlipWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.ImageBoxMenuStrip);
            this.MainMenuStrip = this.ImageBoxMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FlipWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImageBox";
            this.Load += new System.EventHandler(this.FlipWindowLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlipWindowDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlipWindowDragEnter);
            this.ImageBoxMenuStrip.ResumeLayout(false);
            this.ImageBoxMenuStrip.PerformLayout();
            this.SettingsGroupBox.ResumeLayout(false);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel1.PerformLayout();
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifiedPictureBox)).EndInit();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ImageBoxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ImageBoxToolStripMenuItem;
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
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MainToolStripStatusLabel;
        private System.Windows.Forms.Label DragDropLabel;
        private System.Windows.Forms.ComboBox FlipTypeComboBox;
    }
}