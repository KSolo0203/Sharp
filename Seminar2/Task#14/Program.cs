// Программа принимает на вход число и проверяет, кратно ли оно 7 и 23 (не исходное условие!)

int UsInp (int l)
{
    Console.WriteLine("Введите число.");
    l = int.Parse(Console.ReadLine());
    return l;
}

int a = 0; a = UsInp(a);

if (a % 7 == 0) {
    if (a % 23 == 0) Console.WriteLine($"Число {a} кратно числу 7 и 23.");
    else Console.WriteLine($"Число {a} кратно 7, но не 23.");
}
else {
    if (a % 23 == 0) Console.WriteLine($"Число {a} кратно числу 23, но не 7.");
    else Console.WriteLine($"Число {a} не кратно ни 7, ни 23.");
}