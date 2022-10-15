// Массив с положительными и отрицательными элементами
// Заменяет + на - и наоборот

int[] arr = NewRndArrayPositNeg(8, -10, 10);
PrintArray(arr);
Console.WriteLine();
ChangeDigitSign(arr);
PrintArray(arr);


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

// метод замены в массиве + на - и наоборот
void ChangeDigitSign (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
}