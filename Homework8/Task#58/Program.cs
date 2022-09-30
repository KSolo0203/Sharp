// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matrix1 = InterfaceCollectsMarix("A");
FillMatrixRandom(matrix1);
int[,] matrix2 = InterfaceCollectsMarix("B");
// Операция умножения двух матриц возможна, когда матрицы согласованы. Матрицы A и B (порядок следования важен!) называются согласованными,
// если число столбцов матрицы A равно числу строк матрицы B (отметим, что квадратные матрицы одного порядка всегда согласованы).
if (IsMatricesConsistent(matrix1, matrix2))
{
    FillMatrixRandom(matrix2);
    int[,] product = MultiplyMatrices(matrix1, matrix2);
    PrintMatrices(matrix1, matrix2, product);
}
else
{
    Console.WriteLine("Матрицы не согласованы, вычислить произведение невозможно. Начните заново.");
}

bool IsMatricesConsistent(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(1) == matrix2.GetLength(0);
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            product[i, j] = MultiplyAndSumElements(i, j);
        }
    }
    return product;
}

int MultiplyAndSumElements(int row, int column)
{
    int sum = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        sum += matrix1[row, i] * matrix2[i, column];
    }
    return sum;
}

int[,] InterfaceCollectsMarix(string letter)
{
    Console.WriteLine($"Введите высоту матрицы {letter}.");
    int height = int.Parse(Console.ReadLine());
    Console.WriteLine($"Введите ширину матрицы {letter}.");
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

void PrintMatrices(int[,] matrix1, int[,] matrix2, int[,] product)
{
    Console.Clear();
    Console.WriteLine("Матрица A:");
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i, j],3} ");
        }
        Console.WriteLine();
    }
    Console.SetCursorPosition(matrix1.GetLength(1) * 3 + 7, 0);
    Console.WriteLine("Матрица B:");
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.SetCursorPosition(matrix1.GetLength(1) * 3 + 7 + 4 * j, i + 1);
            Console.Write($"{matrix2[i, j],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Произведение матриц A и B:");
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            Console.Write($"{product[i, j],3} ");
        }
        Console.WriteLine();
    }
}