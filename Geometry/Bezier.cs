using System;

namespace PO_Templates_Lab1.Geometry {
    class Bezier : ACurve {
        private IPoint a, b, c, d;

        public Bezier(IPoint a, IPoint b, IPoint c, IPoint d) : base(a, b) {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override void GetPoint(double t, out IPoint p) {
            p = new Point();
            double x = 0, y = 0;

            x = Math.Pow((1 - t), 3) * a.GetX() + 3 * t * Math.Pow((1 - t), 2) * b.GetX() + 3 * Math.Pow(t, 2) * (1 - t) * c.GetX() + Math.Pow(t, 3) * d.GetX();
            y = Math.Pow((1 - t), 3) * a.GetY() + 3 * t * Math.Pow((1 - t), 2) * b.GetY() + 3 * Math.Pow(t, 2) * (1 - t) * c.GetY() + Math.Pow(t, 3) * d.GetY();

            p.SetX(x);
            p.SetY(y);
        }
    }
}
