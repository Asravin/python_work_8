// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = {6, 7, 3, 6};
int[] array1 = new int [array.Length / 2 + array.Length % 2];
    for(int i = 0; i < array1.Length; i++)
    {
        array1[i] = array[i] * array[array.Length - 1 - i];
           if(i == array.Length - i -1)
           {
                array1[i] = array[i];
           }    
    }
Console.WriteLine(string.Join(", ", array1));