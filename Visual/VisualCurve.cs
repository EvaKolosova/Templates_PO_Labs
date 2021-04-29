using PO_Templates_Lab1.Geometry;
using PO_Templates_Lab1.Visual;

namespace PO_Templates_Lab1 {
    public class VisualCurve : IDrawable {
        private ICurve c;

        public VisualCurve(ICurve c) { this.c = c; }
        public void Draw(IExtendedDrawable ext)
        {
            IPoint p = new Geometry.Point();

            doGetPoint(0, out p);
            ext.DrawStart(p);

            for (double i = 0; i < 1; i += 0.0005)
            {
                doGetPoint(i, out p);
                ext.DrawMiddlePart(p);
            }

            doGetPoint(1, out p);
            ext.DrawEnd(p);
        }

        protected void doGetPoint(double t, out IPoint p) { c.GetPoint(t, out p); }
    }
}