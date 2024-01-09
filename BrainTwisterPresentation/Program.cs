Console.WriteLine("Input a number");
int input = Convert.ToInt32(Console.ReadLine());

int result = 0;

for (int i = 1; i <= input; i++)
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

Console.WriteLine($"The output is: {result}");
Console.ReadLine();