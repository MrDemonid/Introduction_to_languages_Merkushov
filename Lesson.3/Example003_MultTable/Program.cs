/*
    Таблица умножения, с использованием цикла FOR
*/

void PrintMultTable()
{
    for (int i = 2; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            Console.SetCursorPosition((i-2)*14, j);
            Console.Write($"{i} * {j} = {i*j}");
        }
    }
    Console.WriteLine();
}

Console.Clear();
PrintMultTable();
