using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JE.TestHub.UI
{
    public partial class DragCircle : Form
    {

        private int dotSize = 100;
        private Point dotPosition;

        private bool isDragging = false;
        private Point dragOffset;
        public DragCircle()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            this.ClientSize = new Size(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            dotPosition = new Point(
                (this.ClientSize.Width - dotSize) / 2,
                (this.ClientSize.Height - dotSize) / 2
            );

            this.MouseDown += DragCircle_MouseDown;
            this.MouseMove += DragCircle_MouseMove;
            this.MouseUp += DragCircle_MouseUp;

        }

        private void DragCircle_Load(object? sender, EventArgs e)
        {
        }

        private void DragCircle_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            e.Graphics.FillEllipse(Brushes.Black, dotPosition.X, dotPosition.Y, dotSize, dotSize);
        }

        private void DragCircle_MouseDown(object? sender, MouseEventArgs e)
        {
            //Check if mouse was clicked inside the dot
            if (e.Button == MouseButtons.Left)
            {
                Rectangle dotBounds = new Rectangle(
                    dotPosition.X,
                    dotPosition.Y,
                    dotSize,
                    dotSize
                    );

                if (dotBounds.Contains(e.Location))
                {
                    isDragging = true;

                    //Remember where inside the dot was clicked
                    dragOffset = new Point(
                        e.X - dotPosition.X,
                        e.Y - dotPosition.Y
                        );
                }
            }
        }

        private void DragCircle_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int newX = e.X - dragOffset.X;
                int newY = e.Y - dragOffset.Y;

                newX = Math.Max(0, Math.Min(newX, this.ClientSize.Width - dotSize));
                newY = Math.Max(0, Math.Min(newY, this.ClientSize.Height - dotSize));

                //Update dot position
                dotPosition = new Point(newX, newY);

                this.Invalidate();
            }
        }

        private void DragCircle_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

    }
}
