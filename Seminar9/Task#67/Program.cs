// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int number = UserInterface();
int sum = 0;
Console.WriteLine($"{SumDigits(number)}");

int UserInterface()
{
    Console.WriteLine("Ведите число N");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumDigits(int number)
{
    if (number > 0)
    {
        int N = number % 10;
        int sum = N + SumDigits(number / 10);
        return sum;
    }
    else
    {
        return sum;
    }
}