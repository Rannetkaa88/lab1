using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите два целых числа, разделённых пробелом (или введите 'exit' для завершения):");

            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            string[] parts = input.Split(' ');

            if (parts.Length == 2 && int.TryParse(parts[0], out int num1) && int.TryParse(parts[1], out int num2))
            {
                bool result = isDivisor(num1, num2);

                if (result)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите два целых числа.");
            }
        }
    }

    public static bool isDivisor(int a, int b)
    {
        return (b != 0 && a % b == 0) || (a != 0 && b % a == 0);
    }
}
