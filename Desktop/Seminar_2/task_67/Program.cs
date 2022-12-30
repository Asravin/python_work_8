// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int TheSumOfTheNumber(int sum)
{
    if(sum == 0) return 0;
    else
    {
        sum = sum % 10 + TheSumOfTheNumber(sum / 10);
    }
    return sum;
}
Console.WriteLine("Сумма цифр" + " " + TheSumOfTheNumber(number));