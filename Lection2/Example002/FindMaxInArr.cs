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

void IndexOf(int[] collection, int find) 
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            Console.WriteLine ($"Найдена позиция: {position+1}");
        }
        
        index ++;
    }
    if (position == -1)
    {
        Console.WriteLine("Нет такого значения");
    }
}

int[] vector = new int[20];

FillArray(vector);

PrintArray(vector); // первая строка это весь массив

Console.WriteLine(Max(vector)); // вторая строка это максимум в массиве

int lever = 1;
while (lever == 1)
{
    Console.WriteLine("Введите целое число, индекс которого необходимо найти: ");
    string UserIn = Console.ReadLine();
    if (int.TryParse(UserIn, out int X3) == true)
    {
        IndexOf(vector,int.Parse(UserIn));
    }
    else
    {
        Console.WriteLine("Это не число!");
    }
    lever = 2;
    while (lever > 1)
    {
        Console.WriteLine("Повторить? Y/N");
        UserIn = Console.ReadLine();
        lever = 0;
        if (UserIn.ToLower() == "y")
        {
            lever = 1;
        }
        else if (UserIn.ToLower() == "n")
        {
            lever = 0;
        }
    }
}