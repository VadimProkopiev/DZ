// Задача 30: - HARD необязательная 
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.. 
// Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.
int[] array = new int[8];
void FillArray(int[] collection)
{
    int lenght = 8;
    int index = 0;
    while (index<lenght)
{
    collection[index] = new Random().Next(0,2);
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
int p=0;
int e=0;
int count = 8;
for (int i=0; i<count; i++)
{ 
    if (array[i] == 1) p =p+1;
}
for (int i=0; i<count; i++)
{ 
    if (array[i] == 0) e =e+1;
}
if (p>e) Console.WriteLine($"Колличество единиц больше нулей, {p}, True ");
else Console.WriteLine($"Колличество нулей больше единиц, {e}, False ");