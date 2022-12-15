//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

const int LENGTH = 8;
const int LEFTRANGE = -5;
const int RIGHTRANGE = 5;
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
int[] revers_array(int[]arr)
{
        int count = 0;
            for ( int i = 0; i < LENGTH; i++)
            {
                count = arr[i];
                arr[i] = count * -1;
            }
        return arr;
}
int[] massive = get_random_array(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
int[] revers_massive = revers_array(massive);
Console.WriteLine($"{string.Join(", ", revers_massive)}");
