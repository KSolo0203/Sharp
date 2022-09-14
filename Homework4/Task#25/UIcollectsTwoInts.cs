// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int[] NumsToManipulate = UIcollectsTwoInts();
Console.WriteLine(ToPowerOf(NumsToManipulate[0],NumsToManipulate[1]));

int[] UIcollectsTwoInts() { // user interface collects two integers
    int[] NumsToManipulate = new int[2];
    Console.WriteLine ("Введите через пробел два числа А и В:");
    string UsInp = Console.ReadLine();
    string[] parts = UsInp.Split();
    NumsToManipulate[0] = int.Parse(parts[0]);
    NumsToManipulate[1] = int.Parse(parts[1]);
    return NumsToManipulate;
}

int ToPowerOf(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= NumsToManipulate[1]; i++)
    {
       result *= NumsToManipulate[0];
    }
    return result;
}