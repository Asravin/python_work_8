// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void GetRandomArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
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

int MinSumElement(int[,] array)
{
    int sum = 0;
    int min_sum = 0;
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) 
            {
                sum += array[i, j];
                min_sum += array[i, j]; 
            }
            else sum += array[i, j]; 
        }
        if (sum < min_sum)
        {
            min_sum = sum;
            min = i;
        }
        sum = 0;
    }
    return min;
   
}


int[,] array = new int[5, 9];
GetRandomArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Строка с наименьшей суммой элементов" +  " № " + MinSumElement(array));