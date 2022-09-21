// Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

int[,] matrix = InterfaceCollectsMarix();
FillMatrixRandom(matrix);
Console.WriteLine($"Исходная матрица:");
PrintMatrix(matrix);
CalcColumnsAverage(matrix);

int[,] InterfaceCollectsMarix()
{
    Console.WriteLine("Введите высоту матрицы.");
    int height = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Введите ширину матрицы.");
    int width = int.Parse(Console.ReadLine());
    return new int[height,width];
}

int[,] FillMatrixRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-99,100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j],3} ");
        }
        Console.WriteLine();
    }
}

void CalcColumnsAverage(int[,] matrix)
{
    Console.WriteLine("В данной матрице среднее арифметическое по столбцам равно:");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        float result = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result += matrix[i,j];
        }
    Console.WriteLine($"В столбце {j}: {result/matrix.GetLength(0):F2}.");
    }
}