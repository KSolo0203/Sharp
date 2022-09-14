// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый
// и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.


const int Size = 11; // решение с нечетным количеством элементов в массиве

int[] array = CreateArray(Size, -10, 11);
Console.WriteLine("Было:");
PrintArray(array);
Console.WriteLine("Стало:");
PrintArray(MultiplyPair(array));

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++ )
    {
        Console.Write ($"{arr[i]} "); 
    }
    Console.WriteLine();
}

int[] CreateArray(int size, int smallest, int biggest)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(smallest,biggest+1);
    }
    return numbers;
}

int[] MultiplyPair(int[] arr)
{
    int[] multipliedVector = new int[(arr.Length + 1) / 2];
    for (int i = 0; i < (arr.Length + 1) / 2; i++)
    {
        multipliedVector[i] = arr[i] * arr[arr.Length - i - 1];
    }
    return multipliedVector;
}