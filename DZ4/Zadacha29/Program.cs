// Задача 29: Напишите программу, которая задаёт массив из 8
// элементов с клавиатуры и выводит массив на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] array = new int[8];
void FillArray(int[] collection)
{
    int lenght = 8;
    int index = 0;
    while (index<lenght)
{
    Console.Write($"Введите число {index+1} массива. ");
    collection[index] = Convert.ToInt32 (Console.ReadLine());;
    index++;
}
}
void PrintArray(int[] array)
{
    int count = 8;
    for ( int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillArray(array);
PrintArray(array);
