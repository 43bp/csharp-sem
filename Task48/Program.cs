// двумерный массив размера m,n
// каждый элемент по формуле Amn = m + n

int[,] matrixMN = NewRndArrayMatrix (5, 5);
PrintMatrix (matrixMN);


// метод создания и заполнения массива (m,n) элементами Amn = m + n
int[,] NewRndArrayMatrix (int rows, int col)
{
    var matrix = new int[rows, col]; 
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - определяем кол-во строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 0 - определяем кол-во столбцов
        {
            matrix[i, j] = i + j;
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
        Console.WriteLine("  |");
    }
}