using PO_Templates_Lab1.Geometry;
using System.Drawing;

namespace PO_Templates_Lab1.Visual
{
    class DecoratorShadow : IExtendedDrawable
    {
        //TODO decorator for lines with shadow

        private Graphics gr;
        private Brush brShadow = (Brush)Brushes.Gray;

        public DecoratorShadow(Graphics gr)
        {
            this.gr = gr;
        }
     
        public void DrawEnd(IPoint p)
        {
            p.SetY(p.GetY() + 10);
            gr.FillRectangle(brShadow, (float)p.GetX(), (float)p.GetY(), 5, 5);
        }

        public void DrawMiddlePart(IPoint p)
        {
            p.SetY(p.GetY() + 10);
            gr.FillRectangle(brShadow, (float)p.GetX(), (float)p.GetY(), 1, 1);
        }

        public void DrawStart(IPoint p)
        {
            p.SetY(p.GetY() + 10);
            gr.FillRectangle(brShadow, (float)p.GetX(), (float)p.GetY(), 5, 5);
        }
    }
}
