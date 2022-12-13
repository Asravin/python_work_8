// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)

Console.WriteLine("Ведите номер четверти:");
int a = Convert.ToInt32(Console.ReadLine());
    if (a == 1)
    {
        Console.WriteLine("x > 0; y > 0");
    }
        if (a == 2)
        {
            Console.WriteLine("x < 0; y > 0");
        }
            if (a == 3)
            {
                Console.WriteLine("x < 0; y < 0");
            }
                if (a == 4)
                {
                    Console.WriteLine("x > 0; y < 0");
                }
                    else if (a < 1 || a > 4)
                    {
                        Console.WriteLine("Ошибка, такой четверти нет");
                    }
