// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int get_sum_to_number (int number)
{
    int sum = 0;
    for(int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
} 
int A = ReadInt("Введите число A :");
int result = get_sum_to_number(A);
Console.WriteLine(result);