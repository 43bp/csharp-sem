// Найдите произведение пар чисел в одномерном массиве
// Парой считаем первый и последний элемент,
// второй и предпоследний и.т.д. ....
// результат записать в новом массиве

int[] array = NewRndArrayPositNeg(3, 1, 10);
if (CountNumberElements(array) % 2 != 0) Console.WriteLine("Неудаётся сформировать все пары чисел: кол-во элементов в заданном массиве - нечётное!");
else
{
   PrintArray(array);
    int[] result = SumOfPairsSymmetricNums(array);
    Console.WriteLine();
    PrintArray(result);
}


// метод сложения симметричных пар чисел в массиве ([1,2,3,4] -> 1+4, 2+3)
int[] SumOfPairsSymmetricNums (int[] arr)
{
    int length = arr.Length;
    int count = length / 2;
    int[] sumPairsArray = new int[count];
    int i = default;
    int j = default;
    int e = 1;
    while (i < count)
    {
        sumPairsArray[i] = arr[j] + arr[length - e];
        j++;
        i++;
        e++;
    }
    return sumPairsArray;
}


// метод подсчета кол-ва элементов массива
int CountNumberElements (int[] arr)
{
    int countNumberElem = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        countNumberElem++;
    }
    return countNumberElem;
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