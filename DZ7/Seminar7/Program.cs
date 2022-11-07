// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j]= new Random().Next(-30,31);
//     }
//     return array;
// }

// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//             // if (image[i, j]<10 && image[i, j]>=0) Console.Write($"{image[i, j]} \t");
//             // else if (image[i, j]<-9) Console.Write($"{image[i, j]} ");
//             // else Console.Write($"{image[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] mas=FillArray(m,n);
// PrintArray(mas);

//______________________________________________________________
// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j]= j+i;
//     }
//     return array;
// }

// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//             // if (image[i, j]<10 && image[i, j]>=0) Console.Write($"{image[i, j]} \t");
//             // else if (image[i, j]<-9) Console.Write($"{image[i, j]} ");
//             // else Console.Write($"{image[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] mas=FillArray(m,n);
// PrintArray(mas);
// __________________________________________________________
// Задача HARD SORT.

// Задайте двумерный массив из целых чисел. 
// Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10
//  Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j]= new Random().Next(1, 568) ;
//     }
//     return array;
// }

// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if (image[i, j]<10 && image[i, j]>=0) Console.Write($"{image[i, j]} \t");
//             else if (image[i, j]<-9) Console.Write($"{image[i, j]} ");
//             else Console.Write($"{image[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] mas=FillArray(m,n);
// PrintArray(mas);
// __________________________________________________________________
// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса не чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
// _________
// Console.WriteLine("Введите количество строк"); 
// int m = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите количество столбцов"); 
// int n = Convert.ToInt32(Console.ReadLine()); 
 
// int[,] FillArray(int m, int n) 
// { 
// int[,] array = new int[m,n]; 
// for (int i=0;i<array.GetLength(0);i++) 
// { 
// for (int j=0;j<array.GetLength(1);j++) 
// array[i,j]= new Random().Next(0,10); 
// } 
// return array; 
// } 
 
// void PrintArray(int[,] image) 
// { 
// for (int i = 0; i < image.GetLength(0); i++) 
// { 
// for (int j = 0; j < image.GetLength(1); j++) 
// { 
// Console.Write($"{image[i, j]} \t"); 
// } 
// Console.WriteLine(); 
// } 
// } 
 
// int[,] mas=FillArray(m,n); 
// PrintArray(mas); 
// Console.WriteLine(); 
 
// int[,] SQArray(int [,] array) 
// { 
// for (int i=1;i<array.GetLength(0);i=i+2) 
// { 
// for (int j=1;j<array.GetLength(1);j=j+2) 
// array[i,j]= array[i,j]* array[i,j]; 
// } 
// return array; 
// } 
// int[,] temp = SQArray (mas); 
// PrintArray (temp); 
// ________________
// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//         {
//             array[i,j]= new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if (image[i, j]<10 && image[i, j]>=0) Console.Write($"{image[i, j]}  \t");
//             else if (image[i, j]<-9) Console.WriteLine($"{image[i, j]}  ");
//             else Console.Write($"{image[i, j]}   ");
//         }
//         Console.WriteLine();
//     }
// }
// // void SelectionSort(int[,] array)
// // {
// //     for (int i =1; i< array.GetLength(0); i+=2)
// //     {
// //         for ( int j = 1; j < array.GetLength(1) ; j+=2)
// //         {
// //             array[i,j]=array[i,j]*array[i,j];
// //         }
// //     Console.WriteLine();
// //     }
// // }

// int[,] Replacey(int [,] array)
// {
//     // int[,] array = new int[m,n];
//     for (int i=1;i<array.GetLength(0);i=i+2)
//     {
//         for (int j=1;j<array.GetLength(1);j=j+2)
//             array[i,j]= array[i,j]*array[i,j];
//     }
//     Console.WriteLine();
//     return array;
// }
// // int[,] mas=FillArray(m,n);
// // PrintArray(mas);
// // SelectionSort(mas);
// // // Replacey(mas);
// // PrintArray(mas);
// int[,] mas=FillArray(m,n);
// Console.WriteLine();
// Console.WriteLine("Сформирован массив:");
// PrintArray(mas);
// Console.WriteLine();
// Console.WriteLine("Новый массив:");
// Replacey(mas);
// PrintArray(mas);
// ____________________

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
Console.WriteLine("Введите количество строк"); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов"); 
int n = Convert.ToInt32(Console.ReadLine()); 
 
int[,] FillArray(int m, int n) 
{ 
 int[,] array = new int[m,n]; 
 for (int i=0;i<array.GetLength(0);i++) 
 { 
 for (int j=0;j<array.GetLength(1);j++) 
 array[i,j]= new Random().Next(0,10); 
 } 
 return array; 
} 
 
void PrintArray(int[,] image) 
{ 
 for (int i = 0; i < image.GetLength(0); i++) 
 { 
 for (int j = 0; j < image.GetLength(1); j++) 
 { 
 Console.Write($"{image[i, j]} \t"); 
 } 
 Console.WriteLine(); 
 } 
} 
 
int[,] mas=FillArray(m,n); 
PrintArray(mas); 
Console.WriteLine(); 
 
int SumArray(int [,] array) 
{ 
 int sum = 0; 
 for (int i=0;i<array.GetLength(0);i++) 
 { 
 for (int j=0;j<array.GetLength(1);j++) 
 if (i==j) sum = sum + array [i,j]; 
 } 
 return sum; 
} 
Console.WriteLine ($"Сумма чисел главной диагонали равна: "+ SumArray(mas));