// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i, j] = i + j;
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
       for(int i = 0; i < matrix.GetLength(0); i++)
    {
         Console.WriteLine();
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            Console.Write(matrix[i, j] + " ");
        }
    }
}

int rowsCount = ReadInt("Введите число строк:");
int columnsCount = ReadInt("Введите число столбцов:");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);