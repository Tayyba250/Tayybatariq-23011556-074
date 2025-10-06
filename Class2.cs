using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation: +, -, *, /");
        char operation = Convert.ToChar(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine($"Result: {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"Result: {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"Result: {num1 * num2}");
                break;
            case '/':
                if (num2 != 0)
                    Console.WriteLine($"Result: {num1 / num2}");
                else
                    Console.WriteLine("Error! Division by zero.");
                break;
            default:
                Console.WriteLine("Invalid operation!");
                break;
        }
    }
}
