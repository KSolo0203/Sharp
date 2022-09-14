// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

const int Size = 15;
int[] vector = CreateArray(Size);
PrintArray(vector);

Console.WriteLine($"В данном массиве сумма элементов, стоящих на нечётных позициях равна {UnevenPosSum(vector)}.");

int[] CreateArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,11);
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

int UnevenPosSum(int[] arr) // нечётные в смысле внутреннего представления позиции
{
    int result = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        result += arr[i];
    }
    return result;
}