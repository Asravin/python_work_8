// Решение задачи №10 с помощью функции "MakeArray"

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = number.ToString().Length;
Console.Write(MakeArray(number));
int MakeArray(int a)
{
int result = 0;
    if (count <3 || count >3)
    {
        Console.Write("Введите трехзначное число:");
    }
    else
    {
        result = ((a  / 10) % 10);
    }
return result;
}