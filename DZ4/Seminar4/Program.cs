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

// Console.WriteLine("Введите любое число, ");
// double n = Convert.ToInt32 (Console.ReadLine());
// int NumLen = (int)Math.Log10(n) + 1;
// Console.WriteLine($"Количество цифр в числе,  {NumLen}");

// Console.WriteLine("Введите 5ти значное число: ");
// int x=Convert.ToInt32(Console.ReadLine()) ;

// // определение длины числа
// int i=1;
// // int j=1;
// int n=1;
// int iter;
// // int pol=0; 
//       while ((x /= 10) >= 1) 
//     i=i+1;
//     Console.WriteLine($"Число символов {i}");
// //Длина числа равна i;

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// SumNumbers(num);
// ___________
// // int razryad=0;
// // while (num % 10 >0)
// // {
// //     razryad++;
// //     num/=10;
// // }
// // Console.WriteLine(razryad);
// ___________
// void SumNumbers(int num)
// {
//     int razryad=0;
//     while (num % 10 >0)
//     {
//         razryad++;
//         num/=10;
//     }
//     Console.WriteLine(razryad);
// }
// ___________________________________________________________________

// Задача 28: Напишите программу, которая принимает на вход число N
//  и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// // int sum=0;
// // for (int i =1; i<=n;i++) sum=sum+i;
// // Console.WriteLine($"Сумма всех чисел от 1 до {n} равна {sum}");

// void SumNumbers(int n)
// {
//     int a = 1;
//     for (int i =1; i<=n; i++) 
//         a=a*i;
//     Console.WriteLine($"Произведение всех чисел от 1 до {n} равна {a}");
// }

// SumNumbers(n);
// _______________________
// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// void FillArray(int[] collection)
// {
//     int lenght = 8;
//     int index = 0;
//     while (index<lenght)
// {
//     collection[index] = new Random().Next(0,2);
//     index++;
// }
// }
// void PrintArray(int[] array)
// {
//     int count = 8;
//     for ( int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// FillArray(array);
// PrintArray(array);
// int p=0;
// int e=0;
// int count = 8;
// for (int i=0; i<count; i++)
// { 
//     if (array[i] == 1) p =p+1;
// }
// for (int i=0; i<count; i++)
// { 
//     if (array[i] == 0) e =e+1;
// }
// if (p>e) Console.WriteLine($"Колличество единиц больше нулей, {p}");
// else Console.WriteLine($"Колличество нулей больше единиц, {e}");
// ______________________________________