using System;

class Program
{
    static void Main(string[] args)
    {
        int number = GetIntFromUser("Введите целое число: ");
        bool result = equalNum(number);
        Console.WriteLine(result);
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    public static bool equalNum(int x)
    {
        string str = Math.Abs(x).ToString();
        char firstDigit = str[0];
        foreach (char digit in str)
        {
            if (digit != firstDigit)
            {
                return false;
            }
        }
        return true;
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
