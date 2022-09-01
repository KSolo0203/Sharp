// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int FindMax (int arg1, int arg2, int arg3) // Решение с объявлением функции
{
    int result = arg1;
    if (arg2 > result) {result = arg2;}
    else if (arg3 > result) {result = arg3;}
    return result;
}

Console.WriteLine("Введите число.");
int a = int.Parse(Console.ReadLine()); // без защиты от нечисленных значений параметра s
Console.WriteLine("Введите второе число для сравнения.");
int b = int.Parse(Console.ReadLine()); // без защиты от нечисленных значений параметра s
Console.WriteLine("Введите третье число для сравнения.");
int c = int.Parse(Console.ReadLine()); // без защиты от нечисленных значений параметра s

Console.WriteLine($"Наибольшее из данных чисел - {FindMax(a,b,c)}.");