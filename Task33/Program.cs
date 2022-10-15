// задайте массив
// определите присутствует ли заданное число в массиве

int[] arr = NewRndArrayPositNeg(8, 1, 10);
PrintArray(arr);

Console.WriteLine("Введите число для поиска в массиве: ");
int searchNum = Convert.ToInt32(Console.ReadLine());

if (SearchNum(arr, searchNum)) Console.WriteLine($"{searchNum} -> да");
else Console.WriteLine($"{searchNum} -> нет");


// метод поиска числа в массиве
bool SearchNum (int[] array, int searchNum)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == searchNum) return true;
    }
    return false;
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