// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum=0;
// for (int i =1; i<=n;i++) sum=sum+i;
// Console.WriteLine($"Сумма всех чисел от 1 до {n} равна {sum}");

void SumNumbers(int x)
{
    int sum=0;
    for (int i =1; i<=x;i++) 
        sum=sum+i;
    Console.WriteLine($"Сумма всех чисел от 1 до {x} равна {sum}");
}

int SumNumbers2(int x)
{
    int sum=0;
    for (int i =1; i<=x;i++) 
        sum=sum+i;
    return sum;
}


Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
//SumNumbers(n);
Console.WriteLine(SumNumbers2(n));
