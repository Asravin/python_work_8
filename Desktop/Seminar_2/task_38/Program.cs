// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 7;
int[] numbers = new int[size];
array_random_numbers(numbers);
Array(numbers);
int max = numbers[0];
int min = numbers[0];
    for(int i = 0; i < numbers.Length; i++)
       {
            if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            else if(numbers[i] < min)    
                {
                    min = numbers[i];
                }
       }

Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
Console.WriteLine(max - min);

void array_random_numbers(int[] array)
    {
        for(int i = 0; i < array.Length; i++)  
            {
                array[i] = new Random().Next(1, 100);
            }
    }

void Array(int[] array) 
    {
        for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ". ");
            } 
        Console.WriteLine();   
    }  