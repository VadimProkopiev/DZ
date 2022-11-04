// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double [] arr = {302.55 , 750.44, 22.66, 233.66 , 78.64, 54.46};

void PrintArray(double[] array)
{
    int count = array.Length;
    for ( int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
void FindCount(double[] arr)
{
    
    double max = arr[0];
    double min = arr[0];
   for (int i = 0; i < arr.Length; i++)
   {
        if (arr[i]>max) max = arr[i];

        if (arr[i]<min) min = arr[i];

   }

   double dif = max-min;
   dif = Math.Round(dif, 2);
   
   Console.WriteLine($"Минимальное число - {min}");
   Console.WriteLine($"Максимальное число - {max}");
   Console.WriteLine($"Разница между максимальным и минимальным числами - {dif}");
}

PrintArray(arr);
FindCount(arr);

