//Задача 55: Задайте двумерный массив. Напишите программу,
//которая заменяет строки на столбцы. В случае, если это
//невозможно, программа должна вывести сообщение для
//пользователя.

int[,] array = NewRndArrayMatrix (5, 4, 0, 10);
PrintMatrix (array);
Console.WriteLine();
if (CheckSquareArray(array)) 
{
    ChangeRowsToCollArray (array);
    PrintMatrix (array);  
}
else Console.WriteLine("Массив не квадратный!");


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

// метод проверки "квадратности" массива
bool CheckSquareArray (int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1)) return true;
    else return false;
}

// метод замены строк на столбцы в квадратном массиве
void ChangeRowsToCollArray (int[,] matrix)
{
    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        for (var j = i; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}