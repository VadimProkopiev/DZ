// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

double[,] Fillimageay(int m, int n)
{
    double[,] imageay = new double[m,n];
    for (int i=0;i<imageay.GetLength(0);i++)
    {
        for (int j=0;j<imageay.GetLength(1);j++)
        {
            imageay[i,j] = new Random().Next(0, 10);
        }
    }
    Console.WriteLine();
    return imageay;
}

void Printimageay(double[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            image[i, j] = Math.Round(image[i, j], 1);
            Console.Write($"{image[i, j]} \t");
        }
        Console.WriteLine();
    }
}


double [,] FindArithmeticMean(double [,] image)
{
    for (int j = 0; j < image.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < image.GetLength(0); i++)
    {
        sum = sum + image[i, j];
    }
    Console.WriteLine($"Среднее арифметическое каждого столбца = { sum / image.GetLength(0)}");
}
    return image;
}
double[,] mas = Fillimageay(m, n);
Printimageay(mas);
Console.WriteLine();
FindArithmeticMean(mas);
