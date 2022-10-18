// Первые N чисел Фибоначчи

Console.WriteLine("Введите число N для ряда Фибоначчи: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] fibonacci = Fibonacci(N);
PrintArray(fibonacci);

// метод построения ряда Фибоначчи размера N
int[] Fibonacci(int num)
{   
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
   {
        array[i] = array[i - 2] + array[i - 1];
   }
    return array;
}

// метод печати массива
void PrintArray (int[] array)
{
        for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write(array[i]);
    }
}