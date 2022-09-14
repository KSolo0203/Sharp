// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

string[] words = UIcollectsSplittedString();
PrintArray(ParseEachSubstr(words));

string[] UIcollectsSplittedString() { // user interface collects splitted string as array of strings
    Console.WriteLine ("Пожалуйста, введите 8 чисел.");
    string[] words = Console.ReadLine().Split(" ");
    return words;
}

int[] ParseEachSubstr(string[] s) {
    int[] result = new int[8];
    int j = 0; int exc = 0;
    for (int i = 0; i < s.Length; i++) {
        if (int.TryParse(s[i], out int ParsedNumber) && j < result.Length) {
            result[j] = ParsedNumber;
            j++;
        }
        else if (int.TryParse(s[i], out ParsedNumber) && j == result.Length) {
            exc++;
            Console.WriteLine($"!!! Excession of integers !!! {exc} latter numbers was not added to the array !!!");
        }
    }
    return result;
}

void PrintArray(int[] array) {
    Console.Write ($"[");
    for (int i = 0; i < array.Length; i++) {
        if (i < array.Length - 1)
            Console.Write ($"{array[i]}, ");
        else
            Console.Write ($"{array[i]}]");
    }
    Console.WriteLine();
}