int[] array = {11, 21, 31, 41, 51, 61, 17, 5, 39};

int n = array.Length;

int find = 51;

int index = 0;

while (index < n) {

    if (array[index] == find) {
        Console.WriteLine(index);
        // можно добавить break на случай, если надо найти первое найденное соответствие и выйти;
    }
    index ++;
}