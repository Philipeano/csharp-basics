using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the BasicStringOperations class and invoke the method
            // BasicStringOperations stringOperations = new BasicStringOperations();
            //stringOperations.ConcatenateWords();
            
            // Instantiate the BasicNumericOperations class and invoke the method
            BasicNumericOperations numericOperations = new BasicNumericOperations();
            numericOperations.CheckLeapYear();
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



// private - visible/accessible only within this class
// public - visible/accessible from anywhere, both within and outside this class
// protected - visible/accessible both within this class and from any class deriving from this one
// internal - visible/accessible within this class and any class within the current assembly/project
