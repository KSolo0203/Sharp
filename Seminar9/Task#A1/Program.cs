// Напишите программу, которая конвертирует десятичное число в двоичное с помощью рекурсии.

int number = UserInterface();
string binnumber = "";
Console.WriteLine(ConvertNumber(number));

int UserInterface()
{
    Console.WriteLine("Ведите число");
    int number = int.Parse(Console.ReadLine());
    return number;
}

string ConvertNumber(int number)
{
    if (number % 2 == 0 && number / 2 > 0)
    {
        return binnumber = $"{ConvertNumber(number / 2)}" + "0";
    }
    else if (number % 2 != 0 && number / 2 > 0)
    {
        return binnumber = $"{ConvertNumber(number / 2)}" + "1";
    }
    else if (number % 2 != 0)
    {
        return binnumber += "1";
    }
    else
    {
        return binnumber += "0";
    }
}