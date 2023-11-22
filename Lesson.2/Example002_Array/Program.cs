int IndexOf(int[] array, int find)
{
    int len = array.Length;
    int index = 0;
    
    while (index < len)
    {
        if (array[index] == find)
            return index;
        index++;
    }
    return -1;
}

int[] array = {111, 21, 31, 41, 15, 61, 17, 18, 192};

Console.WriteLine("found elem at " + IndexOf(array, 41) + " index");
