using PO_Templates_Lab1.Geometry;
using PO_Templates_Lab1.Visual;

namespace PO_Templates_Lab1 {
    public class VisualCurve : IDrawable { //TODO decorator with 1 to 0 values
        private ICurve c;

        public VisualCurve(ICurve c) { this.c = c; }
        public void Draw(IExtendedDrawable ext)
        {
            IPoint p = new Geometry.Point();

            p = doGetPoint(0);
            ext.DrawStart(p);

            for (double i = 0; i < 1; i += 0.0003)
            {
                p = doGetPoint(i);
                ext.DrawMiddlePart(p);
            }

            p = doGetPoint(1);
            ext.DrawEnd(p);
        }

        protected IPoint doGetPoint(double t) { return c.GetPoint(t); }
    }
}