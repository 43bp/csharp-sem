// Создает копию заданного массива 
// с помощью поэлементного копирования

int[] arr = NewRndArrayPositNeg (10, 1, 9);
PrintArray(arr);
Console.WriteLine();
int[] copyArray = CopyArray(arr);
PrintArray(copyArray);

// метод поэлементного копирования массива
int[] CopyArray(int[] array)
{
    int[] copyArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArr[i] = array[i];
    }
    return copyArr;
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