// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateFillArray()

{
    int[] arr = new int[13];
    for (int i=0;i<13;i++) 
    {
        arr[i]= new Random().Next(99,1000);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return arr;
}

void FindCount(int[] arr)
{
    int count=0;
    foreach (int el in arr)
    {
        if (el%2 == 0 ) count++;
    }
    Console.WriteLine(count);
}
int [] arr = CreateFillArray();
FindCount(arr); 

