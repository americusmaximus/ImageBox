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

using ImageBox.Coloring;
using ImageBox.UI.Properties;
using ImageBox.UI.Windows.Main;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ImageBox.UI.Windows
{
    public partial class ColorWindow : Form
    {
        public ColorWindow()
        {
            InitializeComponent();
        }

        protected virtual bool IsAutomaticChange { get; set; }

        protected static bool TryParseImageFormat(string format, out ImageFormat imageFormat)
        {
            var extension = format.ToLowerInvariant().Replace("ico", "icon").Replace("jpg", "jpeg").Replace("tif", "tiff");

            var imageFormatProperty = typeof(ImageFormat).GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.GetProperty)
                                                            .FirstOrDefault(p => p.Name.ToLowerInvariant() == extension);

            imageFormat = imageFormatProperty == default ? default : (ImageFormat)imageFormatProperty.GetValue(default, default);

            return imageFormat != default;
        }

        protected virtual void ApplyChanges()
        {
            if (OriginalPictureBox.Image == default) { return; }

            if (ModifiedPictureBox.Image != default)
            {
                var img = ModifiedPictureBox.Image;
                ModifiedPictureBox.Image = default;
                img.Dispose();
            }

            var preset = PresetComboBox.SelectedItem as ColorerMatrixTypeComboBoxItem;

            if (preset == default) { return; }

            var isCustom = !preset.Type.HasValue;

            if (!isCustom)
            {
                if (preset.Descriptor.IsValueRequired)
                {
                    preset.Descriptor.Value = (float)PresetTrackBar.Value / 100;
                }

                ModifiedPictureBox.Image = new Colorer(OriginalPictureBox.Image).Color(preset.Descriptor.Matrix);
            }
            else
            {
                var r = ((float)RedTrackBar.Value / 100) * ((float)ContrastTrackBar.Value / 100);
                var g = ((float)GreenTrackBar.Value / 100) * ((float)ContrastTrackBar.Value / 100);
                var b = ((float)BlueTrackBar.Value / 100) * ((float)ContrastTrackBar.Value / 100);

                var sr = (r - ((float)SaturationTrackBar.Value / 100)) * 0.3086f; // lumR = 0.3086  or  0.2125
                var sg = (g - ((float)SaturationTrackBar.Value / 100)) * 0.6094f; // lumG = 0.6094  or  0.7154
                var sb = (b - ((float)SaturationTrackBar.Value / 100)) * 0.0820f; // lumB = 0.0820  or  0.0721

                var rr = sr + ((float)SaturationTrackBar.Value / 100);
                var rg = sg + ((float)SaturationTrackBar.Value / 100);
                var rb = sb + ((float)SaturationTrackBar.Value / 100);

                var brightness = ((float)BrightnessTrackBar.Value / 100) + 0.5f * (1f - ((float)ContrastTrackBar.Value / 100));

                var matrix = new float[][]
                   {
                     new float[] { rr, sr, sr, 0, 0 },
                     new float[] { sg, rg, sg, 0, 0 },
                     new float[] { sb, sb, rb, 0, 0 },
                     new float[] { 0, 0, 0, 1, 0 },
                     new float[] { brightness, brightness, brightness, 0, 1 }
                   };

                ModifiedPictureBox.Image = new Colorer(OriginalPictureBox.Image).Color(new ColorMatrix(matrix));
            }
        }

        protected virtual void BlueTrackBarScroll(object sender, EventArgs e)
        {
            BlueValueLabel.Text = BlueTrackBar.Value.ToString() + "%";

            ApplyChanges();
        }

        protected virtual void BrightnessTrackBarScroll(object sender, EventArgs e)
        {
            BrightnessValueLabel.Text = ((float)BrightnessTrackBar.Value / 100).ToString("F");

            ApplyChanges();
        }

        protected virtual void ColoringWindowLoad(object sender, EventArgs e)
        {
            Icon = Resources.Icon;

            var items = new List<ColorerMatrixTypeComboBoxItem>()
            {
                new ColorerMatrixTypeComboBoxItem() { Name = "Custom" }
            };

            foreach (var type in Enum.GetValues(typeof(ColorerMatrixType)).OfType<ColorerMatrixType>())
            {
                items.Add(new ColorerMatrixTypeComboBoxItem()
                {
                    Type = type,
                    Name = type.ToString(),
                    Descriptor = ColorerMatrix.Get(type)
                });
            }

            PresetComboBox.Items.AddRange(items.ToArray());
            PresetComboBox.SelectedIndex = 0;

            PresetComboBox.SelectedValueChanged += PresetComboBoxSelectedValueChanged;
        }

        protected virtual void ContrastTrackBarScroll(object sender, EventArgs e)
        {
            ContrastValueLabel.Text = ((float)ContrastTrackBar.Value / 100).ToString("F");

            ApplyChanges();
        }

        protected virtual void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected virtual void GreenTrackBarScroll(object sender, EventArgs e)
        {
            GreenValueLabel.Text = GreenTrackBar.Value.ToString() + "%";

            ApplyChanges();
        }

        protected virtual void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (MainOpenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    OriginalPictureBox.Image = Image.FromFile(MainOpenFileDialog.FileName);

                    ApplyChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.ToString(), "ImageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected virtual void PresetComboBoxSelectedValueChanged(object sender, EventArgs e)
        {
            if (PresetComboBox.SelectedItem == default) { return; }

            var value = PresetComboBox.SelectedItem as ColorerMatrixTypeComboBoxItem;

            if (value == default) { return; }

            var isVisible = value.Type.HasValue && value.Descriptor.IsValueRequired;

            PresetTrackBar.Visible = isVisible;
            PresetValueLabel.Visible = isVisible;

            if (isVisible)
            {
                IsAutomaticChange = true;

                PresetTrackBar.Value = Math.Min(PresetTrackBar.Value, PresetTrackBar.Minimum);

                PresetTrackBar.Maximum = (int)value.Descriptor.MaximumValue.Value * 100;
                PresetTrackBar.Value = (int)value.Descriptor.Value * 100;
                PresetTrackBar.Minimum = (int)value.Descriptor.MinimumValue.Value * 100;

                PresetValueLabel.Text = ((float)PresetTrackBar.Value / 100).ToString("F");

                IsAutomaticChange = false;
            }

            CustomGroupBox.Enabled = !value.Type.HasValue;

            ApplyChanges();
        }

        protected virtual void PresetTrackBarScroll(object sender, EventArgs e)
        {
            if (IsAutomaticChange) { return; }

            PresetValueLabel.Text = ((float)PresetTrackBar.Value / 100).ToString("F");

            ApplyChanges();
        }

        protected virtual void RedTrackBarScroll(object sender, EventArgs e)
        {
            RedValueLabel.Text = RedTrackBar.Value.ToString() + "%";

            ApplyChanges();
        }

        protected virtual void SaturationTrackBarScroll(object sender, EventArgs e)
        {
            SaturationValueLabel.Text = ((float)SaturationTrackBar.Value / 100).ToString("F");

            ApplyChanges();
        }

        protected virtual void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (ModifiedPictureBox.Image == default) { return; }

            if (MainSaveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                var extension = Path.GetExtension(MainSaveFileDialog.FileName).ToLowerInvariant().Replace(".", string.Empty);

                if (!TryParseImageFormat(extension, out var imageFormatValue))
                {
                    Console.WriteLine(string.Format("Image extension <{0}> is not supported. Saving image as a BMP.", extension));
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
    }
}
