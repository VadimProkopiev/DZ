﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int[] arr = {302, 754, 22, 233, 78, 54};

void PrintArray(int[] array)
{
    int count = array.Length;
    for ( int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
void FindCount(int[] arr)
{
    
    int max = arr[0];
    int min = arr[0];
   for (int i = 0; i < arr.Length; i++)
   {
        if (arr[i]>max) max = arr[i];

        if (arr[i]<min) min = arr[i];

   }
   int dif = max-min;
   
   Console.WriteLine($"Минимальное число - {min}");
   Console.WriteLine($"Максимальное число - {max}");
   Console.WriteLine($"Разница между максимальным и минимальным числами - {dif}");
}

PrintArray(arr);
FindCount(arr);

