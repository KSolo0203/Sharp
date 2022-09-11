// Программа заполняет массив 8 случайными числами. Напишите функцию,
// которая проверяет, верно ли, что числа в массиве идут по возрастанию.
// Если очередное число меньше предыдущего, ответ — нет.

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

bool IsIncreasing(int[] arr) {
    for (int i = 0; i < arr.Length - 1; i++) {
        if (!(arr[i] < arr[i + 1]))
            return false;
    }
    return true;
}

int[] vector = new int[8];
FillArray(vector);
PrintArray(vector);
if (IsIncreasing(vector))
    Console.WriteLine("Значения в данном массиве монотонно возрастают.");
else
    Console.WriteLine("В данном массиве не выявлено монотонного возрастания величин.");