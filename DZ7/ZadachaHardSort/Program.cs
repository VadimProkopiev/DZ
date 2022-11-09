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
            for (int k = 0; k < image.GetLength(1) -j-1 ;k++) 
                {
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
void transpose(int[, ] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++) 
        {
            for (int j = i + 1; j > mat.GetLength(1); j++) 
            {
                int temp = mat[i, j];
                mat[i, j] = mat[j, i];
                mat[j, i] = temp;
            }
        }
    }

int [,] mas = Fillimageay(m, n);
Printimageay(mas);
Console.WriteLine();

for (int i = 0; i < m*n; i++)
{
    
    SelectionSortCol(mas);
   
    SelectionSortRow(mas);
          
}
Console.WriteLine();
Printimageay(mas);
