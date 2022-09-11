namespace ForArrays;
public class Class1
{

}
bool CheckEven (int arg) { // проверка целого числа на чётность
    if (arg%2 == 0)
        return true;
}
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