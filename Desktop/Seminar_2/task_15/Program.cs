// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7:");
int number = Convert.ToInt32(Console.ReadLine());
if (number >0 && number <6 )
{
    Console.WriteLine("НЕТ:");
}
if (number >=6 && number <=7 )
{
    Console.WriteLine("ДА:");
}
if (number <= 0 && number >=8)
{
    Console.WriteLine("Такого дня нет:");
}
    
