void FillArray(int[] array)
{
    int len = array.Length;
    int index = 0;
    while (index < len)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] mas)
{
    int count = mas.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.WriteLine(mas[pos]);
        pos++;
    }
}

int IndexOf(int[] array, int find)
{
    int len = array.Length;
    int index = 0;
    int found = -1;

    while (index < len)
    {
        if (array[index] == find)
        {
            found = index;
            break;
        }
        index++;
    }
    return found;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

int elem = IndexOf(array, 4);
if (elem != -1)
{
    Console.WriteLine("Index = " + elem);
} else {
    Console.WriteLine("Index not found!");
}

