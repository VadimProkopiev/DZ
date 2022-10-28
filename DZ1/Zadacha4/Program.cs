// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите натуральное число ");
int x=Convert.ToInt32 ( Console.ReadLine());
Console.WriteLine("Введите натуральное число ");
int y=Convert.ToInt32 ( Console.ReadLine());
Console.WriteLine("Введите натуральное число ");
int z=Convert.ToInt32 ( Console.ReadLine());
if (x>y) 
{
    if (x>z) Console.WriteLine($"Максимальное число = {x}");
}
if (y>x)
{
    if (y>z) Console.WriteLine($"Максимальное число = {y}");
} 
if (z>x)
{
    if (z>y) Console.WriteLine($"Максимальное число = {z}");
}
    