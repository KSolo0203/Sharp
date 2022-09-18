// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine($"Вводите числа через пробел, затем нажмите ВВОД.");
string[] userInput = Console.ReadLine().Split();

//float[] array = GainNumbers();

int PinM = CountPositive(userInput);
Console.WriteLine($"Среди введенных чисел положительных: {PinM}.");

//float[] GainNumbers()
//{
//    int i = 0;
//    while (i < array.Length)
//    {
//       Console.WriteLine("Введите число");
//        array[i] = float.Parse(Console.ReadLine());
//        i++;
//    }
//    return array;
//}

int CountPositive(string[] arr)
{
    int count = 0;
    foreach (string elem in arr)
    {
        
        if (float.Parse(elem) > 0)
        {
            count++;
        }
    }
    return count;
}