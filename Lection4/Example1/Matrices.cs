int[,] table = new int[4,4];

// string.Empty ЧТО ЭТО ЗНАЧИТ?!

Print2dArray(table);
System.Console.WriteLine();
Print2dArray(Fill2dArray(table));

int[,] Fill2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0,2);
        }
    }
    return arr;
}

void Print2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}