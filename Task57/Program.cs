// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int [,] arrayMatrix = NewRndArrayMatrix (3, 4, 0, 10);
PrintMatrix (arrayMatrix);
Console.WriteLine();
int [] array  = Convert2DTo1DArray(arrayMatrix);
Array.Sort(array);
CountSameNumbers (array);

// метод создания и заполнения массива + и - элементами
int[,] NewRndArrayMatrix (int rows, int col, int min, int max)
{
    var matrix = new int[rows, col]; // var - 
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - определяем кол-во строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 0 - определяем кол-во столбцов
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// метод печати массива
void PrintMatrix (int[,] matrix)
{
    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}");
            else Console.Write($"{matrix[i, j], 4}"); // ,4 - это форматирование - расстояние между числами, чтоб было все ровно
        }
        Console.WriteLine("   |");
    }
}

// метод конвертации двумерного массива в одномерный
int[] Convert2DTo1DArray(int[,] matrix)
{
    int[] new1dArray = new int[matrix.Length];
    int a = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - определяем кол-во строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 0 - определяем кол-во столбцов
        {
            new1dArray[a] = matrix[i, j];
            a++;
        }
    }
    return new1dArray;
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

// метод подсчета кол-ва одинаковых чисел в массиве
void CountSameNumbers (int[] arr)
{
    int num = array[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (array[i] == num) count++;
        else
        {
            Console.WriteLine($"Количество {num} равно: {count}");
            num = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Количество {num} равно: {count}");
}