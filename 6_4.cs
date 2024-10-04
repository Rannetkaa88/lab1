using System;

class Program
{
    static void Main(string[] args)
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
            Console.WriteLine($"Введите элемент {i + 1}:");
            while (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Введите корректное целое число.");
            }
        }

        reverse(arr);
        Console.WriteLine("Массив задом наперед:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine(); // Переход на новую строку
        Console.WriteLine("Нажмите любую клавишу для завершения...");
        Console.ReadKey(); // Ожидание нажатия клавиши
    }

    public static void reverse(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
    }
}
