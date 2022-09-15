int Factorial(int n)
{
    if (n <= 1)
        {
            return 1;
        }
    else
        return n * Factorial(n - 1);
}

System.Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine($"{n}! = {Factorial(n)}");