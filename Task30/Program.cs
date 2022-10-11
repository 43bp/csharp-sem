// Выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке

int[] array = new int[8]; // создаем массив c 8 элементами (заполнен нулями)
FillArray (array);
PrintArray (array);

// Метод заполнения массива рандомными 0 и 1
void FillArray(int[] arr)
{
    int length = arr.Length;
    Random rnd = new Random(); // создаем объект rnd
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(0, 2); // а потому что запомни, наконец, что 2 - НЕ включительно
    }
}

// Метод печати массива
void PrintArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if (i == 0) Console.Write("[");
        Console.Write(arr[i]);
        if (i < length - 1) Console.Write(", ");
        if (i == length - 1) Console.Write("]");
    }
}