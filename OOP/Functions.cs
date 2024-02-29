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

