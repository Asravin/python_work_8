// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа:");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int SumFactorial(int a, int b)
{
    if(b == a) return b;
    return a + SumFactorial(a + 1, b);
}
Console.WriteLine("Сумма элементов = " + SumFactorial(A, B) + " в промежутке от " + A + " до " + B);