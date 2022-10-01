// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

int number = UserInterface();
int output = 1;
GiveNumber(number);

int UserInterface()
{
    Console.WriteLine("Ведите число N");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void GiveNumber(int number)
{
    if (output == number) Console.WriteLine($"{number}");
    else
        {
        Console.Write($"{output}, ");
        output++;
        GiveNumber(number);
        }
}