void FillArray(int[] collection) // заполнить пустой массив с использованием ГПСЧ
{
    int size = collection.Length;
    int index = 0;
    while (index < size)
    {
        collection[index] = new Random().Next(1,100); // числа от 0 до 99
        index ++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) {
    for (int i = 0; i < array.Length - 1; i++) {
        int maxPos = i;
        for (int j = i + 1; j < array.Length; j++) {
            if (array[j] > array[maxPos])
                maxPos = j;            
        }
        int temp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = temp;
    }
}

int[] arr = new int[15]; // размер - 15 элементов
FillArray(arr);
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
