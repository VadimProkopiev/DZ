// Посчитаем сумму всех целых цифр от 1 до n, которое вводит пользователь.

// Console.Write ("Введите целое число ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumDigits(int n)
// {
//     int sum =0;
//     while (n>0)
//     {
//         sum=sum+n;
//         n--;
//     }
//     return sum;

// }
// int SumRec(int n)
// {
//     if (n==0) return 0;
//     return n+SumRec(n-1);
// }

// Console.WriteLine(SumDigits(n));
// Console.WriteLine(SumRec(n));
// _______________________________________

// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
// ____
//  Console.Write ("Введите целое число ");
// int n = Convert.ToInt32(Console.ReadLine());

// string SumRec(int n)
// {
//     if (n==0) return " ";
//     return SumRec(n-1) + " " + Convert.ToString(n);
    
// }

// Console.WriteLine($" {SumRec(n)} ");

// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

//  Console.Write ("Введите целое число M ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите целое число N ");
// int n = Convert.ToInt32(Console.ReadLine());

// string SumRec(int n)
// {
//     if (n==m) return " ";
//     return SumRec(n-1) + "  " + Convert.ToString(n);
    
// }

// Console.WriteLine($" {SumRec(n)} ");
// _____________________________________________

// Задача 67: Напишите программу, которая будет принимать на 
// вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Write ("Введите целое число N ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumRec(int n)
// {
//     if (n==0) return 0;
//     return SumRec(n/10) + (n%10);
// }

// Console.WriteLine(SumRec(n));
// __________________________________________________________________

// Задача 69: Напишите программу, которая на вход 
// принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.Write ("Введите целое число A ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите целое число B ");
// int b = Convert.ToInt32(Console.ReadLine());

// int SumRec(int a , int b)
// {
//     if (b==0) return 1;
//     return  a*SumRec(a,b-1);
// }

// Console.WriteLine(SumRec(a,b));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write ("Введите целое число m ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите целое число n ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumRec(int m , int n)
// {
//     if (m==0) return n+1;
//     if (m>0 && n==0) return SumRec(m-1, 1);
//     if (m>0 && n>0) return SumRec(m-1, SumRec(m, n-1));
//     return 0;
// }

// Console.WriteLine(SumRec(m,n));
