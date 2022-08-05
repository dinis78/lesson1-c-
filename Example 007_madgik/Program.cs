Console.Clear();
//Console.SetCursorPosition (8, 5);
//Console.WriteLine ("*");

int xa = 30, ya = 2;
int xb = 4, yb = 25;
int xc = 90, yc = 15;
Console.SetCursorPosition(xa,ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("*");

int x=xa, y=ya;

int count=0;

while(count<100000)
{
    int what = new Random().Next(0, 4); // (0;4) 0 1 2 3
    if(what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }

    if (what==1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }

    if(what==2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++;
}

