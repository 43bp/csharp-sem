// задайте одномерный массив из 123-х случ.чисел
// найдите кол-во элементов массива, 
// значения которых лежат в отрезке [10,99]

int[] array = NewRndArrayPositNeg (123, 0, 99);
int numOfTwoDigitElem = NumOfElemInRange(array, 10, 99);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Кол-во элементов массива в пределах от 10 до 99 равно: {numOfTwoDigitElem}");



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
    Console.Write("]");
}


// метод подсчета кол-ва элементов в заданном диапазоне
int NumOfElemInRange(int[] arr, int min, int max)
{
    int numberOfElem = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= min && arr[i] <= max) numberOfElem++;
    }
    return numberOfElem;
}