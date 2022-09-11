// Программа заполняет массив 8 случайными числами. Напишите функцию, которая принимает
// массив и находит в нём наибольший элемент. Используйте накопительную переменную.
// Эта переменная изначально равна первому элементу массива; когда встречается лучший
// кандидат на максимум, она его запоминает.

void FillArray(int[] collection) { // заполнить пустой массив с использованием ГПСЧ
    for (int i = 0; i < collection.Length; i++) {
        collection[i] = new Random().Next(1,100);
    }
}

int LookForMax(int[] array) // найти максимальное значение в массиве
{
    int tempMax = array[0];
    for (int i = 1; i < array.Length; i++) {
        if (array[i] > tempMax)
            tempMax = array[i];
    }
    return tempMax;
}

void PrintArray(int[] arr) { // вывести массив на экран консоли
    for (int i = 0; i < arr.Length; i++ ) {
        Console.Write ($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] vector = new int[8];
FillArray(vector);
PrintArray(vector);
int globalizeMax = LookForMax(vector); // переменная для глобализации
Console.WriteLine($"Наибольшее число в данном массиве это {globalizeMax}.");