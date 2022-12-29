// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

void GetRandomMatrix(int[,] FirstMatrix, int[,] SecondMatrix)
{
    for(int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
            FirstMatrix[i, j] = new Random().Next(1, 9);
        }
    }

    for(int i = 0; i < SecondMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < SecondMatrix.GetLength(1); j++)
        {
            SecondMatrix[i, j] = new Random().Next(1,9);
        }
    }
}

void PrintArray(int[,] FirstMatrix, int[,] SecondMatrix)
{
    Console.WriteLine();
    Console.WriteLine("матрица 1");
    Console.WriteLine();

    for(int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
            Console.Write(FirstMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("матрица 2");
    Console.WriteLine();

    for(int i = 0; i < SecondMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < SecondMatrix.GetLength(1); j++)
        {
            Console.Write(SecondMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MultiplicationMatrix(int[,]  FirstMatrix, int[,] SecondMatrix,  int[,] array)
{
    for(int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
            array[i, j] = FirstMatrix[i, j] * SecondMatrix[i, j];
        }
    }
}

void PrintMultication(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i , j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FirstMatrix = new int[4, 4];
int[,] SecondMatrix = new int[4, 4];
int[,] array = new int[4, 4];
GetRandomMatrix(FirstMatrix, SecondMatrix);
PrintArray(FirstMatrix, SecondMatrix);
Console.WriteLine();
Console.WriteLine("произведение двух матриц");
Console.WriteLine();
MultiplicationMatrix(FirstMatrix, SecondMatrix, array);
PrintMultication(array);