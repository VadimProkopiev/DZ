// for (int i=0; i<=10;i=i+2)
// Console.Write($"{i}");

Console.WriteLine("Введите координату x");
int x=Convert.ToInt32 ( Console.ReadLine());
Console.WriteLine("Введите координату y ");
int y=Convert.ToInt32 ( Console.ReadLine());
string res;
if (x>0 && y>0) res = "Это первая четверть";
else if (x<0 && y>0) res = "Это вторая четверть";
else if (x<0 && y<0) res = "Это третья четверть";
else if (x>0 && y<0) res = "Это четвертая четверть";
else res = "точка находится на оси";
Console.WriteLine(res);
