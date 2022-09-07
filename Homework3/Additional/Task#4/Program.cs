// Пользователь вводит возраст. Если ему меньшу 18 лет или больше 65 лет,
// программа говорит, что для него есть скидка.

Console.WriteLine("Сколько вам лет?");
string answer = Console.ReadLine();
if (int.TryParse(answer, out int x)) {
    if (x >= 0 && x < 90) {
        if (x >= 0 && x < 14)
            Console.Write("Hasta la vista, baby!");
        else if ((x >= 14 && x < 18) || x > 65)
            Console.Write("У нас для вас скидка!"); 
        else 
            Console.Write("Заходите, посмотрите на наш товар!");
    }
    if (x >= 90)
        Console.Write("У меня тут где-то для вас был эйджизм...");
    if (x < 0)
        Console.Write("Нарушение пространственно-временного континуума!");
}
else
    Console.WriteLine($"В следующий раз вводите число!");