// for (int i=0; i<=10;i=i+2)
// Console.Write($"{i}");

// Console.WriteLine("Введите координату x");
// int x=Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine("Введите координату y ");
// int y=Convert.ToInt32 ( Console.ReadLine());
// string res;
// if (x>0 && y>0) res = "Это первая четверть";
// else if (x<0 && y>0) res = "Это вторая четверть";
// else if (x<0 && y<0) res = "Это третья четверть";
// else if (x>0 && y<0) res = "Это четвертая четверть";
// else res = "точка находится на оси";
// Console.WriteLine(res);
// void CheckKoord(int x, int y)    //этот тип функции ничего не возвращает в основную программу, но что-то делает
// {
//     string res;
//     if (x>0 && y>0) res="Это первая четверть";
//     else if  (x<0 && y>0) res="Это вторая четверть";
//     else if  (x<0 && y<0) res="Это третья четверть";
//     else if  (x>0 && y<0) res="Это четвертая четверть";
//     else res = "точка находится на оси";
//     Console.WriteLine(res); 
// }

// try
// {
//     Console.WriteLine("Введите координату x");
//     int xx = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координату y");
//     int yy = Convert.ToInt32(Console.ReadLine());
//     CheckKoord(xx,yy);
// }
// catch 
// {
//     Console.WriteLine("Введены некорректные данные");
// }
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


// Console.WriteLine("Введите номер четверти");
// int x=Convert.ToInt32 ( Console.ReadLine());
// string res;
// if (x>0 && y>0) res = "Это первая четверть";
// else if (x<0 && y>0) res = "Это вторая четверть";
// else if (x<0 && y<0) res = "Это третья четверть";
// else if (x>0 && y<0) res = "Это четвертая четверть";
// else res = "точка находится на оси";
// Console.WriteLine(res);

// Console.WriteLine("Введите номер четверти");
// int num = Convert.ToInt32(Console.ReadLine());


// string res;
// if (num==1) res="x>0 и y>0";
// else if  (num==2) res="x<0 и y>0";
// else if  (num==3) res="x<0 и y<0";
// else if  (num==4) res="x>0 и y<0";
// else res = "нет такой четверти";
// Console.WriteLine(res);

// Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние 
// между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите координату x1");
//  int x1 = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите координату y1");
//  int y1 = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите координату x2");
//  int x2 = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите координату y2");
//  int y2 = Convert.ToInt32(Console.ReadLine());

// int xa = (x1 - x2);
// int ya = (y1 - y2);
// double c =  Math.Pow(xa, 2);
// double b =  Math.Pow(ya, (2));
// double d = Math.Sqrt(c+b);
// Console.Write($"{d}");

// Console.WriteLine("Введите координаты x точки a");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y точки a");
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты x точки b");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y точки b");
// int by = Convert.ToInt32(Console.ReadLine());

// double dist = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
// Console.WriteLine($"Расстояние между двумя точками равно  {dist}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

//  Console.WriteLine("Введите n");
//  int n = Convert.ToInt32(Console.ReadLine());

//  for (int i = 1; i <= n; i++)
//  Console.Write($"{i*i} ");

