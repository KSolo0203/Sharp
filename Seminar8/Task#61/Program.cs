// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.

Console.Clear();

// const int cellWidth = 4;
MakePascalTriangle(AskHowMany());

int AskHowMany()
{
    Console.WriteLine("Введите желаемое количество строк треугольника Паскаля.");
    int height = int.Parse(Console.ReadLine());
    return height;
}

void MakePascalTriangle(int height)
{
    int x = 60, y = 0;
    List<int> row = new List<int> { 1 };
    while (y < height)
    {
        Console.SetCursorPosition(x, y);
        PrintRow(row);
        Binom(row);
        x -= 1;
        y++;
    }
}

List<int> Binom(List<int> row)
{
    if (row.Count == 1)
    {
        row.Add(1);
    }
    else
    {
        List<int> temp = new List<int>(row);
        row[0] = 1;
        for (int i = 1; i < temp.Count; i++)
        {
            row[i] = (temp[i - 1] + temp[i]);
        }
        row.Add(1);
    }
    return row;
}

void PrintRow(List<int> row)
{
    {
        foreach (int element in row)
        {
            //if (element % 2 != 0)
            //{ 
            //    Console.Write($"* ", cellWidth);
            //}
            //else
            //{
            //    Console.Write($"  ", cellWidth);
            //}
            Console.Write($"{element}");
        }
    }
}