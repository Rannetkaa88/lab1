using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = GetIntArrayFromUser("Введите числа через запятую: ");
        int x = GetIntFromUser("Введите число для поиска: ");
        int index = findLast(arr, x);
        Console.WriteLine(index);
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    public static int findLast(int[] arr, int x)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
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

    private static int[] GetIntArrayFromUser(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            string[] parts = input.Split(',');

            int[] arr = new int[parts.Length];
            bool validInput = true;

            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i].Trim(), out arr[i]))
                {
                    validInput = false;
                    break;
                }
            }

            if (validInput)
            {
                return arr;
            }
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите числа через запятую.");
        }
    }
}
