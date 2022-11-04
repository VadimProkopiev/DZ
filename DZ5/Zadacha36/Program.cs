// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateFillArray()
{
    int[] arr = new int[13];
    for (int i=0;i<13;i++) 
    {
        arr[i]= new Random().Next(-100000,100000);
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
        if (count%2 == 0 ) el = el+ el[count]; 
        count++;
    }
    Console.WriteLine(count);
}
int [] arr = CreateFillArray();
FindCount(arr); 

