// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

const int Size = 15;

int[] array = CreateArray(Size,-9,10);

Console.WriteLine("Введите число.");
int search = int.Parse(Console.ReadLine());

PrintArray(array);
if (LookForExact((array), search))
{
    Console.WriteLine($"В данном массиве искомое число {search} обнаружено.");
}
else
    Console.WriteLine($"В данном массиве искомое число {search} отсутствует.");

int[] CreateArray(int size, int smallest, int biggest)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(smallest,biggest);
    }
    return numbers;
}

void PrintArray(int[] arr)
{
    foreach (int element in arr)
    {
        Console.Write ($"{element} "); 
    }
    Console.WriteLine();
}

bool LookForExact(int[] arr, int exact) // ищет число
{
    for (int i = 0; i < arr.Length; i++ )
    {
        if (arr[i] == exact)
            return true;
    }
    return false;
}