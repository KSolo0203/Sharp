// Программа получает два числа и судит о кратности первого второму, считает остаток от деления в случае False.

int UsInp (int l)
{
    Console.WriteLine("Введите число.");
    l = int.Parse(Console.ReadLine());
    return l;
}

int a = 0; a = UsInp(a);
int b = 0; b = UsInp(b);

if (a % b == 0) Console.WriteLine($"Число {a} кратно числу {b}.");
else Console.WriteLine($"Число {a} некратно {b}, остаток от деления {a} на {b} это {a % b}.");
