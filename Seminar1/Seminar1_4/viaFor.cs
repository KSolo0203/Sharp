Console.WriteLine ("Введите некоторое число");

string userIn = Console.ReadLine ();

int number = int.Parse (userIn);

int count = number;

number = -1 * number;

for (int i = number; i <= count; i++)
{
    Console.Write ($"{i} ");
}