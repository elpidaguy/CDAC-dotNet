using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    public partial class Form1 : Form
    {
        Point startPoint = new Point(23, 23);
        Point endPoint = new Point(300, 300);
        Color shapeColor;
        String Shape;

        public Form1()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OnFileExit(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure?", "CDAC ACTS", MessageBoxButtons.OKCancel);
            this.Close();
        }

        private void sHapeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OnPenColor(object sender, EventArgs e)
        {
            ColorDialog colorDiag = new ColorDialog();
            if (colorDiag.ShowDialog() == DialogResult.OK)
            {
                shapeColor = colorDiag.Color;
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            endPoint = new Point(e.X, e.Y);
            Pen thePen = new Pen(shapeColor, 5);
            Graphics g = this.CreateGraphics();

            int width = endPoint.X - startPoint.X;
            int height = endPoint.Y - startPoint.Y;

            if (Shape == "Line")
            {
                g.DrawLine(thePen, startPoint, endPoint);
            }
            else if (Shape == "Rectangle")
            {
                g.DrawRectangle(thePen, startPoint.X, startPoint.Y, width, height);
            }
            else if (Shape == "Ellipse")
            {
                g.DrawEllipse(thePen, startPoint.X, startPoint.Y, width, height);
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(e.X,e.Y);
        }

        private void OnShapeLine(object sender, EventArgs e)
        {
            Shape = "Line";
        }

        private void OnShapeRectangle(object sender, EventArgs e)
        {
            Shape = "Rectangle";
        }

        private void OnShapeEllipse(object sender, EventArgs e)
        {
            Shape = "Ellipse";
        }
    }
}
