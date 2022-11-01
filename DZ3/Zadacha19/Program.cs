// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
try
{
Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32 (Console.ReadLine());
int NumLen = (int)Math.Log10(n) + 1;
Console.WriteLine($"Количество цифр в числе,  {NumLen}");
if (NumLen == 5) Console.WriteLine("Введено пятизначное число");
else Console.WriteLine("Число не пятизначное");
int a1 = n/10000;

int a2 = n/1000 - n/10000*10;
int a3 = n%100/10; 
int a4 = n%10;

if (a1==a4 && a2==a3) Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не является палиндромом");
}
catch
{
    Console.WriteLine("Вы ввели некорhетный данные"); 
}