﻿// Программа принимает на вход число (N)
// и выдаёт КВАДРАТЫ чисел, ЛЕЖАЩИЕ НА ОТРЕЗКЕ от 1 до N.
// (не так, как первоначально ставилась задача)

Console.WriteLine ("Введите некоторое число N");
int count = int.Parse (Console.ReadLine ());

for (int i = 1; Math.Pow(i, 2) <= count; i++) // если ТУТ убрать квадрат - программа выведет квадраты
    Console.Write ($"{Math.Pow(i, 2)} "); // всех чисел в диапазоне от 1 до N