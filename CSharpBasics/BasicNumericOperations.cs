using System;

namespace CSharpBasics
{
    class BasicNumericOperations
    {

        // Given a year, determine if it is a leap year or not.
        public void CheckLeapYear()
        {
            Console.WriteLine("Enter a year to check...");
            var input = Console.ReadLine();

            // Validate the input
            int year;

            if (!int.TryParse(input, out year))
            {
                Console.WriteLine("Please enter a valid integer for year.");
                return;
            }

            if (year < 1 || year > 9999)
            {
                Console.WriteLine("Please enter a year between 0001 and 9999.");
                return;
            }

            bool isLeapYear = (year % 4) == 0;

            if (isLeapYear)
                Console.WriteLine("Yes, it is a leap year");
            else
                Console.WriteLine("No, it is not a leap year");
        }

        // Accept an integer from the user, and determine if it is odd or even.
        public bool IsOddNumber(int number)
        {


        } 



        // Accept the base and height of a triangle, and find the area.


        // Accept the length and breadth of a rectangle and find the area.


        // Given an age value for a user, determine if he/she is a child, teenager, adult, senior.


    }
}
