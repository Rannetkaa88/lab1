using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число (или введите 'exit' для завершения):");

            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (int.TryParse(input, out int number))
            {

                bool result = isPositive(number);

                if (result)
                {
                    Console.WriteLine("Число положительное.");
                }
                else
                {
                    Console.WriteLine("Число не положительное.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число:");
            }
        }
    }

    public static bool isPositive(int x)
    {
        return x > 0;
    }
}
