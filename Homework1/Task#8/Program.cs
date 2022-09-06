// Напишите программу, которая на вход принимает число n,
// а на выходе показывает все чётные числа от 1 до n.

using System;

Console.WriteLine ("Введите некоторое число");

int number = int.Parse (Console.ReadLine());

int count = 1;

while (number-1 >= count) { // усложнение с единицами введено в код для уменьшения O(n) в два раза

    Console.Write ($"{count+1} ");
    count += 2;
} 