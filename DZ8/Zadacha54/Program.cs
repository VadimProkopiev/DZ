// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Fillimageay(int m, int n)
{
    int[,] mat = new int[m,n];
    for (int i=0;i<mat.GetLength(0);i++)
    {
        for (int j=0;j<mat.GetLength(1);j++)
        {
            mat[i,j] = new Random().Next(0, 10);
        }
    }
    Console.WriteLine();
    return mat;
}

void Printimageay(int[,] image)
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


void SelectionSortRow(int[,] image)
{
    for (int i =0; i< image.GetLength(0); i++)
    {
        for ( int j = 0; j < image.GetLength(1) ; j++)
        {
            for (int k = 0; k < image.GetLength(1) - j-1 ;k++) 
                {
                    if (image[i, k] < image[i, k + 1]) 
                    {
                        int t = image[i, k];
                        image[i, k] = image[i, k + 1];
                        image[i, k + 1] = t;
                    }
                }
        }
    }
}




int [,] mas = Fillimageay(m, n);
Printimageay(mas);
Console.WriteLine();


SelectionSortRow(mas);


Printimageay(mas);
