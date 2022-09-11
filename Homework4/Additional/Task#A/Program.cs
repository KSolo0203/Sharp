// Программа заполняет массив 8 случайными числами. Напишите функцию,
// которая находит среднее арифметическое чисел в массиве.
// Спойлер: среднее арифметическое равно сумме, делённой на количество.

void FillArray(int[] collection) { // заполнить пустой массив с использованием ГПСЧ
    for (int i = 0; i < collection.Length; i++) {
        collection[i] = new Random().Next(1,100);
    }
}

void PrintArray(int[] arr) { // вывести массив на экран консоли
    for (int i = 0; i < arr.Length; i++ ) {
        Console.Write ($"{arr[i]} ");
    }
    Console.WriteLine();
}

float CalculateAverage(int[] arr) {
    float sum = 0;
    for (int i = 0; i < arr.Length; i++) {
        sum += arr[i];
    }
    sum = sum / arr.Length;
    return sum;
}

int[] vector = new int[8];
FillArray(vector);
PrintArray(vector);
Console.WriteLine(CalculateAverage(vector));