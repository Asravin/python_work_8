﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = number.ToString().Length;
    if (count < 3)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
            int a = number / 10;
            int b = a % 10;
        Console.WriteLine(b);
    }
    
