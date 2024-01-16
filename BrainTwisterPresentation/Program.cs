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













/*
Koden tager alle tal til og med det tal som du inputer og enten pluser med værdien hvis det er et lige tal
eller minusser med værdien af tallet hvis det er et ulige tal.

fx i = 5
result = 0-1+2-3+4-5 = -3
*/