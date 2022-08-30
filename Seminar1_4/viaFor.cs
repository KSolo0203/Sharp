using System;

Console.WriteLine ("Введите некоторое число");

string userIn = Console.ReadLine ();

int number = int.Parse (userIn);

int count = number;

number = -1 * number;

while (number <= count) {

    Console.Write ($"{number} ");
    number += 1;
} 