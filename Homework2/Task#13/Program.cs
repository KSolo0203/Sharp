// Программа выводит j-ую цифру заданного числа или сообщает, что такой цифры (порядка) нет.

Console.WriteLine("Введите число"); // возьмем по модулю, чтобы отрицательные числа тоже годились к анализу
int N = Math.Abs(int.Parse(Console.ReadLine())); // для большей наглядности можно увеличить число, но тип int слишком мал 
Console.WriteLine("Введите номер порядка, считая от единиц, откуда необходимо извлечь цифру");
int j = int.Parse(Console.ReadLine());

int digit = 0;

if ((N / Math.Pow(10,j-1)) < 1) Console.WriteLine("Число слишком мало и не имеет столько порядков!");
else {
    for (int i = 1; i <= j; i++) {
        digit = N % 10;
        N = N / 10;
    }
    Console.WriteLine($"{j}-ая цифра этого числа это {digit}");
}