using System;
using System.Collections.Generic;
namespace PO_Templates_Lab1.Geometry {
    class Point : IPoint {
        private double x, y;

        public void SetX(double x) { this.x = x; }

        public void SetY(double y) { this.y = y; }

        public double GetX() { return x; }

        public double GetY() { return y; }
    }
}
