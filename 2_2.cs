using System;

class Program
{
    static void Main(string[] args)
    {
        int x = GetIntFromUser("Введите делимое (x): ");
        int y = GetIntFromUser("Введите делитель (y): ");

        double result = safeDiv(x, y);

        Console.WriteLine($"Результат деления {x} на {y}: {result}");

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    public static double safeDiv(int x, int y)
    {
        if (y == 0)
        {
            return 0; 
        }
        return (double)x / y; 
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
