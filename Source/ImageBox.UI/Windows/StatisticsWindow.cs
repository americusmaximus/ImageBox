#region License
/*
MIT License

Copyright (c) 2020 Americus Maximus

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

using ImageBox.Statistics;
using ImageBox.UI.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ImageBox.UI.Windows
{
    public partial class StatisticsWindow : Form
    {
        public StatisticsWindow()
        {
            InitializeComponent();
        }

        protected void ApplyChanges()
        {
            var result = new Stats(OriginalPictureBox.Image).Count();

            var sb = new StringBuilder(result.Counts.Length * 48);

            sb.AppendLine(string.Format("Brightest: R: {0,3}. G: {1,3}, B: {2,3}, A: {3,3}", result.Brightest.R, result.Brightest.G, result.Brightest.B, result.Brightest.A));
            sb.AppendLine(string.Format("Darkest:   R: {0,3}. G: {1,3}, B: {2,3}, A: {3,3}", result.Darkest.R, result.Darkest.G, result.Darkest.B, result.Darkest.A));

            sb.AppendLine();

            for (var x = 0; x < result.Counts.Length; x++)
            {
                var count = result.Counts[x];
                sb.AppendLine(string.Format("Count: {0,12}: Color:  R: {1,3}. G: {2,3}, B: {3,3}, A: {4,3}", count.Count, count.Color.R, count.Color.G, count.Color.B, count.Color.A));
            }

            MainTextBox.Text = sb.ToString();
        }

        protected virtual void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected virtual void MainSplitContainerOriginalSizeChanged(object sender, EventArgs e)
        {
            DragDropLabel.Location = new Point(MainSplitContainer.Panel1.Width / 2 - DragDropLabel.Width / 2, MainSplitContainer.Panel1.Height / 2 - DragDropLabel.Height / 2);
        }

        protected virtual void MainTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                MainTextBox.SelectAll();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(MainTextBox.SelectedText);
            }
        }

        protected virtual void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (MainOpenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    OriginalPictureBox.Image = Image.FromFile(MainOpenFileDialog.FileName);

                    DragDropLabel.Visible = false;
                    MainToolStripStatusLabel.Text = string.Format("File: {0} @ {1}x{2}", MainOpenFileDialog.FileName, OriginalPictureBox.Image.Width, OriginalPictureBox.Image.Height);

                    ApplyChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.ToString(), "ImageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected virtual void SaveToolStripButtonClick(object sender, EventArgs e)
        {
            if (MainSaveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(MainSaveFileDialog.FileName, MainTextBox.Text, Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.ToString(), "ImageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected virtual void StatisticsWindowDragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files != default && files.Length != 0)
            {
                try
                {
                    OriginalPictureBox.Image = Image.FromFile(files[0]);

                    DragDropLabel.Visible = false;
                    MainToolStripStatusLabel.Text = string.Format("File: {0} @ {1}x{2}", files[0], OriginalPictureBox.Image.Width, OriginalPictureBox.Image.Height);

                    ApplyChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.ToString(), "ImageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected virtual void StatisticsWindowDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        protected virtual void StatisticsWindowLoad(object sender, EventArgs e)
        {
            Icon = Resources.Icon;
        }
    }
}
