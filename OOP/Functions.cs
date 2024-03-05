/* Function exercise 1

using System;

class Functions
{
    public static void welcome()
    {
        Console.WriteLine("Welcome everyone");
    }

    public static void haveAgood()
    {
        Console.WriteLine("Have a nice day idiot");
    }

    public static void Main()
    {
        welcome();

        haveAgood();

        Console.WriteLine("");
    }

}
*/

/* Function exercise 2
using System;

class Functions
{
    public static void number1(int num1)
    {
        Console.WriteLine("The first number is " + num1 + "!");
    }

    public static void number2(int num2)
    {
        Console.WriteLine("The second number is " + num2 + "!");
    }

    public static void sum(int num1, int num2)
    {
        int total = num1 + num2;
        Console.WriteLine("The sum of the two numbers is " + total + "!");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Write a number:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        number1(number1);

        Console.WriteLine("Write another number:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        number2(number2);

        sum(number1, number2);
    }
}
*/

/* Function exercise 3

using System;

class Functions
{
    public static void number1(int num1)
    {
        Console.WriteLine("The first number is " + num1 + "!");
    }

    public static void number2(int num2)
    {
        Console.WriteLine("The second number is " + num2 + "!");
    }

    public static void sum(int num1, int num2)
    {
        int total = num1 + num2;
        Console.WriteLine("The sum of the two numbers is " + total + "!");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Write a number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        number1(num1);

        Console.WriteLine("Write another number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        number2(num2);

        sum(num1, num2);
    }
}
*/


/* Function exercise 4

using System;

class Functions
{
    public static int SpaceCount(string str)
    {
        int space = 0;
        string str1;

        for (int i = 0; i < str.Length; i++)
        {
            str1 = str.Substring(i, 1);

            if (str1 == " ")
            {
                space++;
            }
        }
        return space;
    }
    public static void Main()
    {
        Console.WriteLine("Please input a string:");
        string str2 = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Your sentence: " + str2 + "\nContains {0} spaces", SpaceCount(str2));
    }
}
*/

/* Function exercise 5
using System;

class Function
{
    public static int Sum(int[] numbers)
    {
        int sum = 0;

        for(int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    public static void Main()
    {
        Console.WriteLine("This program finds the sum of all numbers in an array.");

        Console.Write("Input the length of the array: ");
        int length = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[length];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter a number for the array:");
            int number = Convert.ToInt32(Console.ReadLine());
            numbers[i] = number;
        }

        Console.WriteLine($"The length of the array is {numbers.Length}");

        int sum = Sum(numbers);

        Console.WriteLine($"Sum of all elements stored in the array is : {sum}");
    }
}
*/

// Function exercise 6

using System;

class Functions
{
    public static void x()
    {

    }

    public static void Main()
    {
        x();
    }

}

/* Function exercise x
using System;

class Functions
{
    public static void x()
    {

    }

    public static void Main()
    {
        x();
    }

}
*/