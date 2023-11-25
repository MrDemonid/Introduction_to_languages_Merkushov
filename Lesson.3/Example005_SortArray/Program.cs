/*
    Упорядочить массив, методом максимального (выбора максимального, или выбора минимального)
*/
void swap(int[] array, int i1, int i2)
{
    int tmp = array[i1];
    array[i1] = array[i2];
    array[i2] = tmp;
}

void PrintArray(int[] array)
{
    for (int idx = 0; idx < array.Length; idx++)
    {
        Console.Write(array[idx]);
        if (idx < array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}


void SortM(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int min = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[min])
                min = j;
        }
        if (min != i)
        {
            swap(array, min, i);
        }
    }
}

int[] mas = {6,8,3,2,1,4,5,7,0,2,4,0,9};

PrintArray(mas);
SortM(mas);
PrintArray(mas);
