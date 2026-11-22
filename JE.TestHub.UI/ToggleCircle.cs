using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JE.TestHub.UI
{
    public partial class ToggleCircle : Form
    {
        private bool dotVisible = true;
        private bool ctrlPressed = false;
        public ToggleCircle()
        {
            InitializeComponent();
            this.ClientSize = new Size(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ToggleCircle_Load(object? sender, EventArgs e)
        {

        }

        private void ToggleCircle_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            int dotSize = 100;
            if (dotVisible)
            {
                e.Graphics.FillEllipse(Brushes.Black, centerX - dotSize / 2, centerY - dotSize / 2, dotSize, dotSize);
            }

            txtTracker.Text = dotVisible ? "Dot is Visible" : "Dot is not Visible";
        }

        private void btnToggle_Click(object? sender, EventArgs e)
        {
            dotVisible = !dotVisible;
            this.Invalidate();
        }

        private void btnShow_Click(object? sender, EventArgs e)
        {
            dotVisible = true;
            this.Invalidate();
        }

        private void btnHide_Click(object? sender, EventArgs e)
        {
            dotVisible = false;
            this.Invalidate();
        }

        private void ToggleCircle_KeyDown(object? sender, KeyEventArgs e)
        {
            bool isControlKey = e.KeyCode == Keys.ControlKey ||e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.RControlKey;

            if (isControlKey && !ctrlPressed)
            {
                ctrlPressed = true;
                dotVisible = !dotVisible;
                this.Invalidate();
            }
        }

        private void ToggleCircle_KeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.LControlKey ||e.KeyCode == Keys.RControlKey)
            {
                ctrlPressed = false;
            }
        }

    }
}
