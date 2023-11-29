string[,] text = new string[,] {
                                {"Tom", "Bob", "Roma", "Peppi", "Sam"},
                                {"Igor", "Sergey", "Barry", "Kevin", "Tomas"}
                                };

int[,] numbers = new int[,] {
                            {11,12,13,14,15},
                            {21,22,23,24,25},
                            {31,32,33,34,35}
                            };

/*
    вывод на экран двухмерного массива строк
*/
void ShowStringMatrix(string[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        Console.Write($"row[{rows}]: ");
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"[{matrix[rows, columns]}] ");
        }
        Console.WriteLine();
    }
}

/*
    вывод на экран двухмерного массива чисел (int)
*/
void ShowIntMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        Console.Write($"row[{rows}]: ");
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"[{matrix[rows, columns]}] ");
        }
        Console.WriteLine();
    }
}

/*
    создание двухмерного массива чисел, с заполнением случайными значениями
*/
int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rnd.Next(min, max+1);
        }
    return result;
}

void FillRandomMatrix(int[,] matrix, int min, int max)
{
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max+1);
        }
}

Console.Clear();
Console.WriteLine("Show strings array");
ShowStringMatrix(text);
Console.WriteLine("Show numbers array");
ShowIntMatrix(numbers);
FillRandomMatrix(numbers, 10, 99);
Console.WriteLine("Show filled array");
ShowIntMatrix(numbers);
int[,] rand = CreateRandomMatrix(3,4,10,99);
Console.WriteLine("Show random array");
ShowIntMatrix(rand);

