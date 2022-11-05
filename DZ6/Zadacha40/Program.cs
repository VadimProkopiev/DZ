// Задача 40 - HARD необязательная. На вход программы подаются 
// три целых положительных числа. Определить , является ли это 
// сторонами треугольника. Если да, то вывести всю информацию 
// по нему - площадь, периметр, значения углов треугольника в 
// градусах, является ли он прямоугольным, равнобедренным, равносторонним.

 Console.WriteLine("Введите первое число ");
int x=Convert.ToInt32 ( Console.ReadLine());
Console.WriteLine("Введите второе число ");
int y=Convert.ToInt32 ( Console.ReadLine());
Console.WriteLine("Введите третье число ");
int z=Convert.ToInt32 ( Console.ReadLine());

if (x>y+z || y>x+z || z>x+y) Console.WriteLine("Такой треугольник не существует");
else Console.WriteLine("Такой треугольник существует");
{ 
    int p = (x+y+z)/2;                                
    Console.WriteLine($"Площадь треугольника =, {double S = Math.Sqrt(p*(p-x)*(p-y)*(p-z));}");//S=√(p·(p-a)·(p-b)·(p-c))
    Console.WriteLine($"Периметр треугольника =, {x+y+z}");
}