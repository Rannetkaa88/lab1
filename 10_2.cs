using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите название дня недели: ");
        string day = Console.ReadLine();

        printDays(day);

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    public static void printDays(string x)
    {
        string day = x.ToLower();

        switch (day)
        {
            case "понедельник":
                Console.WriteLine("Понедельник");
                Console.WriteLine("Вторник");
                Console.WriteLine("Среда");
                Console.WriteLine("Четверг");
                Console.WriteLine("Пятница");
                Console.WriteLine("Суббота");
                Console.WriteLine("Воскресенье");
                break;

            case "вторник":
                Console.WriteLine("Вторник");
                Console.WriteLine("Среда");
                Console.WriteLine("Четверг");
                Console.WriteLine("Пятница");
                Console.WriteLine("Суббота");
                Console.WriteLine("Воскресенье");
                break;

            case "среда":
                Console.WriteLine("Среда");
                Console.WriteLine("Четверг");
                Console.WriteLine("Пятница");
                Console.WriteLine("Суббота");
                Console.WriteLine("Воскресенье");
                break;

            case "четверг":
                Console.WriteLine("Четверг");
                Console.WriteLine("Пятница");
                Console.WriteLine("Суббота");
                Console.WriteLine("Воскресенье");
                break;

            case "пятница":
                Console.WriteLine("Пятница");
                Console.WriteLine("Суббота");
                Console.WriteLine("Воскресенье");
                break;

            case "суббота":
                Console.WriteLine("Суббота");
                Console.WriteLine("Воскресенье");
                break;

            case "воскресенье":
                Console.WriteLine("Воскресенье");
                break;

            default:
                Console.WriteLine("это не день недели");
                break;
        }
    }
}
