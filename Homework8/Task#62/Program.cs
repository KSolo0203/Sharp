// Заполните спирально массив 4 на 4.

int[,] matrix = new int[,] {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // решение работает для матрицы любого размера, в том числе неквадратной.
                            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};

int value = 0;  // переменная для порождения возрастающего целочисленного значения для присвоения элементам матрицы.
int[] point = new int[] { 0, 0 }; // координаты элемента, который будет заполнен.
int[] modificatorcounter = new int[] { -1, 0 }; // закручивание спирали против часовой стрелки modificatorcounter[1] = 1 && строку 51 перенести в строку 56.
int[] test = new int[] { 0, 0 };                // временная переменная для функции, определяющей, как изменять координаты point[].
FillMatrixHelically(point);
PrintMatrix(matrix);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine();
    }
}

void FillMatrixHelically(int[] point)
{
    matrix[point[0], point[1]] = GenerateIncreasingValue(ref value);
    ModifyPoint(point);
    if (matrix[point[0], point[1]] == 0)
    {
        FillMatrixHelically(point);
    }
    else
    {
        Console.WriteLine($"Массив заполнен");
    }
}

int[] ModifyPoint(int[] point)
{
    Array.Copy(point,test,point.Length); // переменная, зондирующая следующую клетку.
    test[modificatorcounter[1]] += modificatorcounter[0];
    if (test[modificatorcounter[1]] == matrix.GetLength(modificatorcounter[1]) || // если она за пределом массива
        test[modificatorcounter[1]] < 0 || matrix[test[0],test[1]] != 0)            // или уже заполнена
    {
        if (modificatorcounter[1] == 0)
        {
            modificatorcounter[1] = 1;                                              // то сменить направление итерирования со столбца на строку
            modificatorcounter[0] = -modificatorcounter[0];                         // и наоборот
        }
        else
        {
            modificatorcounter[1] = 0;
            
        }
    }
    point[modificatorcounter[1]] += modificatorcounter[0];
    return point;
}

int GenerateIncreasingValue(ref int value)
{
    value++;
    return value;
}