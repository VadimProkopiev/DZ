// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateFillArray()
{
    int[] arr = new int[6];
    for (int i=0;i<6;i++) 
    {
        arr[i]= new Random().Next(-10000,10000);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return arr;
}
void FindCount(int[] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2 == 1)  count =  count + arr[i];
               
    }
    Console.WriteLine(count);
     
}
int [] arr = CreateFillArray();

FindCount(arr); 

