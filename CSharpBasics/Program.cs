using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {            
            // Instantiate the BasicStringOperations class and invoke the method
            BasicStringOperations stringOperations = new BasicStringOperations();
            stringOperations.ConcatenateWords();

            // Instantiate the BasicNumericOperations class and invoke the method
            BasicNumericOperations numericOperations = new BasicNumericOperations();
            numericOperations.CheckLeapYear();

            // Prompt the user for an integer
            Console.WriteLine("Please enter an integer to check if odd or even...");
            string input = Console.ReadLine();

            // Cast the input into an integer
            int number = int.Parse(input); // Assuming the user indeed entered a number
            if (numericOperations.IsOddNumber(number))
                Console.WriteLine("It is an odd number");
            else
                Console.WriteLine("It is an even number");

            // Prompt the user for triangle base and height
            Console.WriteLine("Please enter a value for base...");
            string baseStr = Console.ReadLine();
            Console.WriteLine("Please enter a value for height...");
            string heightStr = Console.ReadLine();

            // Cast the inputs into double-precision values
            double baseValue = double.Parse(baseStr); // Assuming the user indeed entered a number
            double heightValue = double.Parse(heightStr); // Assuming the user indeed entered a number
            double triangleArea = numericOperations.CalculateTriangleArea(baseValue, heightValue);
            Console.WriteLine();
            Console.WriteLine($"The area of the triangle is {triangleArea}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Prompt the user for rectangle length and breadth
            Console.WriteLine("Please enter a value for length...");
            string lengthStr = Console.ReadLine();

            Console.WriteLine("Please enter a value for breadth...");
            string breadthStr = Console.ReadLine();

            // Cast the inputs into double-precision values
            double lenghthValue = double.Parse(lengthStr); // Assuming the user indeed entered a number
            double breadthValue = double.Parse(breadthStr); // Assuming the user indeed entered a number
            double rectangleArea = numericOperations.CalculateRectangleArea(lenghthValue, breadthValue);
            Console.WriteLine();
            Console.WriteLine($"The area of the rectangle is {rectangleArea}");             
           
            // Prompt the user for their age
            Console.WriteLine("Please enter your age to determine your age group...");
            input = Console.ReadLine();

            // Try casting the input into an integer
            bool isValidInteger = int.TryParse(input, out int age);
            if (!isValidInteger)
            {
                Console.WriteLine("Sorry, the input is not valid for age. Kindly enter an integer.");
                return;
            }
            else
            {
                string ageGroup = numericOperations.DetermineAgeGroup(age);
                Console.WriteLine($"Your age group is {ageGroup}");
            }
        }
    }
}


// This is a one-line comment
/*

Problems to solve:

1.	Accept 2 words, concatenate them, and display the result on the console.

2.	Given a year, determine if it is a leap year or not.

3.	Accept an integer from the user, and determine if it is odd or even.

4.	Accept the base and height of a triangle, and find the area.

5.	Accept the length and breadth of a rectangle and find the area.

6.	Given an age value for a user, determine if he/she is a child, teenager, adult, senior.

 */


// Access modifiers:
/*
    private - visible/accessible only within this class
    public - visible/accessible from anywhere, both within and outside this class
    protected - visible/accessible both within this class and from any class deriving from this one
    internal - visible/accessible within this class and any class within the current assembly/project
 */
