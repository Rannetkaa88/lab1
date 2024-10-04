using System;

class Program
{
    static void Main(string[] args)
    {
        int x = GetIntFromUser("Введите первое число (x): ");
        int y = GetIntFromUser("Введите второе число (y): ");
        int z = GetIntFromUser("Введите третье число (z): ");

        bool result = sum3(x, y, z);

        if (result)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    public static bool sum3(int x, int y, int z)
    {
        return (x + y == z) || (x + z == y) || (y + z == x);
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
