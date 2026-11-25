using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JE.TestHub.UI
{
    public partial class MoveCircle : Form
    {
        private Point circleLocation;
        private Rectangle? squareLocation = null;

        private const int DotSize = 100;
        private const int SquareSize = 100;

        public MoveCircle()
        {
            InitializeComponent();
            this.ClientSize = new Size(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            circleLocation = new Point(
                this.ClientSize.Width / 2,
                this.ClientSize.Height / 2
                );

            this.MouseClick += MoveCircle_MouseClick;
            this.MouseDoubleClick += MoveCircle_MouseDoubleClick;
        }

        private void MoveCircle_MouseClick(object? sender, MouseEventArgs e)
        {
            squareLocation = new Rectangle(
                e.X - SquareSize / 2,
                e.Y - SquareSize / 2,
                SquareSize,
                SquareSize
                );

            this.Invalidate();
        }

        private void MoveCircle_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            squareLocation = null;

            circleLocation = e.Location;

            this.Invalidate();
        }

        private void MoveCircle_Load(object? sender, EventArgs e)
        {

        }

        private void MoveCircle_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            e.Graphics.FillEllipse(
                Brushes.Black,
                circleLocation.X - DotSize / 2,
                circleLocation.Y - DotSize / 2,
                DotSize,
                DotSize);

            if (squareLocation.HasValue)
            {
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    squareLocation.Value
                    );
            }
        }
    }
}
