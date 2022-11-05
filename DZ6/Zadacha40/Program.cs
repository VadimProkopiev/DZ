// Задача 40 - HARD необязательная. На вход программы подаются 
// три целых положительных числа. Определить , является ли это 
// сторонами треугольника. Если да, то вывести всю информацию 
// по нему - площадь, периметр, значения углов треугольника в 
// градусах, является ли он прямоугольным, равнобедренным, равносторонним.

Console.WriteLine("Введите первое число ");
double x=Convert.ToInt32 ( Console.ReadLine());
Console.WriteLine("Введите второе число ");
double y=Convert.ToInt32 ( Console.ReadLine());
Console.WriteLine("Введите третье число ");
double z=Convert.ToInt32 ( Console.ReadLine());

if (x>y+z || y>x+z || z>x+y) Console.WriteLine("Такой треугольник не существует");
else Console.WriteLine("Такой треугольник существует");

double FindCorner ()
{
    double alfa = Math.Acos(Math.Abs((Math.Pow(y, 2)+Math.Pow(z, 2)-Math.Pow(x, 2))/(2*z*y)));
    double alfaDeg = alfa*180/Math.PI;
    alfaDeg = Math.Round(alfaDeg, 2);
    double beta = Math.Acos(Math.Abs((Math.Pow(x, 2)+Math.Pow(z, 2)-Math.Pow(y, 2))/(2*z*x)));
    double betaDeg = beta*180/Math.PI;
    betaDeg = Math.Round(betaDeg, 2);
    double gamaDeg = 180 - alfaDeg - betaDeg;
    gamaDeg = Math.Round(gamaDeg, 2);
    Console.WriteLine($"Угол alfa треугольника = {alfaDeg}");
    Console.WriteLine($"Угол beta треугольника = {betaDeg}");
    Console.WriteLine($"Угол gama треугольника = {gamaDeg}");
    if (alfaDeg == 90 || betaDeg == 90 || gamaDeg == 90) Console.WriteLine("Такой треугольник является прямоугольным");
    if (x == y && y == z && z== x) Console.WriteLine("Такой треугольник является равносторонним");
    if (alfaDeg==betaDeg || betaDeg==gamaDeg || gamaDeg==alfaDeg) Console.WriteLine("Такой треугольник является равнобедренным");
    return alfa;
}
void FindParametrs ()
{ 
    double p = (x+y+z)/2; 
    double S = Math.Sqrt(Math.Abs(p*(p-x)*(p-y)*(p-z))); 
    S = Math.Round(S, 2);
    Console.WriteLine($"Площадь треугольника = {S}");
    Console.WriteLine($"Периметр треугольника = {x+y+z}");
  
}
FindCorner();
FindParametrs();