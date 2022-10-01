// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int[] numbers = UserInterface();
if (Akkerman(numbers[0],numbers[1]) != -1) Console.WriteLine(Akkerman(numbers[0],numbers[1]));
else Console.WriteLine("Используйте неотрицательные числа");

int[] UserInterface()
{
    int[] numbers = new int[2];
    Console.WriteLine("Ведите два неотрицательных числа M и N");
    string[] parts = Console.ReadLine().Split(" ");
    numbers[0] = int.Parse(parts[0]);
    numbers[1] = int.Parse(parts[1]);
    return numbers;
}

int Akkerman(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 += 1;
    }
    else if (number1 > 0 && number2 == 0)
    {
        return Akkerman(number1 - 1, 1);
    }
    else if (number1 > 0 && number2 > 0)
    {
        return Akkerman(number1 - 1, Akkerman(number1, number2 - 1));
    }
    else return -1;
}