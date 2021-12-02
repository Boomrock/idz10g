using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idz10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Black, 3f);
            graphics.FillRectangle(solidBrush, new Rectangle(new Point(200, 50), new Size(100, 20)));
            graphics.DrawLine(pen, 10, 20, 100, 100);
            graphics.DrawEllipse(pen, new Rectangle(90, 90, 100, 100));
            graphics.DrawPolygon(pen, new Point[] { new Point(300, 50), new Point(310, 60), new Point(320, 70), new Point(500, 100), new Point(400, 310) });
        }
    }
}
