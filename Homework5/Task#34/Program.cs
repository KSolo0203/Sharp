// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

const int Size = 10;
int[] vector = CreateArray(Size);
PrintArray(vector);
Console.WriteLine($"В данном массиве четных чисел: {CountEven(vector)}.");

int[] CreateArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
    return numbers;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++ )
    {
        Console.Write ($"{arr[i]} ");
    }
    Console.WriteLine();
}

int CountEven(int[] arr)
{
    int evenSum = 0;
    foreach (int number in arr)
    {
        if (number % 2 == 0)
            evenSum++;
    }
    return evenSum;
}