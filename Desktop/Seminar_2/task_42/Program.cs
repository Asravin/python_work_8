// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
print_binary_view(number);
void print_binary_view(int N)
{
    if(N <= 0) return;
    print_binary_view(N / 2);
    Console.Write(N % 2);
    
}
