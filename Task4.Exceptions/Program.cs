using System;
namespace Task4
{
   class Program
{
    static void Main()
    {
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            while (true)
            {
                Console.Write($"Введите элемент [{i}]: ");
                try
                {
                    arr[i] = int.Parse(Console.ReadLine() ?? "");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                }
            }
        }

        while (true)
        {
            Console.Write("Введите индекс для вывода (0-4): ");
            try
            {
                int index = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine("Элемент: " + arr[index]);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите целое число!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Число слишком большое!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: Индекс вне границ массива.");
            }
        }
    }
}
}
