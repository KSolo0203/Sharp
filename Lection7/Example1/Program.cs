string NumbersRec(int a, int b)
{
    if (a < b) return $"{a} " + NumbersRec(a + 1, b);
    else return $"{b}";  // String.Empty;
}

// Console.WriteLine(NumbersString(1,10));

int SummaRec(int n)
{
    if (n == 0) return 0;
    else return n + SummaRec(n - 1);
}

// Console.WriteLine(Summa(10));

int AToPowerOfNRec(int a, int n)
{
    if (n == 1) return a * 1;
    else if (n % 2 == 0) return AToPowerOfNRec(a*a, n/2);
    else return a * AToPowerOfNRec(a, n - 1);
}

Console.WriteLine(AToPowerOfNRec(4,5));