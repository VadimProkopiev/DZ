// Задача 50. Напишите программу, которая на вход принимает значение элемента
// в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число которое необходимо найти");
int x = Convert.ToInt32(Console.ReadLine());

double[,] FillArray(int m, int n)
{
    Random rand = new Random();
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(double[,] image)
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

double[,] FindNumber(double[,] image)
{
    int indexi = -1;
    int indexj =-1;

    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == x)
            {
                indexi = i;
                indexj = j;
                Console.Write(
                    $"Данное число {x} есть в массиве на позиции, {indexi}, {indexj}  :"
                );
            }
            
        }
    }
    if (indexi==-1 && indexj ==-1) Console.Write($"Данного числа {x} нет в массиве."); 
    return image;
}
double[,] mas = FillArray(m, n);
PrintArray(mas);
Console.WriteLine();
FindNumber(mas);
