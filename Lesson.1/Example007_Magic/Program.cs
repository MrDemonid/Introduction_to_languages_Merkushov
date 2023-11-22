Console.Clear();
// Console.SetCursorPosition(10,4);
// Console.WriteLine("*");

int aX = 40;
int aY = 1;

int bX = 1;
int bY = 30;

int cX = 80;
int cY = 30;

Console.SetCursorPosition(aX, aY); Console.Write("*");
Console.SetCursorPosition(bX, bY); Console.Write("*");
Console.SetCursorPosition(cX, cY); Console.Write("*");

int x = aX;
int y = aY;
int count = 0;;

while (count < 5000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + aX) / 2;
        y = (y + aY) / 2;
    }
    if (what == 1)
    {
        x = (x + bX) / 2;
        y = (y + bY) / 2;
    }
    if (what == 2)
    {
        x = (x + cX) / 2;
        y = (y + cY) / 2;
    }
    
    Console.SetCursorPosition(x, y);
    Console.Write("*");

    count++;
}

Console.SetCursorPosition(0,31);
