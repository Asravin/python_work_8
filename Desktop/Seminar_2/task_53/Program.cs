// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
int[,] array = new int[4, 4];
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 9);
        Console.Write(array[i , j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int temp = 0;
for(int i = 0; i < array.GetLength(1); i++)
{
    temp = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) -1, i] = array[0, i];
    array[0, i] = temp;
}
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i , j] + " "); 
    }
    Console.WriteLine();
}