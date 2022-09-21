// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

float[,] matrix = InterfaceCollectsMarix();
// PrintMatrix(matrix);
FillMatrixRandom(matrix);
PrintMatrix(matrix);

float[,] InterfaceCollectsMarix()
{
    Console.WriteLine("Введите высоту матрицы.");
    int height = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Введите ширину матрицы.");
    int width = int.Parse(Console.ReadLine());
    float[,] matrix = new float[height,width];
    return matrix;
}

float[,] FillMatrixRandom(float[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = (new Random().NextSingle()*200 - 100); // от -100 до 100
        }
    }
    return matrix;
}

void PrintMatrix(float[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j],10} ");
        }
        Console.WriteLine();
    }
}