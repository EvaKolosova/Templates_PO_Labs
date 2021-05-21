using PO_Templates_Lab1.Geometry;
using PO_Templates_Lab1.Visual;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PO_Templates_Lab1
{
    public partial class Form1 : Form  //TODO декоратор с тенями
    {
        Graphics gr;
    
        public Form1()
        {
            InitializeComponent();
            gr = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //---draw Line
            IPoint start = new Geometry.Point();
            start.SetX(50);
            start.SetY(350);
            IPoint startForFragment = new Geometry.Point();
            startForFragment.SetX(50);
            startForFragment.SetY(320);
            IPoint finish = new Geometry.Point();
            finish.SetX(300);
            finish.SetY(100);
            IPoint finishForFragment = new Geometry.Point();
            finishForFragment.SetX(300);
            finishForFragment.SetY(80);

            ICurve curveL = new Line(start, finish);
            ICurve curveLforFr = new Line(startForFragment, finishForFragment);
            //Fragment fr = new Fragment(1, 0, curveLforFr);
            Fragment fr = new Fragment(1, 0.5, curveLforFr);

            VisualCurve vCurveL = new VisualCurve(curveL);
            VisualCurve vCurveLforFr = new VisualCurve(fr);
            //---draw Line in Form
            Drawer drawer = new Drawer(gr, (Brush)Brushes.Blue);
            //vCurveL.Draw(drawer);

            //---print to Console values
            Writer writer = new Writer();
            vCurveL.Draw(writer);

            //---draw shadow by decorator
            Drawer shadowDrawer = new Drawer(gr, (Brush)Brushes.Gray);
            DecoratorShadow decoratorShadowL = new Visual.DecoratorShadow(vCurveL, shadowDrawer);
            decoratorShadowL.Draw(drawer);

            DecoratorShadow decoratorShadowLforFr = new Visual.DecoratorShadow(vCurveLforFr, shadowDrawer);
            decoratorShadowLforFr.Draw(drawer);

            //-----------------

            //---draw Bezier 
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
            //vCurveB.Draw(drawer);

            //---print to Console values
            vCurveB.Draw(writer);

            //---draw shadow by decorator
            DecoratorShadow decoratorShadowB = new Visual.DecoratorShadow(vCurveB, shadowDrawer);
            decoratorShadowB.Draw(drawer);
            //-----------------
        }
    }
}