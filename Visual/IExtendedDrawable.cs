using PO_Templates_Lab1.Geometry;
namespace PO_Templates_Lab1.Visual {
    public interface IExtendedDrawable {   
        void DrawMiddlePart(IPoint p);
        void DrawStart(IPoint p);
        void DrawEnd(IPoint p);   
    }
}
