// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
try
{
Console.WriteLine("Введите пятизначное число");
int n=Convert.ToInt32 ( Console.ReadLine());
int NumLen = (int)Math.Log10(n) + 1;
Console.WriteLine($"Количество цифр в числе,  {NumLen}");
if (NumLen <0 && NumLen >=6) Console.WriteLine("Введено число отличное от пятизначного");
int i = 1;
int x = 0;
int y = 0;

if (n>0 && n<100000)
   {
    x = n%10
    y = 
    if 
    x = n%10;
    Console.Write("Тетья цифра, " + x);
    
    Console.Write("bhhbhb, {i}");
    } 
while (i <= NumLen)
{
   n = n/10; 
   
   if (n>99 && n<1000)
   {
    x = n%10;
    Console.Write(n +" ");// Уменьшение числа до 3 символов
    Console.WriteLine("Тетья цифра, " + x);
    break;
   } 
   i++;
}
}
catch 
{
    Console.WriteLine("Введены некорректные данные");
}



