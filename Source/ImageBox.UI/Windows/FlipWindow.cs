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

using ImageBox.Flipping;
using ImageBox.UI.Controls;
using ImageBox.UI.Properties;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ImageBox.UI.Windows
{
    public partial class FlipWindow : Form
    {
        public FlipWindow()
        {
            InitializeComponent();
        }

        protected virtual void ApplyChanges()
        {
            if (OriginalPictureBox.Image == default) { return; }

            ModifiedPictureBox.Image?.Dispose();

            ModifiedPictureBox.Image = new Flipper(OriginalPictureBox.Image).Flip((FlipTypeComboBox.SelectedItem as FlipComboBoxItem).Type);
        }

        protected virtual void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected virtual void FlipTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyChanges();
        }

        protected virtual void FlipWindowDragDrop(object sender, DragEventArgs e)
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

        protected virtual void FlipWindowDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        protected virtual void FlipWindowLoad(object sender, EventArgs e)
        {
            Icon = Resources.Icon;

            FlipTypeComboBox.Items.AddRange(new[]
            {
                new FlipComboBoxItem(){Name = "None", Type = FlipType.None },
                new FlipComboBoxItem(){Name = "Horizontal", Type = FlipType.Horizontal },
                new FlipComboBoxItem(){Name = "Vertical", Type = FlipType.Vertical },
                new FlipComboBoxItem(){Name = "Both", Type = FlipType.Both }
            });

            FlipTypeComboBox.SelectedIndex = 0;
        }

        protected virtual void MainSplitContainerOriginalSizeChanged(object sender, EventArgs e)
        {
            DragDropLabel.Location = new Point(MainSplitContainer.Panel1.Width / 2 - DragDropLabel.Width / 2, MainSplitContainer.Panel1.Height / 2 - DragDropLabel.Height / 2);
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

        protected virtual void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (ModifiedPictureBox.Image == default) { return; }

            if (MainSaveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                var extension = Path.GetExtension(MainSaveFileDialog.FileName).ToLowerInvariant().Replace(".", string.Empty);

                if (!TryParseImageFormat(extension, out var imageFormatValue))
                {
                    MessageBox.Show(this, string.Format("Image extension <{0}> is not supported. Saving image as a BMP.", extension), "ImageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                var outputFileName = imageFormatValue != default ? MainSaveFileDialog.FileName : (MainSaveFileDialog.FileName + ".bmp");

                try
                {
                    ModifiedPictureBox.Image.Save(outputFileName, imageFormatValue ?? ImageFormat.Bmp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.ToString(), "ImageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected virtual bool TryParseImageFormat(string format, out ImageFormat imageFormat)
        {
            var extension = format.ToLowerInvariant().Replace("ico", "icon").Replace("jpg", "jpeg").Replace("tif", "tiff");

            var imageFormatProperty = typeof(ImageFormat).GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.GetProperty)
                                                            .FirstOrDefault(p => p.Name.ToLowerInvariant() == extension);

            imageFormat = imageFormatProperty == default ? default : (ImageFormat)imageFormatProperty.GetValue(default, default);

            return imageFormat != default;
        }
    }
}
