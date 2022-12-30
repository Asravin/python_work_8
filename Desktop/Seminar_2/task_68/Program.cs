// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите два числа:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int FunctionOFAckerman = Ackerman(m, n);
int Ackerman(int m, int n)
{
if(m == 0) return n + 1;
else if (n == 0) return Ackerman(m - 1, 1);
else
{
    return Ackerman(m - 1, Ackerman(m, n - 1));
}
}
Console.WriteLine("Функция Аккермана = " + FunctionOFAckerman);
