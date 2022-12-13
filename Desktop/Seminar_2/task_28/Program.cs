// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
 }
    int product_is_numbered(int number)
    {
        int sum = 1;
        for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            return sum;
    }    
        int N = ReadInt("Введите число N :");
        int result = product_is_numbered(N);
        Console.WriteLine(result);
