void FillArray(int[] collection) // заполнить пустой массив с использованием ГПСЧ
{
    int size = collection.Length;
    int index = 0;
    while (index < size)
    {
        collection[index] = new Random().Next(1,10);
        index ++;
    }
}

void PrintArray(int[] collection) // вывести массив на экран консоли
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write ($"{collection[position]} ");
        position ++;
    }
    Console.WriteLine();
}

int Max(int[] array) // найти максимальное значение в массиве
{
    int result = array[0];
    int index = 1;
    int n = array.Length;
    while (index < n) {
        if (array[index] > result) result = array[index];
        index ++;
    }
    return result;
}

int IndexOf(int[] array, int find) // вернуть индекс искомого значения либо -1
{
    int n = array.Length;
    int index = 0;
    int indicator = -1;
    while (index < n) {
        if (array[index] == find) {
        indicator = index;
        // можно добавить break на случай, если надо найти первое, а не последнее найденное соответствие и выйти;
        }
        index ++;
    }
    return indicator;
}

int[] vector = new int[20];

FillArray(vector);

PrintArray(vector); // первая строка это весь массив

Console.WriteLine(Max(vector)); // вторая строка это максимум в массиве

Console.WriteLine(IndexOf(vector,5)); // третья строка это индекс искомого вхождения