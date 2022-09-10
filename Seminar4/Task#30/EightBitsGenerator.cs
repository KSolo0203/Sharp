// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

void FillArray(int[] collection) { // заполнить пустой массив с использованием ГПСЧ
    for (int i = 0; i < collection.Length; i++) {
        collection[i] = new Random().Next(0,2);
    }
}

int[] EightBitsGenerator() {
    int[] arr = new int[8];
    FillArray(arr);
    return arr;
}

void PrintArray(int[] collection) { // вывести массив на экран консоли
    for ( int i = 0; i < collection.Length; i++) {
        Console.Write ($"{collection[i]} ");
    }
    Console.WriteLine();
}

PrintArray(EightBitsGenerator());
