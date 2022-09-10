Console.Clear();

int xa = 1, ya =25, 
    xb = 35, yb = 1,
    xc = 70, yc = 25;

Console.SetCursorPosition(xa,ya);
Console.Write("+");
Console.SetCursorPosition(xb,yb);
Console.Write("+");
Console.SetCursorPosition(xc,yc);
Console.Write("+");

int x = xa, y = ya, i = 0;

while (i < 15000)
{
    int what = new Random().Next(0,3);
    if (what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
    if (what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }
    if (what == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }    
    Console.SetCursorPosition(x,y);
    Console.Write("+");
    i++;
}