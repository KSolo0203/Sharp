// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

int[,] matrix = InterfaceCollectsMarix();
FillMatrixRandom(matrix);
PrintMatrix(matrix);
SquareEvenElem(matrix);
PrintMatrix(matrix);

int[,] InterfaceCollectsMarix()
{
    Console.WriteLine("Введите высоту матрицы.");
    int height = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Введите ширину матрицы.");
    int width = int.Parse(Console.ReadLine());
    int[,] matrix = new int[height,width];
    return matrix;
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

void SquareEvenElem(int[,] array)
{
    for (int i = 1; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 1; j < matrix.GetLength(1); j += 2)
        {
            matrix[i,j] = matrix[i,j]*matrix[i,j];
        }
    } 
}