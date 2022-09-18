// Программ принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
string UsIn = Console.ReadLine();

if (int.TryParse(UsIn, out int N))
{
    if (N>9999 && N<100000)
    {
        string s = N.ToString();
        string antis = new string(s.Reverse().ToArray());

        if (UsIn == antis) {
            Console.WriteLine($"{UsIn} наоборот, как это ни странно, будет {antis}");
        }
        else
            Console.WriteLine($"{UsIn} это не палиндром");
        }
    else
        Console.WriteLine($"{UsIn} - не пятизначное!");
}
else
    Console.WriteLine($"{UsIn} это не число");