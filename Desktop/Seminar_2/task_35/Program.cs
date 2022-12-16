// Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int number = 123;
int[] massive = new int[number];
Random range = new Random();
    for (int i = 0; i < massive.Length; i++)
        {
            massive[i] = range.Next(1, 150);
            Console.Write($"{massive[i],4}");
        }
int count = 0;
    for(int i = 0; i < massive.Length; i++)
        {
            if(massive[i] >= 10 && massive[i] <= 99)
            count++;
        } 
Console.WriteLine();  
Console.WriteLine(count);