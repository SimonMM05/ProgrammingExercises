/* Basic Exercises
__________________

Basic Exercise 4
int x = -1+4*6;
int y = (35+5)%7;
int z = 14-4*6/11;
int a = 2+15/6*1-7%2;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(a);
*/

/* Basic Exercise 5
int number1, number2, temp;

Console.WriteLine("Input the first number");
number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number");
number2 = int.Parse(Console.ReadLine());

temp = number1;
number1 = number2;
number2 = temp;

Console.WriteLine("After swapping: ");
Console.WriteLine("First number is : " + number1);
Console.WriteLine("Second number is : " + number2);

Console.ReadLine();
*/

/* Basic exercise 6

int number2, number3, number6;

Console.WriteLine("Input the number 2");
number2 = int.Parse(Console.ReadLine()2);

Console.WriteLine("Input the number 3");
number3 = int.Parse(Console.ReadLine());

Console.WriteLine("Input the number 6");
number6 = int.Parse(Console.ReadLine());

int number = number2 * number3 * number6;

Console.WriteLine("The number multiplied by 2, 3 and 6 is:");
Console.WriteLine(number);
*/

/* Basic exercise 7

int num1, num2;

Console.WriteLine("Input the number 25");
num1 = Convert.ToInt32(Console.ReadLine());
if (num1 == 25)
{
    Console.WriteLine("Input the number 4");
    num2 = Convert.ToInt32(Console.ReadLine());
    if (num2 == 4);
    {
        int addition = num1 + num2;
        int subtraction = num1 - num2;
        int multiplication = num1 * num2;
        int division = num1 / num2;

        Console.WriteLine("Adding, subtracting, multiplying and dividing 25 and 4 gives:");
        Console.WriteLine(addition + " " + " " + subtraction+  " " + " " + multiplication + " " + " " + division);
    }
}
*/

/* Basic Exercise 8
Console.WriteLine("Input a number");
int input1 = Convert.ToInt32(Console.ReadLine());

int i = 0;
while (i <= 10)
{
    
    Console.WriteLine(input1 + " multiplied by " + i + " is:");
    Console.WriteLine(input1*i);
    i++;
}
*/

/* Data Type Exercises:
______________________*/

/* Data Type Exercise 1

char letter1, letter2, letter3;

Console.WriteLine("Input a letter");
letter1 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Input another letter");
letter2 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Input another letter");
letter3 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("{0} {1} {2}",letter3,letter2,letter1);
*/

// Data Type Exercise 4;

/*
int number1, number2, Result = 0;
char userInput;

Console.WriteLine("Input a number");
number1 = Convert.ToInt32(Console.ReadLine());

if (number1 > 0 )
{
    Console.WriteLine("Input another number");
    number2 = Convert.ToInt32(Console.ReadLine());

    if (number2 > 0)
    {
        Console.WriteLine("Input either *, /, - or + to multiply, divide, subtract, or add the numbers together");
        userInput = Convert.ToChar(Console.ReadLine());
        
        if (userInput == '*' || userInput == '/' || userInput == '-' || userInput == '+')
        {
            switch (userInput)
            {
                case '*':
                    Result = number1 * number2;
                    break;
                case '/':
                    Result = number1 / number2;
                    break;
                case '-':
                    Result = number1 - number2;
                    break;
                case '+':
                    Result = number1 + number2;
                    break;
                default:
                    Result = 0;
                    break;
            }

            Console.WriteLine($"Result of the operation is: {number1} {userInput} {number2} = {Result}");
        }
        else
        {
            Console.WriteLine("Invalid operation. Please enter *, /, - or +.");
        }
    }
    else
    {
        Console.WriteLine("Invalid second number. Please input a number greater than 0.");
    }
}
else
{
    Console.WriteLine("Invalid first number. Please input a number greater than 0.");
}
*/

/* Data Type Exercise 5

float radius, area, perimeter;

Console.WriteLine("Input the radius of a circle");
radius = Convert.ToSingle(Console.ReadLine());

area = (float)(Math.PI * Math.Pow(radius, 2));
perimeter = (float)(Math.PI * radius * 2);

    if (radius > 0)
    {
        area = (float)Math.Round(area, 2);
        perimeter = (float)Math.Round(perimeter, 2);

        Console.WriteLine("The perimeter of the circle is: " + perimeter);
        Console.WriteLine("The area of the circle is: " + area);
    }
else
{
    Console.WriteLine("Invalid radius. Please input a positive number.");
}
*/

/* Data Type Exercise 7

float distance, hours, minutes, seconds;
float timeSec, mps, kph, mph;

Console.WriteLine("Input a distance in meters");
distance = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the time in hours e.g. 1");
hours = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the time in minutes e.g. 35");
minutes = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the time in seconds e.g. 59");
seconds = Convert.ToInt32(Console.ReadLine());

timeSec = (hours*3600) + (minutes*60);
mps = (distance/timeSec);
kph = (distance/1000f)/(timeSec/3600f);
mph = (kph/1.609f);

Console.WriteLine("Your speed in meters/sec is: " + mps);
Console.WriteLine("Your speed in km/h is: " + kph);
Console.WriteLine("Your speed in miles/h is: " + mph);
*/