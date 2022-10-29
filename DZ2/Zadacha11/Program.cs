// Задача 11 HARD - необязательная: Напишите программу, 
// которая принимает на вход целое число любой разрядности число и удаляет вторую цифру слева направо этого
// числа. И, конечно же, через строку решать нельзя.

int x=new Random().Next(10, 100000000);
Console.WriteLine(x);
int main();
{
    unsigned int x;
    scanf("%u", &x);
    if (x<=99)
       return -1;
    while (x>999) x/=10;
    Console.WriteLine("%u");
    return 0;
}
// int x2=x/2
// if (x
// for (int i = 1; i < 3; i++) Console.WriteLine(i);
// {
//     int a1 = x % 10;
//     int a3 = x / 100;
//     int new_num = a3 * 10 + a1;

// Console.WriteLine($"Было {x}, стало {new_num}"); 
// }

//    for (int i = 1; i < 10; i++)
// {
//     for (int j = 1; j < 10; j++)
//     {
//         Console.Write($"{i * j} \t");
//     }
//     Console.WriteLine();
// }