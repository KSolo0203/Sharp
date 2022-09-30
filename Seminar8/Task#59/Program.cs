// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку
// и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] matrix = InterfaceCollectsMarix();
FillMatrixRandom(matrix);
Console.Clear();
Console.WriteLine($"Исходная матрица:");
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(Minorize(matrix));

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
            matrix[i, j] = new Random().Next(-99, 100);
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

int[,] Minorize(int[,] matrix) // Можно было бы найти минимум ранее для экономии O(n),
{                              // но это бы нарушило
    int[] min = new int[] { matrix[0, 0], 0, 0, 0 }; // логическую целостность функции Minorize.               
    int[,] minor = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Сначала ищем минимум матрицы
        {
            if (min[0] > matrix[i, j])
            {
                min[0] = matrix[i, j];
                min[1] = i;
                min[2] = j;
                min[3] = 1;
            }
            else if (min[0] == matrix[i,j])
            {
                min[3]++; // считаем количество минимумов
            }
        }

    }
    for (int i = 0; i < matrix.GetLength(0); i++) // потом копируем массив
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < min[1] && j < min[2])
            {
                minor[i, j] = matrix[i, j];
            }
            else if (i < min[1] && j > min[2])
            {
                minor[i, j - 1] = matrix[i, j];
            }
            else if (i > min[1] && j < min[2])
            {
                minor[i - 1, j] = matrix[i, j];
            }
            else if (i > min[1] && j > min[2])
            {
                minor[i - 1, j - 1] = matrix[i, j];
            }
        }
    }
    if (min[3] == 1) // защита от неединственного минимума
    {
        Console.WriteLine($"Минимум в матрице: {min[0]}, в строке {min[1] + 1}, в столбце {min[2] + 1}.");
        Console.WriteLine();
        Console.WriteLine($"Матрица после воздействия:");
        return minor;
    }
    else
    {
        Console.WriteLine($"Минимум матрицы найден в нескольких элементах, перезапустите программу.");
        return matrix;
    }
}