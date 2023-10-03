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
            // Check if it leaves a remainder when divided by 2
            
            bool result = (number % 2) != 0;
            return result;
        } 

        // Accept the base and height of a triangle, and find the area.        
        public double CalculateTriangleArea(double baseValue, double heightValue)
        {
            return 0.5 * baseValue * heightValue;
        }

        // Accept the length and breadth of a rectangle and find the area.
        public double CalculateRectangleArea(double length, double breath)
        {
            return length * breath;
        }

        /*
         * Prompt user for age 
         * Cast the input into an integer
         * Check that numeric input is
            * an integer value, otherwise reject it
            * within a reasonable range (1 to 150), otherwise reject it
         * If the age is between 1 and 2, display "Baby"
         * If the age is between 3 and 12, display "Child"
         * If the age is between 13 and 19, display "Teenager"
         * If the age is between 20 and 60, display "Adult"
         * If the age is 61 and above, display "Senior"
         * If the age group cannot be determined, display "Unknown"
        */

        // Given an age value for a user, determine if he/she is a baby, child, teenager, adult, senior.
        public string DetermineAgeGroup(int age)
        {
            string result = "Unknown";

            //// Decision-making using a series of if-else statements
            //if (age < 1 || age > 150)
            //{
            //    Console.WriteLine("The supplied age is not within an acceptable range. Enter a value from 1 to 150.");
            //    return result;
            //}
            //else if (age <= 2)
            //    return "Baby";
            //else if (age >= 3 && age <= 12)
            //    return "Child";
            //else if (age >= 13 && age <= 19)
            //    return "Teenager";
            //else if (age >= 20 && age <= 60)
            //    return "Adult";
            //else if (age >= 61 )
            //    return "Senior";

            // Decision-making using a switch-case statement
            switch (age)
            {
                case >= 1 and <= 2 :
                    return "Baby";
                case  >= 3 and  <= 12 :
                    return "Child";
                case >= 13 and <= 19:
                    return "Teenager";
                case >= 20 and <= 60:
                    return "Adult";
                case >= 61 and <= 150:
                    return "Senior";
                default:
                    Console.WriteLine("The supplied age is not within an acceptable range. Enter a value from 1 to 150.");
                    return result;
            }
        }

    }
}
