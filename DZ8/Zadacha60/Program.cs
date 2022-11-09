// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите высоту трехмерного массива");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину трехмерного массива");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите глубину трехмерного массива");
int z = Convert.ToInt32(Console.ReadLine());


int[,,] Fillimageay(int x, int y, int z)
{
    int[,,] mat = new int[x,y,z];
    for (int i=0;i<mat.GetLength(0);i++)
    {
        for (int j=0;j<mat.GetLength(1);j++)
        {
            for (int k=0;k<mat.GetLength(2);k++)
            {
               mat[i,j,k] = new Random().Next(0, 10); 
            }
            
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
            for (int k=0;k<mat.GetLength(2);k++)
            {
               Console.Write($"{image[i, j, k]} \t");
            }
            
        }
        Console.WriteLine();
    }
}
int [,,] mas = Fillimageay(x,y,z);

Console.WriteLine();

// void SortSumRow(int[,] mas)
// {
//     int index = 0, minsum = 0;
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < mas.GetLength(1); j++)
//         {
//             sum += mas[i, j];
//         }
//         Console.WriteLine($"Сумма {i + 1} строки = {sum}");
//         if (i == 0)
//         {
//             minsum = sum;
//         }
//         else if (sum < minsum)
//         {
//             minsum = sum;
//             index = i;
//         }
//     }
//     string line = string.Empty;
//     for (int j = 0; j < mas.GetLength(1); j++)
//     {
//         line += mas[index, j] + " ";
//     }
//     Console.WriteLine($"Строка с минимальной суммой элементов равна {line}. индекс = {index} ");
// }

// SortSumRow(mas);


// Printimageay(mas);
