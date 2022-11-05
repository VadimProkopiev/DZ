// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.
Console.WriteLine("Введите количество строк массива m, ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество солбцов массива n, ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            image[i, j] = new Random().Next(1, 100);
        }
    }
}
int[,] matrix = new int[m, n];
int[,] matr = matrix;

FillArray(matrix);
Console.WriteLine();
PrintArray(matr);
void FindMaxMinNumber()
{
    int max = matr[0, 0];
    int min = matr[0, 0];
    int maxindi = 0;
    int maxindj = 0;
    int minindi = 0;
    int minindj = 0;
    for (int i = 0; i < m ; i++)
    {
        for (int j = 0; j < n ; j++)
        {
            if (matr[i, j] > max)
            {
                max = matr[i, j];
                maxindi = i;
                maxindj = j;
            }
                
        }
    }

    for (int i = 0; i < m ; i++)
    {
        for (int j = 0; j < n ; j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                minindi = i;
                minindj = j;
            }
                
        }
    }

    Console.WriteLine($"Минимальное число - {min}");
     Console.WriteLine($"Индекс максимального числа - m = {minindi}, n = {minindj}");
    Console.WriteLine($"Максимальное число - {max}");
    Console.WriteLine($"Индекс максимального числа - m = {maxindi}, n = {maxindj}");
    
}
FindMaxMinNumber();
