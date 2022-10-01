// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int result = 1;
int[] aandb = UserInterface();
Console.WriteLine($"{PowerTo(aandb[0], aandb[1])}");

int[] UserInterface()
{
    int[] numbers = new int[2];
    Console.WriteLine("Ведите основание A и показатель степени B");
    string[] parts = Console.ReadLine().Split(" ");
    numbers[0] = int.Parse(parts[0]);
    numbers[1] = int.Parse(parts[1]);
    return numbers;
}

int PowerTo(int a, int b)
{
    if (aandb[1] > 0)
    {
        result = aandb[0] * PowerTo(aandb[0], aandb[1]--);
        return result;
    }
    else
    {
        return result;
    }
}
