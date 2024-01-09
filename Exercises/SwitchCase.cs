/*Conditional statement exercises:
Conditional statement exercise 1
class SwitchCase
{
    static void Main()
    {
        int userInput1;
        int userInput2;
        
        Console.WriteLine("Input two numbers to check if they are equal to each other or not.");

        Console.WriteLine("Input the first number");
        userInput1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the second number");
        userInput2 = Convert.ToInt32(Console.ReadLine());

        switch (userInput1 == userInput2)
        {
            case true:
                Console.WriteLine($"{userInput1} is equal to {userInput2}");
                break;
            case false:
                Console.WriteLine($"{userInput1} is not equal to {userInput2}");
                break;
        }

    }
}

Conditional statement exercise 2
class SwitchCase
{
    static void Main()
    {
        int userInput;

        Console.WriteLine("Input a number to check if it is odd or even");
        userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput % 2 == 0)
        {
            Console.WriteLine($"{userInput} is even");
        }
        else
        {
            Console.WriteLine($"{userInput} is odd");
        }
    }
}
*/

/* Conditional statement exercise 2

using System;

class SwitchCase
{
    static void Main()
    {
        double a, b, c;

        Console.WriteLine("Input a number for the values a, b, and c for a quadratic equation.");

        Console.WriteLine("Input a value for a");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input a value for b");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input a value for c");
        c = Convert.ToDouble(Console.ReadLine());

        double d = b * b - 4 * a * c;

        if (d > 0)
        {
            double root1 = (-b + Math.Sqrt(d)) / (2 * a);
            double root2 = (-b - Math.Sqrt(d)) / (2 * a);

            Console.WriteLine($"Root 1: {root1}");
            Console.WriteLine($"Root 2: {root2}");
        }
        else if (d == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"Double Root: {root}");
        }
        else
        {
            Console.WriteLine("No real roots. Roots are complex.");
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-d) / (2 * a);
            Console.WriteLine($"Root 1: {realPart} + {imaginaryPart}i");
            Console.WriteLine($"Root 2: {realPart} - {imaginaryPart}i");
        }

        Console.ReadLine();
    }
}
*/