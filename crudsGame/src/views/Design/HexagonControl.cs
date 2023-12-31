﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudsGame.src.views
{
    public partial class HexagonControl : UserControl
    {
        private Color borderColor = Color.Black;
        private int borderWidth = 10; // --> Es el ancho del borde (px)

        public string HexagonText
        {
            get { return Text; }
            set { Text = value; }
        }

        public HexagonControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
       

        
        public Color BorderColor // --> Establece el color al borde del hexagono
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate(); // --> Vuelve a dibujar el control (hexagono) cuando se cambia el color del borde.
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int width = ClientSize.Width;
            int height = ClientSize.Height;

            Point[] points = new Point[6];
            points[0] = new Point(width / 4, 0);
            points[1] = new Point(3 * width / 4, 0);
            points[2] = new Point(width, height / 2);
            points[3] = new Point(3 * width / 4, height);
            points[4] = new Point(width / 4, height);
            points[5] = new Point(0, height / 2);

            path.AddPolygon(points);

            this.Region = new Region(path);

            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            using (Pen pen = new Pen(BorderColor, borderWidth)) // --> Dibuja el borde
            {
                e.Graphics.DrawPath(pen, path);
            }

            using (StringFormat format = new StringFormat()) // -->  Dibuja el texto en el centro del hexágono
            {
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                using (SolidBrush textBrush = new SolidBrush(ForeColor))
                {
                    e.Graphics.DrawString(HexagonText, Font, textBrush, ClientRectangle, format);
                }
            }

            base.OnPaint(e);
        }
        
    }
}

