// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetRandomMatrix(int rows, int columns, int LeftRange = -5, int RightRange = 5)
{
    double[,] matrix = new double[rows, columns];
    Random random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i, j] = random.NextDouble();
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
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
double[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);
