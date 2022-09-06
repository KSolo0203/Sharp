// Программа, удаляющая вторую цифру в трехзначном ГПЧ-числе.
int N = new Random().Next(100, 1000);
int digit1 = N / 100;
int digit2 = N / 10 % 10;
int digit3 = N % 10;

int number = digit1 * 10 + digit3; // всё же получим число из отдельных символов

Console.WriteLine($"Было {N}.");
Console.WriteLine($"Получилось {number}.");