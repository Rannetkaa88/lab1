using System;

class Program
{
    static void Main(string[] args)
    {
        int x = GetIntFromUser("Введите основание степени (x): ");
        int y = GetIntFromUser("Введите показатель степени (y): ");
        int result = pow(x, y);
        Console.WriteLine($"{x} в степени {y} равно {result}");
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    public static int pow(int x, int y)
    {
        int result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
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
