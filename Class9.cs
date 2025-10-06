using System;

class CountEvenOdd
{
    static void Main()
    {
        int[] numbers = new int[10];
        int evenCount = 0, oddCount = 0;

        Console.WriteLine("Enter 10 integers:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            if (numbers[i] % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine($"Even numbers: {evenCount}");
        Console.WriteLine($"Odd numbers: {oddCount}");
    }
}
