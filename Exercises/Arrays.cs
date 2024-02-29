/* Example of how to use an array in c#

using System;

class Arrays
{
    static void Main()
    {
        Console.Write("Input the length of the array: ");
        int length = Convert.ToInt32(Console.ReadLine());

        string[] names = new string[length];

        Console.WriteLine($"The length of the array is {names.Length}");

        for(int i = 0; i < names.Length; i++)
        {
            Console.WriteLine("Enter a name for a person for the array:");
            string name = Console.ReadLine()!;
            names[i] = name;

        }

        for(int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"The name at index {i} is {names[i]}");
        }
    }
}
*/

/* Arrays exercise 1

using System;

class Arrays
{
    static void Main()
    {
        Console.WriteLine("This program stores and prints numbers 10 numbers in an array");

        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }

        Console.WriteLine("Elements in the array are:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element {i}: {numbers[i]}");
        }
    }
}
*/

/* Arrays exercise 2

using System;

class Arrays
{
    static void Main()
    {
        Console.WriteLine("This program reads x values in an array and displays them in reverse order.");

        Console.Write("Input the length of the array: ");
        int length = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[length];

        Console.WriteLine($"The length of the array is {numbers.Length}");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter a number for the array:");
            int number = Convert.ToInt32(Console.ReadLine());
            numbers[i] = number;

        }

        for(int i = length - 1; i >= 0; i--)
        {
            Console.WriteLine($"The number at index {i} is {numbers[i]}");
        }
    }
}
*/

/* Arrays exercise 3
using System;

class Arrays
{
    static void Main()
    {
        Console.WriteLine("This program finds the sum of all numbers in an array.");

        Console.Write("Input the length of the array: ");
        int length = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[length];

        Console.WriteLine($"The length of the array is {numbers.Length}");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter a number for the array:");
            int number = Convert.ToInt32(Console.ReadLine());
            numbers[i] = number;
        }

        int sum = 0;

        for(int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine($"Sum of all elements stored in the array is : {sum}");

    }
}
*/

/* Arrays exercise 4

using System;

class Arrays
{
    static void Main()
    {
        Console.WriteLine("This program copies the elements of one array into another.");


        Console.Write("Input the length of the first array: ");
        int length = Convert.ToInt32(Console.ReadLine());

        int[] nArray = new int[length];
        int[] cArray = new int[length];

        Console.WriteLine($"The length of the array is {nArray.Length}");

        Console.WriteLine("Enter elements for the first array:");

        for (int i = 0; i < nArray.Length; i++)
        {
            Console.Write($"Element {i + 1}: ");
            nArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < nArray.Length; i++)
        {
            cArray[i] = nArray[i];
        }

        Console.WriteLine("Elements in the copied array are: ");

        for (int i = 0; i < cArray.Length; i++)
        {
            Console.Write(cArray[i] + " ");
        }
    }
}
*/

/* Array exercise 5

using System;

class Arrays
{
    static void Main()
    {
        Console.WriteLine("This program allows you to count how many duplicate elements in an array");

        Console.Write("Input the length of the array: ");
        int length = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[length];
        int count = 0;

        Console.WriteLine($"The length of the array is {numbers.Length}");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter a number for element {i} in the array: ");
            int number = Convert.ToInt32(Console.ReadLine());
            numbers[i] = number;
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    count = count + 1;
                    break;
                }
            }
        } // Inside the inner loop, it checks if the element at index i is equal to the element at index j, indicating a duplicate.
          // If a duplicate is found, it increments the count variable.

        Console.WriteLine($"Total number of duplicate elements found in the array is: {count}");
    }
}
*/



