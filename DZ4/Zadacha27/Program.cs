// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите n");
int x = Convert.ToInt32(Console.ReadLine());
int n = (int)Math.Log10(x) + 1;
void SumNumbers(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum = sum + x%10;
        x = x/10;
       
    }
    Console.WriteLine($"Сумма всех цифр числа x равна {sum}");
}
SumNumbers(n);

// int sum = 0;
// for (int i = 1; i <= n; i++)
// {
//    sum = sum + x%10;
//    x = x/10;
// }
// Console.Write($"Сумма всех цифр числа x равна, {sum}");