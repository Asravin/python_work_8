// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int LeftRange = 1, int RightRange = 10)
{
    int[,] matrix = new int[3, 4];
    var rand = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i, j] = rand.Next(LeftRange, RightRange + 1);
        }
    }
    if(rows > matrix.GetLength(0) || columns > matrix.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else
    {
        Console.WriteLine($" значение элемента = {matrix[rows -3, columns -3]}");
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

int rowsCount = ReadInt("Введите номер строки:");
int columnsCount = ReadInt("Введите номер столбца:");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);