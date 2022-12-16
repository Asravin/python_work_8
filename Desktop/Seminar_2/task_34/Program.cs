// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте массив :");
    int S = Convert.ToInt32(Console.ReadLine());
    int[] N = new int[S];
    int count = 0;
array_random_numbers(N);
    Array(N);
        for (int i = 0; i < N.Length; i++)
            {
                if (N[i] % 2 == 0)
                count++;
            }

Console.WriteLine(count);
    void array_random_numbers(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
               {  
                    array[i] = new Random().Next(100, 1000);
               }
        
        }

    void Array(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            } 
    Console.WriteLine("Количество четных чисел:");
    }  