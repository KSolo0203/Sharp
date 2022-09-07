// Пользователь вводит a и b. Программа печатает все числа от a до b.

Console.WriteLine("Введите через пробел два числа");
string ab = Console.ReadLine();
string[] parts = ab.Split (' ');
if (int.TryParse(parts[0], out int a) && int.TryParse(parts[1], out int b)) {
    int max = 0; int min = 0;
    if (a < b) {
        min = a; max = b;
    }
    else {
        min = b; max = a;
    }
    for ( int i = min; i <= max; i++) {
        Console.Write($"{i} ");
    }
}
else
    Console.WriteLine($"Увы, что-то пошло не так!");