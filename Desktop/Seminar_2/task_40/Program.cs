// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Ведите стороны A, B, C:");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());

if((A + B > C) && (A + C > B) && (B + C > A))
{
    Console.WriteLine("Это треугольник");
}

else
{
     Console.WriteLine("Это не треугольник");
}