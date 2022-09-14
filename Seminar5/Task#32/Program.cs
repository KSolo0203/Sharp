// Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

const int Size = 12;
int[] array = CreateArray(Size);

Console.WriteLine($"Изначальный массив: ");
PrintArray(array);

InverseArray(array);
Console.WriteLine($"Инвертированный массив: ");
PrintArray(array);

int[] CreateArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-9,10);
    }
    return numbers;
}

int[] InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++ )
    {
        Console.Write ($"{arr[i]} ");
    }
    Console.WriteLine();
}