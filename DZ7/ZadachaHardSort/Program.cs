// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
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

int [,] mas = Fillimageay(m, n);
Printimageay(mas);
Console.WriteLine();
int[,] Fillimageay(int m, int n)
{
    int[,] image = new int[m,n];
    for (int i=0;i<image.GetLength(0);i++)
    {
        for (int j=0;j<image.GetLength(1);j++)
        {
            image[i,j] = new Random().Next(0, 10);
        }
    }
    Console.WriteLine();
    return image;
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
            for (int k = 0; k < image.GetLength(1)-jgit-1 ;k++) 
                {
                    for (int l =0; l< image.GetLength(1);l++)
                    {
                       if (image[k, l] > image[k+1, l]) 
                        {
                           int t = image[k, l];
                           image[k, l] = image[k+1, l];
                           image[k + 1, l ] = t;
                        } 
                       
                    }
                    if (image[i, k] > image[i, k + 1]) 
                    {
                        int t = image[i, k];
                        image[i, k] = image[i, k + 1];
                        image[i, k + 1] = t;
                    }
                    
                    
                }
        }
    }
}



void SelectionSortCol(int[,] image)
{
    for (int j =0; j< image.GetLength(1); j++)
    {
        for ( int i = 0; i < image.GetLength(0) ; i++)
        {
            for (int k = 0; k < image.GetLength(1) - i-1 ;k++) 
                {
                   for (int l =0; l< image.GetLength(1);l++)
                    if (image[k, l] > image[k+1, l]) 
                    {
                        int t = image[k, l];
                        image[k, l] = image[k+1, l];
                        image[k + 1, l ] = t;
                    }
                }
        }
    }
}
void transpose(int[, ] image)
    {
        for (int i = 0; i < image.GetLength(0); i++) 
        {
            for (int j = i + 1; j > image.GetLength(1); j++) 
            {
                int temp = image[i, j];
                image[i, j] = image[j, i];
                image[j, i] = temp;
            }
        }
    }


for (int i = 0; i < m*n; i++)
{
    
    SelectionSortRow(mas);
    SelectionSortRow(mas);
    // transpose(mas);
    // SelectionSortCol(mas);

          
}
Console.WriteLine();
Printimageay(mas);

// int z = m*n;
// int[] mas1 = new int[z];

// for (int i = 0; i < 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         mas1[z++] = mas[i, j];
       
//     }
// }
                
// Console.WriteLine(mas1);