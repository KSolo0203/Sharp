// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int[] bin = new int[8];

int i = 0;
while (num > 0)
{
    if (num % 2 == 0)
    {
        bin[i] = 0;
    }
    else
    {
        bin[i] = 1;
    }
    num = num / 2;
    i++;
}

for (int j = 0; j < bin.Length; j++)
{
    Console.Write($"{bin[(bin.Length-j-1)]}");
}