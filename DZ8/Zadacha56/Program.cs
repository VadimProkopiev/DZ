// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
int [,] mas = Fillimageay(m, n);

Console.WriteLine();

void SortSumRow(int[,] mas)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            sum += mas[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        line += mas[index, j] + " ";
    }
    Console.WriteLine($"Строка с минимальной суммой элементов равна {line}. индекс = {index}, строка {index+1} ");
}

SortSumRow(mas);


Printimageay(mas);
