// Программ принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");

string UsIn = Console.ReadLine();

if (int.TryParse(UsIn, out int N)) { // число ли введено?
    if (N>9999 && N<100000) { // пятизначное ли оно?
        string s = N.ToString(); // если да, то инвертируем его не как число, а как массив символов
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
