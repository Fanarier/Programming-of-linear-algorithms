using System;
using System.Linq.Expressions;
//Программирование линейных алгоритмов
//Плотников Кирилл; Группа:22-ИСП-2/2
//Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника.

try
{


Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Введите x1:");
Double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y1:");
Double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите x2:");
Double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y2:");
Double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите x3:");
Double x3 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y3:");
Double y3 = double.Parse(Console.ReadLine());

double S, P;

Console.ForegroundColor = ConsoleColor.Blue;

S = 0.5 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));
Console.WriteLine("Площадь треугольника равна:");
Console.WriteLine($"{S:F2}");


double AB, BC, AC;
AB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
BC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
AC = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));

Console.ForegroundColor = ConsoleColor.Red;

P = AB + BC + AC;
Console.WriteLine("Периметр треугольника равен:");
Console.WriteLine($"{P:F2}");

Console.ForegroundColor = ConsoleColor.Green;

}
catch (Exception ex)
{ Console.WriteLine(ex.ToString()); }   