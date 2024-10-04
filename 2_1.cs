using System;

class Program
{
    public int SumLastNums(int x)
    {
        x = Math.Abs(x);

        int lastDigit = x % 10;

        int secondLastDigit = (x / 10) % 10;

        return lastDigit + secondLastDigit;
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        int number;

        while (true)
        {
            Console.Write("Введите целое число с не менее чем двумя цифрами: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out number) && Math.Abs(number) >= 10)
            {
                int sum = program.SumLastNums(number);
                Console.WriteLine($"Сумма двух последних цифр числа {number} равна {sum}");
                break;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число с не менее чем двумя цифрами.");
            }
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
