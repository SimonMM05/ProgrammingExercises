
/* Recursion exercise 1
using System;

class Recursions
{
    static void Main()
    {
        Console.WriteLine("Enter a number to print that many numbers.");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The numbers are: ");
        PrintNumbers(1, number);
    }

    static void PrintNumbers(int result, int number)
    {
        if (result < number)
        {
            Console.Write(result + " ");
            PrintNumbers(result + 1, number);
        }
        else if (result == number)
        {
            Console.Write(result + ".");
        }
    }
}
*/

/* Recursion exercise 2

using System;

class Recursion
{
    static void Main()
    {
        Console.WriteLine("Enter a number to print that many numbers to 1.");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The numbers are: ");
        PrintNumbers(n);
    }

    static void PrintNumbers(int n)
    {
        if (n > 1)
        {
            Console.Write(n + " ");
            PrintNumbers(n - 1);
        }
        else if (n == 1)
        {
            Console.Write(n + ".");
        }
    }
}
*/

/* REcursion exercise 3

using System;
class Recursion
{
    static void Main()
    {
        Console.WriteLine("Enter a number to calculate the sum of 1 to that number.");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("The sum of the numbers are: " + PrintSum(n));
    }
    static int PrintSum(int n)
    {
        if (n > 1)
        {
            return n + PrintSum(n - 1);
        }
        else
        {
            return 1;
        }
    }
}
*

/* Recursion exercise 4: Write a program in C# Sharp to display the individual digits of a given number using recursion. 

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Write any number!");

        int number = Convert.ToInt32(Console.ReadLine());
        Recursion(number);
    }

    public static void Recursion(int i)
    {
        if (i >= 10)
        {
            Recursion(i/10);
        }
        Console.Write(i % 10 + " ");
    }
}
*/

/* Recursion exercises 5: Write a program in C# Sharp to count the number of digits in a number using recursion. 

using System;

public class Recursion
{
    public static void Main()
    {
        Console.WriteLine("This program writes the number of digits in a given number.");
        double n = Convert.ToDouble(Console.ReadLine());
        
        int numberOfDigits = CountDigits(n);
        Console.WriteLine($"Number of digits in {n} is: {numberOfDigits}");
    }

    public static int CountDigits(double n)
    {
        if (Math.Abs(n) < 10)
        {
            return 1;
        }
        else
        {
            return 1 + CountDigits(n / 10);
        }
    }
}
*/

// Recursion exercise 6: Write a program in C to print even or odd numbers in a given range using recursion.

using System;

public class Recursion
{
    public static void Main()
    {
        Console.WriteLine("This program prints the even and odd numbers from a range e.g. 1-20");
        double n = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"The even numbers are: ");
        PrintEven(n);

        Console.WriteLine($"\n\nThe odd numbers are: ");
        PrintOdd(n);
    }

    public static void PrintEven(double n)
    {
        if (n <= 0)
            return;

        if (n % 2 == 0)
        {
            Console.Write(n + " ");
        }

        PrintEven(n - 1);
    }
    public static void PrintOdd(double n)
    {
        if (n <= 0)
            return;

        if (n % 2 != 0)
        {
            Console.Write(n + " ");
        }

        PrintOdd(n - 1);
    }
}



