//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Ввкдите пятизначное число:");
bool number = true;
int x = Convert.ToInt32(Console.ReadLine());
int c = x.ToString().Length - 1;
string b = x.ToString();

  for (int i = 0; i < c; i++)

    if (b[i] != b[c - i])
      number = false;

    if (number == true)
      Console.Write("ДА");

  else Console.Write("НЕТ");
  
Console.ReadKey();