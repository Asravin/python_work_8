// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 7;
int[] numbers = new int[size];
array_random_numbers(numbers);
Array(numbers);
int sum = 0;
    for (int i = 0; i < numbers.Length; i += 2)
        {
            sum += numbers[i];
        }
Console.WriteLine($"сумма на нечетных позициях {sum}");

void array_random_numbers(int[] numbers)
    {
        for(int i = 0; i < numbers.Length; i++)
           {
                numbers[i] = new Random().Next(-10, 10);
           }
    }

void Array(int[] numbers)
    {
        for(int i = 0; i < numbers.Length; i++)
        Console.Write(numbers[i] + ". ");
    }
Console.WriteLine();