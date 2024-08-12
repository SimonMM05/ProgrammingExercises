/* Fokus på If statements
Write a program in C# Sharp which is a menu-driven program to perform simple calculations.
Here are the options :
1-Addition.
2-Substraction.
3-Multiplication.
4-Division.
5-Exit.

using System;
class ifStatements
{
    static public void Main()
    {
        int n = 0;
        Console.WriteLine("Input a number");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input a number");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 1 to add the number, 2 for subtraction, 3 for multiplication, 4 for division and 5 or greater to exit.");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            n = n1 + n2;
        }

        else if (choice == 2)
        {
            n = n1 - n2;
        }

        else if (choice == 3)
        {
            n = n1 * n2;
        }

        else if (choice == 4)
        {
            n = n1 / n2;
        }

        else if (choice == 5)
        {
            return;
        }

        Console.WriteLine("The result of the numbers are: " + n);
    }
}
*/

/* Write a C# Sharp program to accept two integers and check whether they are equal or not. 

using System;
class Rep
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a number");
        int n2 = Convert.ToInt32(Console.ReadLine());

        if (n1==n2)
        {
            Console.WriteLine("They are equal");
        }
    }
}
*/

