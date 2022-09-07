// Пользователь вводит x и y. Программа печатает, чему равно x² + y².

Console.WriteLine("Введите через пробел X и Y");
string xy = Console.ReadLine();
string[] parts = xy.Split (' ');
int x = int.Parse(parts[0]);
int y = int.Parse(parts[1]);

Console.WriteLine($"{x}^2 + {y}^2 = {Math.Pow(x,2)+Math.Pow(y,2)}");