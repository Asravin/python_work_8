//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] random_massive(int length, int left_range, int righr_range)
{
    int[] array = new int[length];
    Random random = new Random();
        for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(left_range, righr_range + 1);
            }
        return array;    
}

void reverse(int[] array)
{
    for(int i =0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = temp;
        }

}
  
const int LENGTH = 5;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 9;

int[] massive = random_massive(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", massive)}]");
Console.WriteLine();
reverse(massive);
Console.WriteLine($"[{string.Join(", ", massive)}]");
    


