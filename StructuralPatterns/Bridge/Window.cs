namespace Bridge;

public class Window
{
    protected WindowImp Imp;
    protected int x, y, w, h;
    public Window(WindowImp windowImp, int x, int y, int w, int h)
    {
        this.x = x;
        this.y = y;
        this.w = w;
        this.h = h;
    }

    public void DrawRect()
    {
        Imp.DrawLine(x, y, x, y + h);
        Imp.DrawLine(x, y, x + w, y);
        Imp.DrawLine(x + w, y, x + w, y + h);
        Imp.DrawLine(x, y + h, x + w, y + h);
    }
}