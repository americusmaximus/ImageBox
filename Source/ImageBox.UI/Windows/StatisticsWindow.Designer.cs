
namespace ImageBox.UI.Windows
{
    partial class StatisticsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsWindow));
            this.ImageBoxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.imageBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.OriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.MainSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ImageBoxMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).BeginInit();
            this.MainToolStrip.SuspendLayout();
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
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.MainTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.MainToolStrip);
            this.MainSplitContainer.Size = new System.Drawing.Size(784, 538);
            this.MainSplitContainer.SplitterDistance = 307;
            this.MainSplitContainer.TabIndex = 1;
            // 
            // OriginalPictureBox
            // 
            this.OriginalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OriginalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.OriginalPictureBox.Name = "OriginalPictureBox";
            this.OriginalPictureBox.Size = new System.Drawing.Size(307, 538);
            this.OriginalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalPictureBox.TabIndex = 0;
            this.OriginalPictureBox.TabStop = false;
            // 
            // MainTextBox
            // 
            this.MainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTextBox.Location = new System.Drawing.Point(0, 25);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ReadOnly = true;
            this.MainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainTextBox.Size = new System.Drawing.Size(473, 513);
            this.MainTextBox.TabIndex = 0;
            this.MainTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainTextBoxKeyUp);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(473, 25);
            this.MainToolStrip.TabIndex = 1;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ImageBox.UI.Properties.Resources.Save_16x;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MainSaveFileDialog
            // 
            this.MainSaveFileDialog.Filter = "Text|*.txt";
            // 
            // StatisticsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.ImageBoxMenuStrip);
            this.MainMenuStrip = this.ImageBoxMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "StatisticsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImageBox";
            this.Load += new System.EventHandler(this.StatisticsWindowLoad);
            this.ImageBoxMenuStrip.ResumeLayout(false);
            this.ImageBoxMenuStrip.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).EndInit();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
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
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.PictureBox OriginalPictureBox;
        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SaveFileDialog MainSaveFileDialog;
    }
}