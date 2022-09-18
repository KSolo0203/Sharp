// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

float[,] coeffs = {{0,0},
                   {0,0}};

Interface(coeffs);
float x = (coeffs[1,1]-coeffs[0,1])/(coeffs[0,0]-coeffs[1,0]);
float y = (coeffs[0,0]*x + coeffs[0,1]);
Console.WriteLine($"Прямые с вышеобъявленными коэффициентами пересекаются в точке с координатами {x},{y}");

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