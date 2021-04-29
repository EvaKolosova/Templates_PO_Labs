using PO_Templates_Lab1.Geometry;

namespace PO_Templates_Lab1.Visual
{
    class DecoratorShadow : IDrawable, IExtendedDrawable
    {
        private IExtendedDrawable shadow;
        private IDrawable com;

        public DecoratorShadow(IDrawable com, IExtendedDrawable shadow)
        {
            this.com = com;
            this.shadow = shadow;
        }

        public void Draw(IExtendedDrawable ext)
        {
            com.Draw(this);
            com.Draw(ext);
        }

        public void DrawEnd(IPoint p)
        {
            p.SetY(p.GetY() + 10);
            shadow.DrawEnd(p);
        }

        public void DrawMiddlePart(IPoint p)
        {
            p.SetY(p.GetY() + 10);
            shadow.DrawMiddlePart(p);
        }

        public void DrawStart(IPoint p)
        {
            p.SetY(p.GetY() + 10);
            shadow.DrawStart(p);
        }
    }

}
