// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

const int Size = 12;
int[] vector = CreateArray(Size);
PrintArray(vector);
int posX = CountPositive(vector);
int negX = CountNegative(vector);
Console.WriteLine($"В данном массиве сумма всех положительных чисел равна {posX},\nсумма же всех отрицательных чисел равна {negX}.");

int[] CreateArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-9,10);
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

int CountPositive(int[] arr)
{
    int positiveSum = 0;
    foreach (int number in arr)
    {
        if (number > 0)
            positiveSum += number;
    }
    return positiveSum;
}

int CountNegative(int[] arr)
{
    int negativeSum = 0;
    foreach (int number in arr)
    {
        if (number < 0)
            negativeSum += number;
    }
    return negativeSum;
}