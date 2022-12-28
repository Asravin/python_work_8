// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int LeftRange = 0, int RightRange = 10)
{
    int[,] matrix = new int[rows, columns];
    var rand = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i, j] = rand.Next(LeftRange, RightRange + 1);
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

int[,] Tmatrix(int[,] sourseMatrix)
{
    int[,] tmatrix = new int[sourseMatrix.GetLength(1), sourseMatrix.GetLength(0)];
    for(int i = 0; i < tmatrix.GetLength(0); i++)
    {
        for(int j = 0; j < tmatrix.GetLength(1); j++)
        {
            tmatrix[i, j] = sourseMatrix[j, i];
        }
    }
    return tmatrix;
}

int rowsCount = ReadInt("Введите число строк:");
int columnsCount = ReadInt("Введите число столбцов:");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);
int[,] newMatrix = Tmatrix(matrix);
Console.WriteLine();
PrintMatrix(newMatrix);