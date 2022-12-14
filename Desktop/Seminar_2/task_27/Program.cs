// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = ReadInt("Введите число :");
int count = number_count(number);
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
        sum_numbers(number, count);
        int number_count(int a)
        {
            int digit = 0;
            while(a > 0)
            {
                a /= 10;
                digit ++;
            }
        return digit;
        }    
            void sum_numbers(int b, int count)
            {
                int sum = 0;
                for(int i =1; i <= count; i++)
                {
                    sum += b % 10;
                    b /= 10;
                }
                Console.WriteLine(sum);
            }
