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

using ImageBox.UI.Windows.Main;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ImageBox.UI.Windows
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            Icon = Properties.Resources.Icon;
            InitializeComponent();
        }

        protected virtual void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            new AboutWindow().ShowDialog(this);
        }

        protected virtual void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected virtual void MainWindowLoad(object sender, EventArgs e)
        {
            var components = new List<ButtonComponent>()
            {
                new ButtonComponent() { Text = "Color an Image", Action = (s, ae) => { Hide();  using(var w = new ColoringWindow()) { w.ShowDialog(this); } if(!IsDisposed) { Show(); } } },
                new ButtonComponent() { Text = "Split an Image", Action = (s, ae) => { Hide();  using(var w = new SplitWindow()) { w.ShowDialog(this); } if(!IsDisposed) { Show(); } } },
                new ButtonComponent() { Text = "Image Statistics", Action = (s, ae) => { Hide();  using(var w = new StatisticsWindow()) { w.ShowDialog(this); } if(!IsDisposed) { Show(); } } }
            };

            for (int x = 0; x < components.Count; x++)
            {
                var component = components[x];

                var panel = new Panel()
                {
                    Location = new Point(0, 0),
                    Dock = DockStyle.Fill
                };

                MainTableLayoutPanel.Controls.Add(panel);

                var button = new Button()
                {
                    Text = component.Text,
                    Size = new Size((int)(panel.Width * 0.45), (int)(panel.Width * 0.3)),
                    Location = new Point(panel.Width / 2 - 100, panel.Height / 2 - 50)
                };

                panel.Resize += (ps, pe) => { button.Location = new Point(panel.Width / 2 - 100, panel.Height / 2 - 50); };

                button.Click += (bs, be) => component.Action(bs, be);

                panel.Controls.Add(button);
            }
        }

        protected virtual void ReportAnIssueToolStripMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://github.com/AmericusMaximus/ImageBox/issues") { UseShellExecute = true, Verb = "open" });
            }
            catch (Exception) { }
        }

        protected virtual void VisitWebsiteToolStripMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://github.com/AmericusMaximus/ImageBox") { UseShellExecute = true, Verb = "open" });
            }
            catch (Exception) { }
        }
    }
}
