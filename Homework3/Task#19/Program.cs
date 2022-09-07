// Программ принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// def MyRevFunc(string s) {
//    string[] spell = s.ToCharArray();
//    string[] revspell;
//    for (int i = spell.Length; i > -1; i --) {
//        revspell = revspell + spell[i]; 
//    }
//    return revspell;
//}

Console.WriteLine("Введите пятизначное число");

string UsIn = Console.ReadLine();

if (int.TryParse(UsIn, out int N)) { // число ли введено?
    if (N>9999 && N<100000) { // пятизначное ли оно?
        string s = N.ToString(); // если да, то инвертируем его не как число, а как массив символов
        // string s = UsIn // так проще
        string antis = new string(s.Reverse().ToArray()); // стандартная библиотека
        // string antis = MyRevFunc(s); // моя функция (встрял, допилить)

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
