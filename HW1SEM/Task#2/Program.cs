// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

void MaxMinTwoNumber (int arg1, int arg2) // решение с объявлением функции
{
    int min = 0; int max = 0;
    if (arg2 > arg1)
    {
        max = arg2; min = arg1;
    }
    else if (arg1 > arg2)
    {
        max = arg1; min = arg2;
    }
    Console.WriteLine($"В данной паре чисел {max} - большее, а {min} - меньшее.");
}

Console.WriteLine("Введите число.");
int a = int.Parse(Console.ReadLine()); // без защиты от нечисленных значений string
Console.WriteLine("Введите второе число для сравнения.");
int b = int.Parse(Console.ReadLine()); // без защиты от нечисленных значений string

MaxMinTwoNumber(a,b);