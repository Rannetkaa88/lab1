using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = InputArray("первый");
        int[] arr2 = InputArray("второй");
        
        int[] resultArray = concat(arr1, arr2);
        
        Console.WriteLine("Результирующий массив:");
        foreach (var item in resultArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Нажмите любую клавишу для завершения...");
        Console.ReadKey();
    }

    static int[] InputArray(string arrayName)
    {
        Console.WriteLine($"Введите количество элементов в {arrayName} массиве:");
        int size;
        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.WriteLine("Введите корректное положительное число.");
        }

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Введите элемент {i + 1} {arrayName} массива:");
            while (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Введите корректное целое число.");
            }
        }
        return arr;
    }

    public static int[] concat(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];
        Array.Copy(arr1, result, arr1.Length);
        Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);
        return result;
    }
}
