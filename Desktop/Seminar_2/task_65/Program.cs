// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите два числа:");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
if(A > B)
Console.WriteLine("Первое число должно быть меньше второго!!!");
int factorial(int a, int b)
{
    if(b < 0) return -1;
    if(b == a) return a;
    Console.Write(factorial(a, b - 1) + ", ");
    return b;
}
Console.WriteLine(factorial(A, B));