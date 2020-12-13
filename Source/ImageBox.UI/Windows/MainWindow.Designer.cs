
namespace ImageBox.UI.Windows
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImageBoxMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ImageBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VisitWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportAnIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparatorOne = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImageBoxMainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageBoxMainMenuStrip
            // 
            this.ImageBoxMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImageBoxToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.ImageBoxMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ImageBoxMainMenuStrip.Name = "ImageBoxMainMenuStrip";
            this.ImageBoxMainMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.ImageBoxMainMenuStrip.TabIndex = 0;
            this.ImageBoxMainMenuStrip.Text = "menuStrip1";
            // 
            // ImageBoxToolStripMenuItem
            // 
            this.ImageBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.ImageBoxToolStripMenuItem.Name = "ImageBoxToolStripMenuItem";
            this.ImageBoxToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ImageBoxToolStripMenuItem.Text = "&ImageBox";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisitWebsiteToolStripMenuItem,
            this.ReportAnIssueToolStripMenuItem,
            this.ToolStripSeparatorOne,
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // VisitWebsiteToolStripMenuItem
            // 
            this.VisitWebsiteToolStripMenuItem.Image = global::ImageBox.UI.Properties.Resources.Web_16x;
            this.VisitWebsiteToolStripMenuItem.Name = "VisitWebsiteToolStripMenuItem";
            this.VisitWebsiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.VisitWebsiteToolStripMenuItem.Text = "Visit &Website";
            this.VisitWebsiteToolStripMenuItem.Click += new System.EventHandler(this.VisitWebsiteToolStripMenuItemClick);
            // 
            // ReportAnIssueToolStripMenuItem
            // 
            this.ReportAnIssueToolStripMenuItem.Image = global::ImageBox.UI.Properties.Resources.Bug_16x;
            this.ReportAnIssueToolStripMenuItem.Name = "ReportAnIssueToolStripMenuItem";
            this.ReportAnIssueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ReportAnIssueToolStripMenuItem.Text = "Report an &Issue";
            this.ReportAnIssueToolStripMenuItem.Click += new System.EventHandler(this.ReportAnIssueToolStripMenuItemClick);
            // 
            // ToolStripSeparatorOne
            // 
            this.ToolStripSeparatorOne.Name = "ToolStripSeparatorOne";
            this.ToolStripSeparatorOne.Size = new System.Drawing.Size(177, 6);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Image = global::ImageBox.UI.Properties.Resources.Favorite_16x;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutToolStripMenuItem.Text = "&About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(784, 538);
            this.MainTableLayoutPanel.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Controls.Add(this.ImageBoxMainMenuStrip);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageBox";
            this.Load += new System.EventHandler(this.MainWindowLoad);
            this.ImageBoxMainMenuStrip.ResumeLayout(false);
            this.ImageBoxMainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ImageBoxMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ImageBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VisitWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportAnIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparatorOne;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
    }
}

