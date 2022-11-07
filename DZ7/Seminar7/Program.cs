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
            array[i,j]= new Random().Next(1, 568) ;
    }
    return array;
}

void PrintArray(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j]<10 && image[i, j]>=0) Console.Write($"{image[i, j]} \t");
            else if (image[i, j]<-9) Console.Write($"{image[i, j]} ");
            else Console.Write($"{image[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] mas=FillArray(m,n);
PrintArray(mas);