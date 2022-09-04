// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int UsInp (int l) // Функция "приглашение ко вводу, ввод"
{
    Console.WriteLine("Введите число.");
    l = int.Parse(Console.ReadLine()); // без защиты от нечисленных значений параметра s
    return l;
}

int FindMax (int arg1, int arg2, int arg3) // Решение с объявлением функции
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a = 0; int b = 0; int c = 0;
a = UsInp(a); b = UsInp(b); c = UsInp(c);

Console.WriteLine($"Наибольшее из данных чисел - {FindMax(a,b,c)}.");