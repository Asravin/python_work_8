// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] GetArray = Get3DMassive(2, 2, 2);
for(int i = 0; i < GetArray.GetLength(0); i++)
{
   for(int j = 0; j < GetArray.GetLength(1); j++)
   {
       for(int k = 0; k < GetArray.GetLength(2); k++)
       {
          Console.WriteLine($"{GetArray[i, j, k]} = [{i},{j},{k}]");
       }
       Console.WriteLine();
   }
}

int[,,] Get3DMassive(int a, int b, int c)
{
   int count = 99;
   int[,,] array = new int[a, b, c];
   int[] meaning = new int[count];
   int number = 10;
   for(int i = 0; i < meaning.Length; i++)
   {
       meaning[i] = number++;
   }

   for(int i = 0; i < meaning.Length; i++)
   {
      int random = new Random().Next(0, meaning.Length);
      int temp = meaning[i];
      meaning[i] = meaning[random];
      meaning[random] = temp;
   }

   int index = 0;
   for(int i = 0; i < array.GetLength(0); i++)
   {
      for(int j = 0; j < array.GetLength(1); j++)
      {
        for(int k = 0; k < array.GetLength(2); k++)
        {
           array[i, j, k] = meaning[index++];
        }
      }
   }
   return array;
}