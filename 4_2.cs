using System;

class Program
{
    static void Main(string[] args)
    {
        int x = GetIntFromUser("Введите первое число (x): ");
        int y = GetIntFromUser("Введите второе число (y): ");

        string result = makeDecision(x, y);

        Console.WriteLine(result);

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    public static string makeDecision(int x, int y)
    {
        if (x > y)
        {
            return $"{x} > {y}";
        }
        else if (x < y)
        {
            return $"{x} < {y}";
        }
        else
        {
            return $"{x} == {y}";
        }
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
