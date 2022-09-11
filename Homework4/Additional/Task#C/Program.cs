// Программа заполняет массив 8 случайными числами. Напишите функцию,
// которая проверяет, верно ли, что все числа в массиве чётные. Наличие
// хотя бы одного нечётного числа означает, что ответ — нет.

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

bool CheckEven (int arg) { // проверка целого числа на чётность
    if (arg%2 == 0)
        return true;
    else
        return false;
}

bool ArrayEven(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        if (!CheckEven(arr[i]))
            return false;
    }
    return true;
}

int[] vector = new int[8];
FillArray(vector);
PrintArray(vector);
if (!ArrayEven(vector))
    Console.WriteLine("В массиве есть нечётные числа.");
else
    Console.WriteLine("В массиве только чётные числа.");