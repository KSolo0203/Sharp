// Пользователь вводит x и y. Программа печатает, какое отношение верно: x < y, x = y либо x > y.

Console.WriteLine("Введите через пробел X и Y");
string xy = Console.ReadLine();
string[] parts = xy.Split (' ');
if (int.TryParse(parts[0], out int x) && int.TryParse(parts[1], out int y)) {
    if (x < y)
        Console.WriteLine($"{x} < {y}");
    if (x == y)
        Console.WriteLine($"{x} = {y}");
    if (x > y)
        Console.WriteLine($"{x} > {y}");
}
else
    Console.WriteLine($"Увы, что-то пошло не так!");