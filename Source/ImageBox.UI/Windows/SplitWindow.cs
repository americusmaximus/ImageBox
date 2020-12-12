﻿#region License
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

using ImageBox.Splitting;
using ImageBox.UI.Properties;
using ImageBox.UI.Windows.Split;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Splitter = ImageBox.Splitting.Splitter;

namespace ImageBox.UI.Windows
{
    public partial class SplitWindow : Form
    {
        public SplitWindow()
        {
            InitializeComponent();
        }

        protected virtual Image Image { get; set; }

        protected virtual string ImageFileName { get; set; }

        protected virtual bool IsAutomaticChange { get; set; }

        protected virtual void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected virtual void HeightNumericUpDownValueChanged(object sender, EventArgs e)
        {
            if (IsAutomaticChange) { return; }
            if (OriginalPictureBox.Image == default) { return; }

            VerticalPartsValueLabel.Text = string.Format(" x{0}", Math.Ceiling(HeightNumericUpDown.Maximum / HeightNumericUpDown.Value));
        }

        protected virtual void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (MainOpenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                IsAutomaticChange = true;

                try
                {
                    ImageFileName = MainOpenFileDialog.FileName;
                    Image = Image.FromFile(ImageFileName);

                    OriginalPictureBox.Image = Image;

                    HeightValueLabel.Text = Image.Height.ToString() + " px";
                    WidthValueLabel.Text = Image.Width.ToString() + " px";

                    WidthNumericUpDown.Value = WidthNumericUpDown.Minimum;
                    WidthNumericUpDown.Maximum = Image.Width;
                    WidthNumericUpDown.Value = Image.Width / 2;

                    HeightNumericUpDown.Value = HeightNumericUpDown.Minimum;
                    HeightNumericUpDown.Maximum = Image.Height;
                    HeightNumericUpDown.Value = Image.Height / 2;

                    HorizontalPartsValueLabel.Text = string.Format(" x{0}", 2);
                    VerticalPartsValueLabel.Text = string.Format(" x{0}", 2);

                    HeightNumericUpDown.Enabled = true;
                    WidthNumericUpDown.Enabled = true;

                    ImageFormatComboBox.Enabled = true;
                    SplitButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    ImageFileName = string.Empty;
                    Image = default;

                    HeightValueLabel.Text = string.Empty;
                    WidthValueLabel.Text = string.Empty;

                    HeightNumericUpDown.Enabled = false;
                    WidthNumericUpDown.Enabled = false;

                    ImageFormatComboBox.Enabled = false;
                    SplitButton.Enabled = false;

                    MessageBox.Show(this, ex.ToString(), "ImageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                IsAutomaticChange = false;
            }
        }

        protected virtual void SplitButtonClick(object sender, EventArgs e)
        {
            if (MainFolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    var result = new Splitter(Image).Split(new SplitterRequest()
                    {
                        Type = SplitUnitType.Pixel,
                        Horizontal = (int)WidthNumericUpDown.Value,
                        Vertical = (int)HeightNumericUpDown.Value
                    });

                    var originalFileName = Path.GetFileNameWithoutExtension(ImageFileName);
                    var extension = ImageFormatComboBox.SelectedItem as ImageFormatComboBoxItem;

                    for (var x = 0; x < result.Length; x++)
                    {
                        var line = result[x];

                        for (var y = 0; y < line.Length; y++)
                        {
                            var fileName = Path.Combine(MainFolderBrowserDialog.SelectedPath, string.Format("{0}.{1:D4}.{2:D4}.{3}", originalFileName, x, y, extension.Name.ToLowerInvariant()));

                            line[y].Image.Save(fileName, extension.Format);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.ToString(), "ImageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected virtual void SplitWindowLoad(object sender, EventArgs e)
        {
            Icon = Resources.Icon;

            ImageFormatComboBox.Items.Add(new ImageFormatComboBoxItem() { Name = "BMP", Format = ImageFormat.Bmp });
            ImageFormatComboBox.Items.Add(new ImageFormatComboBoxItem() { Name = "EMF", Format = ImageFormat.Emf });
            ImageFormatComboBox.Items.Add(new ImageFormatComboBoxItem() { Name = "EXIF", Format = ImageFormat.Exif });
            ImageFormatComboBox.Items.Add(new ImageFormatComboBoxItem() { Name = "GIF", Format = ImageFormat.Gif });
            ImageFormatComboBox.Items.Add(new ImageFormatComboBoxItem() { Name = "JPG", Format = ImageFormat.Jpeg });
            ImageFormatComboBox.Items.Add(new ImageFormatComboBoxItem() { Name = "PNG", Format = ImageFormat.Png });
            ImageFormatComboBox.Items.Add(new ImageFormatComboBoxItem() { Name = "TIF", Format = ImageFormat.Tiff });
            ImageFormatComboBox.Items.Add(new ImageFormatComboBoxItem() { Name = "ICO", Format = ImageFormat.Icon });

            ImageFormatComboBox.SelectedIndex = 0;
        }

        protected virtual void WidthNumericUpDownValueChanged(object sender, EventArgs e)
        {
            if (IsAutomaticChange) { return; }
            if (OriginalPictureBox.Image == default) { return; }

            HorizontalPartsValueLabel.Text = string.Format(" x{0}", Math.Ceiling(WidthNumericUpDown.Maximum / WidthNumericUpDown.Value));
        }
    }
}