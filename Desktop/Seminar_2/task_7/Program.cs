// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = number.ToString().Length;
        int a = number % 10;
            int b = a % 10;
Console.WriteLine(b);
