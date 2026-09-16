using System;
namespace Task3
{
  class Program
{
    public static int[] GetUnique(int[] source)
    {
        int[] temp = new int[source.Length];
        int count = 0;

        for (int i = 0; i < source.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < count; j++)
            {
                if (temp[j] == source[i])
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                temp[count] = source[i];
                count++;
            }
        }

        int[] result = new int[count];
        for (int i = 0; i < count; i++)
            result[i] = temp[i];
        return result;
    }

    static void Main()
    {
        int[] source = { 1, 2, 2, 3, 4, 4, 4, 5 };
        Console.WriteLine("Исходный: " + string.Join(", ", source));

        int[] unique = GetUnique(source);
        Console.WriteLine("Уникальные: " + string.Join(", ", unique));
    }
}
}
