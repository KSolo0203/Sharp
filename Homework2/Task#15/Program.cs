// Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Какой по счету день недели вывести на экране?");

Console.WriteLine("Введите цифру");

int dayofweek = int.Parse(Console.ReadLine());

switch (dayofweek) {
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine($"Это не выходной, увы!");
        break;
//    case 2:
//        Console.WriteLine($"Вторник это не выходной.");
//        break;
//   case 3:
//        Console.WriteLine($"Среда это не выходной.");
//        break;
//    case == 4:
//        Console.WriteLine($"Четверг это не выходной.");
//        break;
//    case == 5:
//        Console.WriteLine($"Пятница - сокращенный рабочий день.");
//        break;
    case 6:
    case 7:
        Console.WriteLine($"УРРРА! Выходные!");
        break;
//    case == 7:
//        Console.WriteLine($"Православный люд в воскресение не работает!");
//       break;  
    default:
        Console.WriteLine("Пардон, я вас не понял");
        break;
}
