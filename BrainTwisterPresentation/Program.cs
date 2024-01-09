using System;

class BrainTwister
{
    static void Main()
    {
        Console.WriteLine("Indtast et tal:");
        int input = Convert.ToInt32(Console.ReadLine());

        int result = Output(input);

        Console.WriteLine($"Outputtet er: {result}");
        Console.ReadLine();
    }

    static int Output(int n)
    {
        int result = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                result += i;
            }
            else
            {
                result -= i;
            }
        }

        return result;
    }
}
