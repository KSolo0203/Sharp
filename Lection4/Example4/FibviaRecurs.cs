int Fib(int n)
{
    if (n == 1 || n == 2)
        return 1;
    else
        return (Fib(n-2) + Fib(n-1));
}

System.Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine($"{n} первых членов последовательности Фибоначчи:");

for (int i = 1; i <= n; i++)
{
    System.Console.Write($"{Fib(i)} ");
} 
