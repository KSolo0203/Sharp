// Программа, сравнивающая цифры в двузначном ГПЧ-числе.
int N = new Random().Next(10,100);
System.Console.WriteLine(N);

int digit1 = N / 10;
int digit2 = N % 10;

if (digit1 >= digit2)
    Console.WriteLine($"{digit1} больше {digit2}.");
else
    Console.WriteLine($"{digit2} больше {digit1}.");