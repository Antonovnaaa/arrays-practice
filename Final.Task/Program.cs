using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите массив: ");
        string line = Console.ReadLine() ?? "";
        string[] parts = line.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

        int[] arr = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            if (!int.TryParse(parts[i], out arr[i]))
            {
                Console.WriteLine("Ошибка: все элементы должны быть целыми числами.");
                return;
            }
        }

        Console.WriteLine("Массив: " + string.Join(", ", arr));

        bool isPalindrome = true;
        for (int i = 0; i < arr.Length / 2; i++)
        {
            if (arr[i] != arr[arr.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
            Console.WriteLine("Массив — палиндром");
        else
            Console.WriteLine("Массив — не палиндром");
    }
}
