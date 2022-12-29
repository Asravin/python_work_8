// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] GetArray = new int[4, 4];
int i = 0;
int j = 0;
int most = 1;
while(most <= GetArray.GetLength(0) * GetArray.GetLength(1))
{
    GetArray[i, j] = most;
    most++;
    if(i <= j + 1 && i + j < GetArray.GetLength(1) - 1)
    j++;
    else if(i < j && i + j >= GetArray.GetLength(0) - 1)
    i++;
    else if(i >= j && i + j > GetArray.GetLength(1) - 1)
    j--;
    else
    i--;
}

PrintArray(GetArray);
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]  + " ");
        }
        Console.WriteLine();
    }
}

