// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Factorial(int numberToMultiply) {
    int Mltplr = 1;
    for ( int i = 1; i <= numberToMultiply; i++ ) {
        Mltplr = Mltplr * i;
    }
    return Mltplr;
}

Console.WriteLine("Введите число");
int numberToMultiply = int.Parse(Console.ReadLine());

Console.WriteLine($"{numberToMultiply}! это {Factorial(numberToMultiply)}");