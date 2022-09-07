// Напишите программу, которая принимает на вход координаты
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.
Console.WriteLine("Введите X Y:");
string xy = Console.ReadLine()!;
string[] parts = xy.Split (' ');
int x = int.Parse(parts[0]);
int y = int.Parse(parts[1]);
if (x>0 && y>0)
    Console.WriteLine("Это первая четверть.");
else if (x<0 && y>0)
    Console.WriteLine("Это вторая четверть.");
else if (x<0 && y<0)
    Console.WriteLine("Это третья четверть.");
else if (x>0 && y<0)
    Console.WriteLine("Это четвертая четверть.");
else
    Console.WriteLine("Смотрите условие задачи!");    


    