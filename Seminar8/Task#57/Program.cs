// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.

using System;
using System.Collections.Generic;

int[,] matrix = InterfaceCollectsMarix(); // пустая матрица
FillMatrixRandom(matrix); // заполняем числами от 0 до 10
Console.WriteLine($"Исходная матрица:");
PrintMatrix(matrix); // выводим ее на экран
WhatElements(matrix);

// ElementCounter(matrix, WhatElements(matrix));

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
            matrix[i, j] = new Random().Next(0, 10);
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

// List<int> WhatElements(int[,] matrix) // пробегается по матрице и вписывает в лист встречающиеся значения
// {
//     List<int> @checked = new List<int>();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (!@checked.Contains(matrix[i, j])) // если НЕ содержится
//             {
//                 @checked.Add(matrix[i, j]);
//             }
//         }
//     }
//     return @checked; // эт для экранирования зарезервированного имени 
// }

// void ElementCounter(int[,] matrix, List<int> @checked) // теперь просим пройтись по матрице и сравнить с листом
// {
//     foreach (int element in @checked) // для каждого (уникального) элемента в листе
//     {
//         int counter = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {

//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (element == matrix[i, j])
//                 {
//                     counter++; // если встречаем элемент - плюсуем
//                 }
//             }
//         }
//         Console.WriteLine($"Элементов, равных {element} в данной матрице: {counter}.");
//     }
// }  // O(n^3)

void WhatElements(int[,] matrix)
{
    Dictionary<int, int> elementCounter = new Dictionary<int, int>();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (elementCounter.ContainsKey(matrix[i, j]))
            {
                elementCounter[matrix[i, j]]++;
            }
            else
            {
                elementCounter.Add(matrix[i, j],1);
            }
        }
    }
    foreach (KeyValuePair<int, int> element in elementCounter)
    {
        Console.WriteLine($"Элементов, равных {element.Key} в данной матрице: {element.Value}.");
    }
}