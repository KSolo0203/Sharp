﻿// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным >>>(спойлер: делится ли оно на два без остатка?)<<<.

void CheckEven (int arg1) // Решение с объявлением функции
{
    if (arg1%2 == 0) {
        Console.WriteLine ($"{arg1} - чётное число"); // ноль будем считать чётным (мыжматематики!)
    }
    else {
        Console.WriteLine ($"{arg1} - нечётное число");
    } 
}

Console.WriteLine("Введите число.");
int a = int.Parse(Console.ReadLine());

CheckEven(a);