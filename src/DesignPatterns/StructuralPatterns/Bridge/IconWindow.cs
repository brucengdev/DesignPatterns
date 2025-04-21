namespace Bridge;

public class IconWindow: Window
{
    public void DrawBorder()
    {
        //using Imp here
    }

    public IconWindow(WindowImp windowImp, int x, int y, int w, int h) 
        : base(windowImp, x, y, w, h)
    {
    }
}