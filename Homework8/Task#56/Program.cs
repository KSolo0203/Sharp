// Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.

int[,] matrix = InterfaceCollectsMarix();
FillMatrixRandom(matrix);
Console.WriteLine();
Console.WriteLine($"Исходный массив:");
int[] sums = SumValuesInRows(matrix);
PrintMatrixAndRowSum(matrix);

int[] SumValuesInRows(int[,] matrix)
{
    int[] sums = new int[matrix.GetLength(0)];
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        result = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result += matrix[i, j];
        }
        sums[i] = result;
    }
    return sums;
}

int[,] InterfaceCollectsMarix()
{
    Console.WriteLine("Введите высоту массива.");
    int height = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите ширину массива.");
    int width = int.Parse(Console.ReadLine());
    return new int[height, width];
}

int[,] FillMatrixRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
        }
    }
    return matrix;
}

void PrintMatrixAndRowSum(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.Write($"   Сумма элементов данной строки равна {sums[i]}");
        Console.WriteLine();
    }
}