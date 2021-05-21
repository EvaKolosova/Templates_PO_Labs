using System;
using System.Collections.Generic;
using System.Linq;
namespace PO_Templates_Lab1.Geometry {
    class Line : ACurve {

        private IPoint a, b;
        public Line(IPoint a, IPoint b) : base(a, b) {
            this.a = a;
            this.b = b;
        }

        public override IPoint GetPoint(double t) {
            IPoint p = new Point();
            double x = (1 - t) * a.GetX() + t * b.GetX();
            double y = (1 - t) * a.GetY() + t * b.GetY();

            p.SetX(x);
            p.SetY(y);

            return p;
        }
    }
}