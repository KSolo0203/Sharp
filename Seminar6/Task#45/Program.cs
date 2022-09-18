// Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

int[] fst = {1,5,3,7,9,2,8,3,6,1,9,4,};

PrintArray(fst);
// Console.WriteLine("Введите имя для копии массива");
// string name = Console.ReadLine()!;

int[] copy = CopyArray(fst);
PrintArray(copy);

int[] CopyArray(int[] arr)
{
    int[] s = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        s[i] = arr[i];
    }
    return s;
}

void PrintArray(int[] arr)
{
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}