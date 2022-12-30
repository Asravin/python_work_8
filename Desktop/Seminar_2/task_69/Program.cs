// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите два числа:");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int Exponentiation(int a, int b)
{
    if(b == 0) return 1;
    a = a * Exponentiation(a, b - 1);
    return a;
}
Console.WriteLine($"Число {A} в степени {B} = {Exponentiation(A, B)}");