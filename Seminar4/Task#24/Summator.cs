// Напишите программу, которая принимает на вход число N и выдаёт сумму чисел от 1 до N.

Console.WriteLine("Введите число");
int cap = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i <= cap; i++) {
    sum += i;
}
Console.WriteLine($"{sum}");