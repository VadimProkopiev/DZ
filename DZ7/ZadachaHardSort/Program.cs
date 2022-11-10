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
int[] m1 = new int[m*n];
int z=0;
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
        {
            m1[z] = mas[i, j];
            z++;
        } 
}
            
void SelectionSort(int[] m1)
{
    for (int i =0; i< m1.Length-1; i++)
    {
        int minPosition = i;
        for ( int j = i+1; j < m1.Length ; j++)
        {
            if(m1[j] < m1[minPosition]) minPosition = j; 
            
        }

        int temporary = m1[i];
        m1[i] = m1[minPosition];
        m1[minPosition] = temporary;
    }

}
void PrintArray(int[] m1)
{
    for ( int i = 0; i < m1.Length; i++)
    {
        Console.Write($"{m1[i]} ");
    }
    Console.WriteLine();
}

PrintArray(m1);
SelectionSort(m1);
PrintArray(m1);

void PrintArr(int[] m1)
{
    for ( int i = 0; i < m1.Length; i++)
    {
       
       if ((i)%n ==0) Console.WriteLine(); 
       Console.Write($" {m1[i]} \t");
    }
    
}

PrintArr(m1);