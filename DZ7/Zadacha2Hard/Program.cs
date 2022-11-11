// Задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара.
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) ,
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей.
// Перемешать случайным образом элементы массива, причем чтобы каждый гарантированно
// переместился на другое место и выполнить это за m*n / 2 итераций. То есть если массив три на четыре,
// то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

if (m * n % 2 == 0)
{
    Console.WriteLine("Количество элементов четное.");
    int[,] mas = Fillimageay(m, n);
    Printimageay(mas);
    Console.WriteLine();

    int[,] Fillimageay(int m, int n)
    {
        int[,] image = new int[m, n];
        for (int i = 0; i < image.GetLength(0); i++)
        {
            for (int j = 0; j < image.GetLength(1); j++)
            {
                image[i, j] = new Random().Next(0, 10);
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
    void SelectionSortRow(int[,] mas)
    {
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                for (int k = 0; k < mas.GetLength(1) - j - 1; k++)
                {
                    if (mas[i, k] < mas[i, k + 1])
                    {
                        int t = mas[i, k];
                        mas[i, k] = mas[i, k + 1];
                        mas[i, k + 1] = t;
                    }
                }
            }
        }
    }
    SelectionSortRow(mas);
    Printimageay(mas);
}
else
    Console.WriteLine("Количество элементов нечетное.");
