// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());
int factorial(int n)
{
    if(n < 0) return -1;
    if(n == 1) return 1;
    Console.Write(factorial(n - 1) + ", ");
    return n;
}
Console.WriteLine(factorial(N));
