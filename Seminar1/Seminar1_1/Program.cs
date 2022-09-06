using System;

Console.WriteLine("Введите число");

string userIn = Console.ReadLine();

int number = int.Parse(userIn);

int sqr = number * number;

Console.WriteLine($"Квадрат этого числа - {sqr}");