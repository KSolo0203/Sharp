// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

System.Console.WriteLine("Введите 3 числа, чтобы проверить, могут ли стороны такой длинны составить треугольник.");
string[] parts = Console.ReadLine().Split (' ');

float[] j = new float[3]; 

for (int i = 0; i < parts.Length; i++)
{
    j[i] = float.Parse(parts[i]);
}

if (j[1] > j[2] + j[0])
{
    Console.WriteLine("Подобное сочетание невозможно.");
}
else if (j[0] > j[2] + j[1])
{
    Console.WriteLine("Подобное сочетание невозможно.");
}
else if (j[2] > j[0] + j[1])
{
    Console.WriteLine("Подобное сочетание невозможно.");
}
else
{
    Console.WriteLine("Подобное сочетание возможно.");
}