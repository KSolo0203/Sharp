// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] matrix = InterfaceCollectsMarix();
FillMatrixRandom(matrix);
string[] input = CollectIJ();
Console.WriteLine($"Исходная матрица:");
PrintMatrix(matrix);
int i = int.Parse(input[0]);
int j = int.Parse(input[1]);
if (IsSuchElement(input,matrix))
{
    Console.WriteLine($"Значение элемента [{i},{j}] равно {matrix[i,j]}.");
}
else
{
    Console.WriteLine($"Элемента [{i},{j}] в данной матрице не существует.");
}
        
string[] CollectIJ()
{
    Console.WriteLine($"Введите через пробел индексы желаемого элемента: i по вертикали и j по горизонтали,");
    Console.WriteLine($"с учётом 0, который есть начало нумерации, затем нажмите ВВОД.");
    return Console.ReadLine().Split();
}

bool IsSuchElement(string[] input, int[,] matrix)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;
    } 
}

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
            matrix[i,j] = new Random().Next(-9,10);
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