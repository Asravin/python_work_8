// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Ведите три числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if(a > b && a > c)
{
Console.WriteLine(a);
}
if(b > a && b > c)
{
Console.WriteLine(b);
}
if(c > b && c > a)
{
Console.WriteLine(c);
}