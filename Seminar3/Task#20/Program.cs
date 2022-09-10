// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.

Console.WriteLine("Введите через пробел координаты X и Y точки A:");
string xy = Console.ReadLine()!;
string[] parts = xy.Split (' ');
int xA = int.Parse(parts[0]);
int yA = int.Parse(parts[1]);

Console.WriteLine("Введите через пробел координаты X и Y точки B:");
xy = Console.ReadLine()!;
parts = xy.Split (' ',',');
int xB = int.Parse(parts[0]);
int yB = int.Parse(parts[1]);

double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));

Console.WriteLine($"Расстояние между этими двумя точками равно {distance:F3} единиц.");