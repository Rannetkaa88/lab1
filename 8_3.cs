using System;

class Program
{
    static void Main(string[] args)
    {
        int height = GetIntFromUser("Введите высоту треугольника (x): ");
        leftTriangle(height);
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    public static void leftTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    private static int GetIntFromUser(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (int.TryParse(input, out number) && number > 0)
            {
                return number;
            }
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
        }
    }
}
