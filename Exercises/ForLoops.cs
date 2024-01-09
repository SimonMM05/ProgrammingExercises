/*
using System;

class ForLoops
{
    static void Main()
    {
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine(i);
        }
    }
}
*/

/* For loop exercise 1

using System;

class ForLoops
{
    static void Main()
    {
        for (int i = 1; i<=10; i++)
        {
            Console.WriteLine(i);
        }
    }
}
*/

/* For loop exercise 2

using System;

class ForLoops
{
    static int sum = 0;

    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Console.WriteLine($"{sum}");
        Console.ReadLine();
    }
}
*/

/* For loop exercise 3

using System;

class ForLoops
{
    

    static void Main()
    {
        Console.WriteLine("Enter a number to find the sum of the numeric values");
        int sum = 0;
        int input = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= input; i++)
        {
            sum += i;
        }
        Console.WriteLine($"{sum}");
        Console.ReadLine();
    }
}
*/

// For loop exercise 6

using System;

class ForLoops
{
    static void Main()
    {
        Console.WriteLine("Input a number to display the multiplication table of that number.");
        int input = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            int product = input*i;
            Console.WriteLine($"{input} * {i} = {product}");
        }
        Console.ReadLine();
    }
}
