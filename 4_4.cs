using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = GetIntArrayFromUser("Введите числа через запятую: ");
        int x = GetIntFromUser("Введите число для вставки: ");
        int pos = GetIntFromUser("Введите позицию для вставки: ");

        int[] newArray = add(arr, x, pos);
        Console.WriteLine("Новый массив: " + string.Join(", ", newArray));
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    public static int[] add(int[] arr, int x, int pos)
    {
        if (pos < 0 || pos > arr.Length)
        {
            Console.WriteLine("Некорректная позиция. Элемент не будет добавлен.");
            return arr;
        }

        int[] newArray = new int[arr.Length + 1];
        for (int i = 0; i < pos; i++)
        {
            newArray[i] = arr[i];
        }
        newArray[pos] = x;
        for (int i = pos; i < arr.Length; i++)
        {
            newArray[i + 1] = arr[i];
        }
        return newArray;
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
