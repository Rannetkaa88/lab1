using System;

class Program
{
    static void Main(string[] args)
    {
        int x = GetIntFromUser("Введите ваш возраст (x): ");

        string result = age(x);

        Console.WriteLine(result);

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    public static string age(int x)
    {
        string word;

        if (x % 10 == 1 && x % 100 != 11)
        {
            word = "год";
        }
        else if (x % 10 >= 2 && x % 10 <= 4 && (x % 100 < 12 || x % 100 > 14))
        {
            word = "года";
        }
        else
        {
            word = "лет";
        }

        return $"{x} {word}"; 
    }

    private static int GetIntFromUser(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (int.TryParse(input, out number)) 
            {
                return number; 
            }
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число."); 
        }
    }
}
