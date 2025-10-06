using System;

class SumOfNaturalNumbers
{
    static void Main()
    {
        Console.Write("Enter a number (n): ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Sum of numbers from 1 to {n} = {sum}");
    }
}
