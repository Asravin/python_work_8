// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

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

void PrintRepeats(int[,] array)
{
    int[] count = new int[10];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            count[array[i, j]]++;
        }
    }
    for(int i = 0; i < count.Length; i++)
    {
        if(count[i] > 0)
        {
            Console.WriteLine($"Элемент {i} повторяется {count[i]} раз");
        }
    }
}

int rowsCount = ReadInt("Введите число стобцов:");
int columnsCount = ReadInt("Введите число строк:");
int[,] array = GetRandomArray(rowsCount, columnsCount);
PrintArray(array);
Console.WriteLine();
PrintRepeats(array);
Console.WriteLine();