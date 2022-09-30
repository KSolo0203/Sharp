// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

float[,] coeffs = {{0,0},   // k1 b1
                   {0,0}};  // k2 b2

Interface(coeffs);
CalculateIfConsistent(coeffs);

float[,] Interface(float[,] coeffs)
{
    for (int i = 0; i < coeffs.GetLength(0); i++)
    {
        Console.WriteLine($"Введите через пробел коэффициенты k и b для {(i+1)} прямой.");
        string[] parts = Console.ReadLine().Split(" ");
        coeffs[i,0] = float.Parse(parts[0]);
        coeffs[i,1] = float.Parse(parts[1]);
    }
    return coeffs;
}

void CalculateIfConsistent(float[,] matrix)
{
    if (matrix[0,0] == matrix[1,0] && matrix[0,1] == matrix[1,1])
    {
        Console.WriteLine($"Объявленные коэффициенты описывают одну единственную прямую.");
    }
    else if (matrix[0,0] == matrix[1,0])
    {
        Console.WriteLine($"Прямые с вышеобъявленными коэффициентами параллельны, не пересекаются.");
    }
    else
    {
        float x = (matrix[1,1]-matrix[0,1])/(matrix[0,0]-matrix[1,0]);
        float y = (matrix[0,0]*x + matrix[0,1]);
        Console.WriteLine($"Прямые с вышеобъявленными коэффициентами пересекаются в точке с координатами ({x:F2}, {y:F2}).");
    }
}