using System;

Console.WriteLine("Название какого по счету дня недели вывести на экране?");

Console.WriteLine("Введите цифру");

string userIn = Console.ReadLine();

int number = int.Parse(userIn);

if (number == 1) {

    Console.WriteLine($"{userIn}-й день недели это понедельник");
    
}

else if (number == 2) {

    Console.WriteLine($"{userIn}-й день недели это вторник");
    
}

else if (number == 3) {

    Console.WriteLine($"{userIn}-й день недели это среда");
    
}

else if (number == 4) {

    Console.WriteLine($"{userIn}-й день недели это четверг же!");
    
}

else if (number == 5) {

    Console.WriteLine($"{userIn}-й день недели это тяпница");
    
}

else if (number == 6) {

    Console.WriteLine($"{userIn}-й день недели это шаббат");
    
}

else if (number == 7) {

    Console.WriteLine($"{userIn}-й день недели это воскресение");
    
}

else {

    Console.WriteLine("Пардон, я вас не понял");
}