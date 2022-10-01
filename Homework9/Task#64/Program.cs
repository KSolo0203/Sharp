// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

GiveNumber(UserInterface());

int[] UserInterface()
{
    int[] numbers = new int[2];
    Console.WriteLine("Ведите числа M и N");
    string[] parts = Console.ReadLine().Split(" ");
    numbers[0] = int.Parse(parts[0]);
    numbers[1] = int.Parse(parts[1]);
    return numbers;
}

void GiveNumber(int[] numbers)
{
    if (numbers[0] == numbers[1]) Console.WriteLine($"{numbers[1]}");
    else
        {
        Console.Write($"{numbers[0]}, ");
        numbers[0]++;
        GiveNumber(numbers);
        }
}