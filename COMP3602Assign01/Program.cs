//                                               Possible  Actual
// Assignment One Criteria                           Mark    Mark
// --------------------------------------------------------------
// Correct files submitted                              1       1
//  Yes
//
//
// Console project named COMP3602Assign01               1       1
//  Yes
//
//
// Output is formatted as a table, like the sample.     2       1
//  Double spaced
//
//
// Output is correct.                                   2       2
//  Yes
//
//
// Problem solution; reasonable and efficient.          4       4
//  Calcualtions are done twice
//  Increment the loop by 2 and avoid the % operation
//
// Coding style: follows coding standards for course;   2       2
// commented; easy to read.
//  Yes
//
// --------------------------------------------------------------
// Total:                                              12      11
//
//
//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP3602 - Assignment 01 - A01222657";

            // The maximum range to be processed
            const int max = 20;
            const int dividerLength = 30;
            const string HeaderFormat = "{0, 10}{1, 10}{2, 10}";
            const string IntegralFormat = "{0, 10:N0}{1, 10:N0}{2, 10:N0}";

            int sumOfEvens = 0;
            double sumOfSquares = 0;
            double sumOfCubes = 0;

            //Create a divider string with a fixed length
            string divider = new string('-', dividerLength); //// good

            Console.WriteLine(HeaderFormat, "Number", "Square", "Cube");
            Console.WriteLine(divider);

            //Only process even numbers
            for (int i=0; i<=max; i+=2)
            {
                double square = Math.Pow(i, 2);
                double cube = Math.Pow(i, 3);
                sumOfEvens += i;
                sumOfSquares += square;
                sumOfCubes += cube;
                Console.WriteLine(IntegralFormat, i, square, cube); //// why recalulate? fixed!
            }

            Console.WriteLine(divider);
            Console.WriteLine(IntegralFormat, sumOfEvens, sumOfSquares, sumOfCubes);
        }
    }
}
