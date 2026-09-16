using System;
namespace Task2
{
   class Program
{
    static void Main()
    {
        int n;
        while (true)
        {
            Console.Write("Введите количество элементов: ");
            string input = Console.ReadLine() ?? "";
            if (int.TryParse(input, out n) && n > 0) break;
            Console.WriteLine("Ошибка: введите положительное целое число!");
        }

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"Элемент [{i}]: ");
                try
                {
                    arr[i] = int.Parse(Console.ReadLine() ?? "");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: число слишком большое!");
                }
            }
        }

        Console.WriteLine("Исходный массив: " + string.Join(", ", arr));

        int[] reversed = new int[n];
        for (int i = 0; i < n; i++)
            reversed[i] = arr[n - 1 - i];
        Console.WriteLine("Обратный порядок: " + string.Join(", ", reversed));

        int[] sorted = (int[])arr.Clone();
        Array.Sort(sorted);
        Console.WriteLine("Отсортированный: " + string.Join(", ", sorted));

        int max = arr[0], min = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
        Console.WriteLine("Максимум: " + max);
        Console.WriteLine("Минимум: " + min);
    }
}
}
