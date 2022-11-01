// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum=0;
// for (int i =1; i<=n;i++) sum=sum+i;
// Console.WriteLine($"Сумма всех чисел от 1 до {n} равна {sum}");

// void SumNumbers(int x)
// {
//     int sum=0;
//     for (int i =1; i<=x;i++) 
//         sum=sum+i;
//     Console.WriteLine($"Сумма всех чисел от 1 до {x} равна {sum}");
// }

// int SumNumbers2(int x)
// {
//     int sum=0;
//     for (int i =1; i<=x;i++) 
//         sum=sum+i;
//     return sum;
// }


// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// //SumNumbers(n);
// Console.WriteLine(SumNumbers2(n));


// Задача 26: Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите любое число, ");
int n = Convert.ToInt32 (Console.ReadLine());
int NumLen = (int)Math.Log10(n) + 1;
Console.WriteLine($"Количество цифр в числе,  {NumLen}");