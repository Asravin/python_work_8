// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[,] DeleteMinElement(int[,] source)
{
    int min = source[0, 0];
    int min_i = 0;
    int min_j = 0;

    for(int i = 0; i < source.GetLength(0); i++)
    {
        for(int j = 0; j < source.GetLength(1); j++)
        {
            if(source[i, j] < min)
            {
                min_i = i;
                min_j = j;
                min = source[i, j];
            }
        }
    }

    int[,] NewArray = new int[source.GetLength(0) - 1, source.GetLength(1) - 1];
    int RowOffset = 0;
    int ColumnsOffset = 0;

    for(int i = 0; i < NewArray.GetLength(0); i++)
    {
       if(i == min_i) RowOffset = 1;

       for(int j = 0; j < NewArray.GetLength(1); j++)
       {
          if(j == min_j) ColumnsOffset = 1;
          NewArray[i , j] = source[i + RowOffset, j + ColumnsOffset];
       }
       ColumnsOffset = 0;
    }
    return NewArray;
}

int rowsCount = ReadInt("Введите число стобцов:");
int columnsCount = ReadInt("Введите число строк:");
int[,] array = GetRandomArray(rowsCount, columnsCount);
PrintArray(array);
Console.WriteLine();
int[,] result = DeleteMinElement(array);
PrintArray(result);
Console.WriteLine();