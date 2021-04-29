using PO_Templates_Lab1.Geometry;
using System;

namespace PO_Templates_Lab1.Visual
{
    class Writer : IExtendedDrawable
    {
        public void DrawEnd(IPoint p)
        {
            Console.Write("End point: x=");
            Console.Write(p.GetX());
            Console.Write(" ,y=");
            Console.Write(p.GetY());
            Console.Write("\n");
        }

        public void DrawMiddlePart(IPoint p)
        {
            Console.Write("Middle point: x=");
            Console.Write(p.GetX());
            Console.Write(" ,y=");
            Console.Write(p.GetY());
            Console.Write("\n");
        }

        public void DrawStart(IPoint p)
        {
            Console.Write("Start point: x=");
            Console.Write(p.GetX());
            Console.Write(" ,y=");
            Console.Write(p.GetY());
            Console.Write("\n");
        }
    }
}
