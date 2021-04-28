using PO_Templates_Lab1.Geometry;
using PO_Templates_Lab1.Visual;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PO_Templates_Lab1
{
    public partial class Form1 : Form, IExtendedDrawable  //TODO декоратор с тенями
    {
        Graphics gr;
        Brush br1 = (Brush)Brushes.Blue;
        Brush br2 = (Brush)Brushes.Red;

        public Form1()
        {
            InitializeComponent();
            gr = this.CreateGraphics();
        }
        public void DrawMiddlePart(IPoint p)
        {
            gr.FillRectangle(br1, (float)p.GetX(), (float)p.GetY(), 1, 1);
        }
        public void DrawStart(IPoint p)
        {
            gr.FillRectangle(br2, (float)p.GetX(), (float)p.GetY(), 5, 5);
        }
        public void DrawEnd(IPoint p)
        {
            gr.FillRectangle(br2, (float)p.GetX(), (float)p.GetY(), 5, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // draw Line
            IPoint start = new Geometry.Point();
            start.SetX(50);
            start.SetY(350);
            IPoint finish = new Geometry.Point();
            finish.SetX(300);
            finish.SetY(100);

            ICurve curveL = new Line(start, finish);

            VisualCurve vCurveL = new VisualCurve(curveL);
            vCurveL.Draw(this);
            //-----------------

            //draw Bezier 
            IPoint a = new Geometry.Point();
            a.SetX(150);
            a.SetY(400);
            IPoint b = new Geometry.Point();
            b.SetX(450);
            b.SetY(150);
            IPoint c = new Geometry.Point();
            c.SetX(100);
            c.SetY(50);
            IPoint d = new Geometry.Point();
            d.SetX(350);
            d.SetY(400);

            ICurve curveB = new Bezier(a, b, c, d);

            VisualCurve vCurveB = new VisualCurve(curveB);
            vCurveB.Draw(this);
            //-----------------
        }
    }
}