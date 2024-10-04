using System;

class Program
{
    static void Main(string[] args)
    {
        int x = GetIntFromUser("Введите целое число (x): ");

        string result = reverseListNums(x);

        Console.WriteLine($"Числа от {x} до 0: {result}");

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    public static string reverseListNums(int x)
    {
        string result = ""; 

       
        for (int i = x; i >= 0; i--)
        {
            result += i;
            if (i > 0) 
            {
                result += ", ";
            }
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
