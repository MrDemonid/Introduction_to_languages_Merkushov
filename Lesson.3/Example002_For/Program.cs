/*
  Цикл FOR
*/


void PutRect(int x, int y, int width, int height)
{
    for (int yy = 0; yy < height; yy++)
    {
        Console.SetCursorPosition(x, yy+y);
        for (int xx = 0; xx < width; xx++)
        {
            Console.Write("#");
        }
    }
    Console.WriteLine();
}

Console.Clear();
PutRect(4, 2, 32, 5);
