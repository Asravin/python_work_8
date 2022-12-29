// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i ,j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for(int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i, j] + " ");
        }
    }
    Console.WriteLine();
}

void IncreasingrElement(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k =  0; k < array.GetLength(1) - j - 1; k++)
            {
                if(array[i, k] > array[i, k + 1])
                {
                    int count = array[i, k];
                    array[i, k] = array[i , k + 1];
                    array[i, k + 1] = count;
                }
            }
        }
    }
}

int rowsCount = ReadInt("Введите число стобцов:");
int columnsCount = ReadInt("Введите число строк:");
int[,] array = GetRandomArray(rowsCount, columnsCount);
PrintArray(array);
Console.WriteLine();
IncreasingrElement(array);
PrintArray(array);