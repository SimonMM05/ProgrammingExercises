/* Example

using System;

class WhileLoops
{
    static void Main()
    {
        Console.WriteLine("Hola Senior");
        int x = 0; 
        do
        {
            x++;
            Console.WriteLine(x);
        } while (x < 5);
    }
}
*/

/* PP While loop task 1.1 
using System;

class WhileLoops
{
    static void Main()
    {
        Console.WriteLine("This program allows you to read a set of integers");
        Console.WriteLine("and add the even numbers and the odd numbers together.");

        Console.WriteLine("Input the first number");
        int first = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the second number");
        int second = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the third number");
        int third = Convert.ToInt32(Console.ReadLine());

        int even = 0;
        int odd = 0;


        while (first % 2 == 0)
        {
            even += first;
            break;
        }
        while (first % 2 != 0)
        {
            odd += first;
            break;
        }
        while (second % 2 == 0)
        {
            even += second;
            break;
        }
        while (second % 2 != 0)
        {
            odd += second;
            break;
        }
        while (third % 2 == 0)
        {
            even += third;
            break;
        }
        while (third % 2 != 0)
        {
            odd += third;
            break;
        }
        Console.WriteLine($"Sum of even numbers: {even}");
        Console.WriteLine($"Sum of odd numbers: {odd}");
    }

}
*/

/* PP While loop task 1.2
using System;

class WhileLoops
{
    static void Main()
    {
        Console.WriteLine("This program allows you to find the highest common factor among two numbers");

        Console.WriteLine("Enter the first number that is not a prime number");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter another number that is not a prime number");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int i = 1, HCF = 1;

        int minNumber = (number1 < number2) ? number1 : number2;

        while (i <= minNumber)
        {
            if (number1 % i == 0 && number2 % i == 0)
            {
                HCF = i;
            }
            i++;
        }

        Console.WriteLine($"HCF of {number1} and {number2} is: {HCF}");
    }
}
*/

/* How does the code work?

User Input:
The program prompts the user to enter two numbers, number1 and number2, both of 
which are assumed to be not prime numbers.

Initialization:

i is initialized to 1. This variable will be used in the while 
loop to iterate through potential common factors.
HCF (Highest Common Factor) is initialized to 1. It will store the 
highest common factor found during the iteration.

Minimum of Two Numbers:

The program calculates the minimum of the two input numbers (number1 and number2) 
and assigns it to minNumber. This is done using the ternary conditional operator (? :).

While Loop:

The while loop continues as long as i is less than or equal to minNumber.

Inside the loop:

It checks if both number1 and number2 are divisible by the current value of i. 
If they are, it updates the HCF with the current value of i.
i is then incremented to move on to the next potential common factor.

Output:

After the loop completes, the program prints the highest common factor (HCF) of the two input numbers.
*/

/* PP While loop task 1.2

using System;

class WhileLoops
{
    static void Main()
    {
        Console.WriteLine("This program reads two numbers and adds them together.");
        Console.WriteLine("This loop can be repeated or terminated.");

        do
        {
            Console.WriteLine("Enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            Console.WriteLine($"The sum of the operation is: {sum}");

            Console.WriteLine("Do you want to continue the loop or stop?");
            Console.WriteLine("\nEnter 1 to continue or 2 to stop.");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Exiting the program");
                    return;
            }
        }
        while (true);
    }
}
*/
/*
using System;

class WhileLoops
{
    static void Main()
    {
        Console.WriteLine("This program simulates a collatz conjecture.");
        Console.WriteLine("Enter a positive number");
        int number = Convert.ToInt32(Console.ReadLine());

        int result;
        int steps = 0;

        while (number != 1)
        {
            if (number % 2 == 0)
            {
                result = number / 2;
                Console.WriteLine($"The result is {result}");
            }
            else
            {
                result = 3 * number + 1;
                Console.WriteLine($"The result is {result}");
            }
            steps++;
            number = result;
        }
        
        Console.WriteLine($"The Collatz conjecture took {steps} steps to reach 1.");
    }
}
*/