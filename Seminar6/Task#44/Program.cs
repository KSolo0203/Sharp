// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int n = int.Parse(Console.ReadLine());

int fst = 0;
int snd = 1;

if (n == 1)
{
    Console.Write($"{fst}");
}
else if (n == 2)
{
    Console.Write($"{snd}");
}
else
{
    Console.Write($"{fst}, {snd}, ");
    for (int i = 2; i < n ; i++)
    {
        Console.Write($"{fst+snd}, ");
        int t = fst;
        fst = snd;
        snd = snd + t;
    }
}