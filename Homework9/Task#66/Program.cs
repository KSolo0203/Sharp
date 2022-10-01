// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int[] numbers = UserInterface();
int sum = 0;
Console.WriteLine(SumNumbers(numbers[0],numbers[1]));

int[] UserInterface()
{
    int[] numbers = new int[2];
    Console.WriteLine("Ведите числа M и N");
    string[] parts = Console.ReadLine().Split(" ");
    numbers[0] = int.Parse(parts[0]);
    numbers[1] = int.Parse(parts[1]);
    return numbers;
}

int SumNumbers(int number1, int number2)
{
    if (number1 == number2)
    {
        return sum += number2;
    }
    else
    {
        return sum = sum + number1 + SumNumbers(number1 + 1, number2);
    }
}