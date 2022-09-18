// Программа принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите через пробел координаты X, Y и Z точки A:");
string xy = Console.ReadLine();
string[] parts = xy.Split (' ');
int xA = int.Parse(parts[0]);
int yA = int.Parse(parts[1]);
int zA = int.Parse(parts[2]);

Console.WriteLine("Введите через пробел координаты X, Y и Z точки B:");
xy = Console.ReadLine();
parts = xy.Split (' ');
int xB = int.Parse(parts[0]);
int yB = int.Parse(parts[1]);
int zB = int.Parse(parts[2]);

double CubeDiagonal = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));

Console.WriteLine($"Расстояние между этими двумя точками равно {CubeDiagonal:F2} единиц.");