// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int CountDigits(int n) {
    int numberDisplay = n;
    int count = 0;

    while (n > 0) {
        int digit = n % 10;
        n = n / 10;
        count += 1;
    }
    return count;
}

Console.WriteLine("Введите число");
int numberToCount = int.Parse(Console.ReadLine());

Console.WriteLine($"В числе {numberToCount} {CountDigits(numberToCount)} цифр.");