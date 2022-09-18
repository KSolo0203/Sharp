// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] vector = new int[] {1,2,3,4,5,6,7,8,9};
PrintArray(vector);
Swap(vector);
PrintArray(vector);

void PrintArray (int[] numbers) {
    Console.WriteLine ($"[{string.Join (", ", numbers)}]");
}

int[] Swap(int[] arr)
{
    int t = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        t = arr[i];
        arr[i] = arr[arr.Length-i-1];
        arr[arr.Length-i-1] = t;
    }
    return arr;
}

//void ReverseArray (int[] numbers) {
//    for (int i = 0; i < numbers.Length / 2; i++) {
//        Swap (ref numbers[i], ref numbers[^(i + 1)]);
//    }
//}

//void Swap (ref int a, ref int b) {  // передаём значения по ссылке
//    int c = a;
//    a = b;
//    b = c;
//}