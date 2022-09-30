// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();
int[,,] matrix = InterfaceCollectsMarix();
Fill3AxialMatrixNonrepeatingDoubleDigit(matrix); // :)))
Console.Clear();
if (AreValuesDoubleDigit(matrix))
{
    Console.WriteLine("Трёхмерная матрица, заполненная неповторяющимися двузначными числами:");
    Print3AxialMatrix(matrix);
}
else
{
    Console.WriteLine("Трёхмерная матрица с вышеуказанными размерами не может быть");
    Console.WriteLine("наполнена неповторяющимися двузначными числами");
}


int[,,] InterfaceCollectsMarix()
{
    Console.WriteLine("Опишем трёхмерную матрицу.");
    Console.WriteLine("Введите высоту матрицы.");
    int height = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите ширину матрицы.");
    int width = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество страниц матрицы.");
    int pages = int.Parse(Console.ReadLine());
    return new int[height, width, pages];
}

bool AreValuesDoubleDigit(int[,,] matrix)
{
    return (matrix.GetLength(0)*matrix.GetLength(1)*matrix.GetLength(2) < 180);
}

int[,,] Fill3AxialMatrixNonrepeatingDoubleDigit(int[,,] matrix)
{
    int value = -99;
    for (int i = 0; i < matrix.GetLength(2); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (value > -10 && value < 10)
                {
                    value = 10;
                }
                    matrix[j, k, i] = value;
                    value++;
                
            }
        }
    }
    return matrix;
}

void Print3AxialMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(2); i++)
    {
        Console.WriteLine($"{i}-ая страница матрицы:");
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.Write($"{matrix[j, k, i],3}[{j},{k}]"); // оставим индексы i и j, k выведем отдельно для наглядности.
            }
            Console.WriteLine();
        }
    }
}