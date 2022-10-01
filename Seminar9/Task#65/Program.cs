// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N по убыванию.

int[] numbers = UserInterface();
Console.Write(GiveNumber(numbers[0], numbers[1]));

int[] UserInterface()
{
    int[] numbers = new int[2];
    Console.WriteLine("Ведите числа M и N");
    string[] parts = Console.ReadLine().Split(" ");
    numbers[0] = int.Parse(parts[0]);
    numbers[1] = int.Parse(parts[1]);
    return numbers;
}

string GiveNumber(int number1, int number2)
{
    if (number1 == number2)
    { 
        return $"{number2} ";
    }
    else
    {
        return GiveNumber(number1 + 1, number2) + $"{number1} ";
    }
}