// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] array = NewRndArrayMatrix (5, 6, 0, 10);
PrintMatrix (array);
Console.WriteLine();
ChangeFirstLastRows (array);
PrintMatrix (array);

// метод создания и заполнения массива элементами
int[,] NewRndArrayMatrix (int rows, int col, int min, int max)
{
    var matrix = new int[rows, col]; 
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

// метод замены местами 1-й и последней строк массива
void ChangeFirstLastRows (int[,] matrix)
{
    for (var j = 0; j < matrix.GetLength(1); j++)
    {
       int temp = matrix[0, j];
       matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
       matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}