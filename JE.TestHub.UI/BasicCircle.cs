using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JE.TestHub.UI
{
    public partial class BasicCircle : Form
    {
        public BasicCircle()
        {
            InitializeComponent();
            this.ClientSize = new Size(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BasicCircle_Load(object sender, EventArgs e)
        {
            
        }

        private void BasicCircle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            int dotSize = 100;

            e.Graphics.FillEllipse(Brushes.Black, centerX - dotSize / 2, centerY - dotSize / 2, dotSize, dotSize);
        }
    }
}
