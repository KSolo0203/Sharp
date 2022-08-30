using System;

Console.WriteLine ("Введите некоторое число от 0 до 32767 :)");

string str = Console.ReadLine ();

int number = int.Parse (str);

Console.WriteLine(number % 10);