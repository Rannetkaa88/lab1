using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = GetValidInput("Первое число: ");
        int num2 = GetValidInput("Второе число: ");

        int result = lastNumSum(num1, num2);
        Console.WriteLine($"Результат сложения последних цифр: {result}");

        Console.WriteLine("Нажмите любую клавишу для завершения...");
        Console.ReadKey();
    }

    public static int lastNumSum(int a, int b)
    {
        return (a % 10) + (b % 10);
    }

    public static int GetValidInput(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Ошибка! Пожалуйста, введите корректное целое число.");
            }
        }
    }
}
