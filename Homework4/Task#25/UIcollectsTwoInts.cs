// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int[] UIcollectsTwoInts(int[] arg) { // user interface collects two integers
    Console.WriteLine ("Введите через пробел два числа А и В:");
    string UsInp = Console.ReadLine();
    string[] parts = UsInp.Split();
    arg[0] = int.Parse(parts[0]);
    arg[1] = int.Parse(parts[1]);
    return arg;
}

int[] NumsToManipulate = new int[2];
UIcollectsTwoInts(NumsToManipulate);
Console.WriteLine(Math.Pow(NumsToManipulate[0],NumsToManipulate[1]));