// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// (в примере подсчет индексов начинается с 1 , как в математике)
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetSquareMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i+= 2)
    {
        for(int j = 0; j < matrix.GetLength(1); j+= 2)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
}

int rowsCount = ReadInt("Введите число строк:");
int columnsCount = ReadInt("Введите число столбцов:");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
GetSquareMatrix(matrix);
PrintMatrix(matrix);




