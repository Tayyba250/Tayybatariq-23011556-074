using System;

class SearchElement
{
    static void Main()
    {
        int[] numbers = new int[10];
        Console.WriteLine("Enter 10 integers:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter a number to search: ");
        int search = int.Parse(Console.ReadLine());

        bool found = false;
        for (int i = 0; i < 10; i++)
        {
            if (numbers[i] == search)
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine($"{search} exists in the array.");
        else
            Console.WriteLine($"{search} not found in the array.");
    }
}
