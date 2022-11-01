// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B");
int b = Convert.ToInt32(Console.ReadLine());
void MathPow(int a)
{
    for (int i = 1; i<2; i++)
    {
    Console.WriteLine($"{a}^{b} = {(long)Math.Pow(a, b):N0}");
    }
}
MathPow(a);