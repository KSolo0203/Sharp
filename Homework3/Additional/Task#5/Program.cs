// Пользователь вводит координаты x, y точки на плоскости.
// Программа печатает расстояние от начала координат (0, 0) до точки (x, y).

Console.WriteLine("Введите через пробел координаты X и Y");
string xy = Console.ReadLine();
string[] parts = xy.Split (' ');
int xA = int.Parse(parts[0]);
int yA = int.Parse(parts[1]);

int x0 = 0; int y0 = 0;

double DistanceToPoint = Math.Sqrt(Math.Pow(xA - x0, 2) + Math.Pow(yA - y0, 2));

Console.WriteLine($"Расстояние от начала координат до точки равно {DistanceToPoint:F2} единиц.");