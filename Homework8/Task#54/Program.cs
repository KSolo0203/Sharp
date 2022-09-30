// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

int[,] matrix = InterfaceCollectsMarix();
FillMatrixRandom(matrix);
Console.WriteLine($"Исходная матрица:");
PrintMatrix(matrix);
Console.WriteLine($"Матрица после воздействия:");
SortRowsViaBubble(matrix); // не пузырёк, а камушек, по убыванию же
// SortRowsViaSelect(matrix); // больше кода и тот же O(n^3)
PrintMatrix(matrix);

void SortRowsViaBubble(int[,] matrix) // O(n^3)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = matrix.GetLength(1); k > 0; k--)
        {
            for (int j = matrix.GetLength(1) - 1; j > 0; j--)
            {
                if (matrix[i, j] > matrix[i, j - 1])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j - 1];
                    matrix[i, j - 1] = temp;
                }
            }
        }
    }
}

int[,] InterfaceCollectsMarix()
{
    Console.WriteLine("Введите высоту матрицы.");
    int height = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите ширину матрицы.");
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}