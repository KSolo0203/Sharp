// Пользователь вводит координаты двух точек A и B на плоскости.
// Программа определяет, какая из них дальше от начала координат.

Console.WriteLine("Введите через пробел координаты X и Y точки A");
string xy = Console.ReadLine();
string[] parts = xy.Split (' ');
int xA = int.Parse(parts[0]);
int yA = int.Parse(parts[1]);

Console.WriteLine("Введите через пробел координаты X и Y точки B");
xy = Console.ReadLine();
parts = xy.Split (' ');
int xB = int.Parse(parts[0]);
int yB = int.Parse(parts[1]);

int x0 = 0; int y0 = 0;

double DistanceToPointA = Math.Sqrt(Math.Pow(xA - x0, 2) + Math.Pow(yA - y0, 2));
double DistanceToPointB = Math.Sqrt(Math.Pow(xB - x0, 2) + Math.Pow(yB - y0, 2));

string P = "";
if (Math.Abs(DistanceToPointA - DistanceToPointB) < 0.01)
    Console.WriteLine($"Обе точки могут считаться равноудалёнными от начала координат.");
else if (DistanceToPointA > DistanceToPointB) {
    P = "A";
    Console.WriteLine($"От начала координат более удалена точка {P}.");
    Console.WriteLine($"Разница расстояний: {Math.Abs(DistanceToPointA - DistanceToPointB)}.");
}
else if (DistanceToPointA < DistanceToPointB) {
    P = "B";
    Console.WriteLine($"От начала координат более удалена точка {P}.");
    Console.WriteLine($"Разница расстояний: {Math.Abs(DistanceToPointA - DistanceToPointB)}.");
}