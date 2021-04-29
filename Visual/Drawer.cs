using System;
using System.Drawing;
using PO_Templates_Lab1.Geometry;

namespace PO_Templates_Lab1.Visual
{
    class Drawer : IExtendedDrawable
    {
        private Graphics gr;
        protected Brush br;

        public Drawer(Graphics gr, Brush br)
        {
            this.gr = gr;
            this.br = br;
        }

        public void DrawMiddlePart(IPoint p)
        {
            gr.FillRectangle(br, (float)p.GetX(), (float)p.GetY(), 1, 1);
        }
        public void DrawStart(IPoint p)
        {
            gr.FillRectangle(br, (float)p.GetX(), (float)p.GetY(), 5, 5);
        }
        public void DrawEnd(IPoint p)
        {
            gr.FillRectangle(br, (float)p.GetX(), (float)p.GetY(), 5, 5);
        }
    }
}
