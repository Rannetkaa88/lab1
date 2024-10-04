using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите один символ (или введите 'exit' для завершения):");

            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (input.Length == 1)
            {
                char character = input[0];
                bool result = isUpperCase(character);

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
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите ровно один символ.");
            }
        }
    }

    public static bool isUpperCase(char x)
    {
        return x >= 'A' && x <= 'Z';
    }
}
