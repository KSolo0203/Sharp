using System;

Console.WriteLine("Введите число 1");

string userIn_1 = Console.ReadLine();

int number_1 = int.Parse(userIn_1);

Console.WriteLine("Введите число 2, которое мы будем сравнивать с первым, возведенным в квадрат");

string userIn_2 = Console.ReadLine();

int number_2 = int.Parse(userIn_2);

int sqr = number_1 * number_1;

if (sqr == number_2) {

    Console.WriteLine($"Квадрат числа {number_1} действительно равен {number_2}");
}

else {

    Console.WriteLine($"Квадрат числа {number_1} не равен {number_2}");
}