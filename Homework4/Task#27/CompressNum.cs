// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Compress(int n) {
    int result = 0;
    while (n > 0) {
        int digit = n % 10;
        n = n / 10;
        result += digit;
    }
    return result;
}

Console.WriteLine ("Введите некоторое число N");
int NumToCompress = int.Parse (Console.ReadLine ());

Console.WriteLine($"Сумма цифр этого числа равна {Compress(NumToCompress)}.");