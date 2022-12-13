// Напишите программу, с в 2D пространстве.
// A (3,6); B (2,1) -> 5,10
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты x(1):");
int x1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y(1):");
int y1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x(2):");
int x2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y(2):");
int y2=Convert.ToInt32(Console.ReadLine());

double res=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
Console.WriteLine($"Итог:{res:f2}");