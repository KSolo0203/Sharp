// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

const int Size = 123;

int[] array = CreateArray(Size, -80, 189); 
PrintArray(array);
int x = CountDesignated(array);
System.Console.WriteLine($"В данном массиве {x} чисел, лежащих в пределах от 10 до 99 включительно");

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

bool IsDesignated(int number)
{
    return (number <= 99 && number >= 10 );
}

int CountDesignated(int[] arr)
{
    int counter = 0;
    foreach (int element in arr)
    {
        if (IsDesignated(element))
            counter++;
    }
    return counter;
}