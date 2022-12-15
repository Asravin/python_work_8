// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 20);
}
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

for (int j = 0; j < array.Length; j++)
{
    if (array[j] == number) count = 1;
}
if (count > 0) Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");