namespace PO_Templates_Lab1.Geometry {
    abstract class ACurve : ICurve {
        private IPoint a, b;

        public ACurve(IPoint a, IPoint b) {
            this.a = a;
            this.b = b;
        }
        
        abstract public void GetPoint(double t, out IPoint p);
    }
}