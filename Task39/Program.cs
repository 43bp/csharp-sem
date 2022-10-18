// перевернуть одномерный массив

// метод печати массива
void PrintArray (int[] array)
{
    Console.Write("[");
        for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

// метод создания и заполнения массива + и - элементами
int[] NewRndArrayPositNeg (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

// метод переворачивания массива
void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

int[] arr = NewRndArrayPositNeg(5, 1, 9);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);