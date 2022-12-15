// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] get_random_array(int length, int left_range, int right_range)
    {  
        int[] array = new int[length];
        Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(left_range, right_range + 1);
            }
        return array;
    }
(int, int) sum_positive_and_negative(int[] array)
    {
        int sum_positive = 0;
        int sum_negative = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > 0)
            {
                sum_positive += array[i];
            }
                else 
                {
                    sum_negative += array[i];
                }
        }
        return(sum_positive, sum_negative);   
    }
const int LENGTH = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;
    int[] massive = get_random_array(LENGTH, LEFTRANGE, RIGHTRANGE);
    Console.WriteLine($"{string.Join(", ", massive)}");
        (int sum_p, int sum_n) = sum_positive_and_negative(massive);
        Console.WriteLine($"Сумма положительных элементов = {sum_p}, отрицательных = {sum_n}");