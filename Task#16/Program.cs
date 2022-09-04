// Программа принимает на вход два числа и проверяет, является ли одно число квадратом другого.

int UsInp (int l)
{
    Console.WriteLine("Введите число.");
    l = int.Parse(Console.ReadLine());
    return l;
}

int a = 0; a = UsInp(a);
int b = 0; b = UsInp(b);

if (a*a == b) Console.WriteLine($"Квадрат числа {a} действительно равен {b}");
else if (b*b == a) Console.WriteLine($"Квадрат числа {b} действительно равен {a}");
else Console.WriteLine($"Ни одно из двух данных чисел не является квадратом другого");