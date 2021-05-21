
using PO_Templates_Lab1.Geometry;

namespace PO_Templates_Lab1.Visual
{
    class Fragment : ICurve
    {
        ICurve curve;
        private double tStart = 0.0;
        private double tFinish = 1.0;

        public Fragment(double start, double finish, ICurve curve)
        {
            this.curve = curve;
            tStart = start;
            tFinish = finish;
        }
        public IPoint GetPoint(double t)
        {
            double newT = tStart + t * (tFinish - tStart);
            return curve.GetPoint(newT);
        }
    }
}
