// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

const int Size = 15;
int[] vector = CreateArray(Size);
PrintArray(vector);

Console.WriteLine($"В данном массиве разница между наибольшим ({FindMax(vector)}) и\nнаименьшим ({FindMin(vector)}) элементом равна {GetDiffTwo(vector)}.");
// если в данной $-строке использовать функции FindMax и FindMin, то O(n)*4 (по разу для поиска минимума и максимума
// и дважды в функции, вычисляющей их разницу.
// можно создать int a и int b, в которых хранить результаты FindMax и FindMin, тогда следует изменить
// GetDiffTwo так, чтобы ей передавались a и b, а не int[]

int[] CreateArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,100);
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

int FindMax(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}

int FindMin(int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}

int GetDiffTwo(int[] arr)
{
    return Math.Abs(FindMax(arr) - FindMin(arr));
}