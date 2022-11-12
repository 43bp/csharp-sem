// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.





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
