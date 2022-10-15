// массив 12 элементов от -9 до 9.
// сумма положительных и отрицательных элементов


int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray (arr);

int[] result = GetSumPositNegElem(arr);

Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел: {result[0]}");
Console.WriteLine($"Сумма отрицательных чисел: {result[1]}");




//метод создания и заполнения массива
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
        
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}


//метод печати массива в формате [1, 2, 3]
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

// метод суммирования положительных и отдельно отрицательных чисел массива
int[] GetSumPositNegElem (int[] array)
{
    int sumNeg = default;
    int sumPosit = default;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNeg += array[i]; // += - это тот же sumNeg = sumNeg + array[i]
        else sumPosit += array[i];
    }
    return new int[] {sumPosit, sumNeg};
}
