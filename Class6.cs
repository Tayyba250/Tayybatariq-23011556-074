using System;

class FactorialCalculator
{
    static void Main()
    {
        Console.Write("Enter a number to find its factorial: ");
        int number = int.Parse(Console.ReadLine());

        int factorial = 1;
        int i = 1;

        while (i <= number)
        {
            factorial *= i;
            i++;
        }

        Console.WriteLine($"Factorial of {number} = {factorial}");
    }
}
