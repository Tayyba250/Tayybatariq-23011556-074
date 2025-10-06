using System;

class MultiplicationTable
{
    static void Main()
    {
        Console.Write("Enter a number to display its multiplication table: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nMultiplication Table of {number}");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}
