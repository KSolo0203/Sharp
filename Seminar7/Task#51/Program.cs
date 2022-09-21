// Задайте двумерный массив. Найдите сумму элементов, находящихся
// на главной диагонали (с индексами (0,0); (1;1) и т.д.)

int[,] matrix = InterfaceCollectsMarix();
FillMatrixRandom(matrix);
PrintMatrix(matrix);
Console.WriteLine(SumMainDiagonal(matrix));

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

int SumMainDiagonal(int[,] matrix)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        result = result + matrix[i,i];
    }
    return result;
}