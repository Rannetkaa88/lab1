using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = InputArray();
        int[] resultArray = deleteNegative(arr);

        Console.WriteLine("Массив без отрицательных значений:");
        foreach (var item in resultArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Нажмите любую клавишу для завершения...");
        Console.ReadKey();
    }

    static int[] InputArray()
    {
        Console.WriteLine("Введите количество элементов в массиве:");
        int size;
        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.WriteLine("Введите корректное положительное число.");
        }

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Введите элемент {i + 1} массива:");
            while (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Введите корректное целое число.");
            }
        }
        return arr;
    }

    public static int[] deleteNegative(int[] arr)
    {
        List<int> positiveList = new List<int>();
        foreach (int number in arr)
        {
            if (number >= 0)
            {
                positiveList.Add(number);
            }
        }
        return positiveList.ToArray();
    }
}
