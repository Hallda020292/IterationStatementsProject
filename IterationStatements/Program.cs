using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
            var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0

            var num = 0;


            // Create a do-while loop and use the template below:
            do
            {
                // Increment num by 1
                num++;

                // Then add num to the collection - numbers
                // Hint: reference num inside of the Add method's parentheses
                numbers.Add(num);

            } while (num < 100);// <---- While your variable is less than 100



            // Create a while loop
            while (num < 200)
            {
                num++;

                // Then add num to the collection - numbers
                // Hint: reference num inside of the Add method's parentheses
                numbers.Add(num);

            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
          


            Console.WriteLine("");
            Console.WriteLine("Decrease:");

           for (var i = 199; i > 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

            //------------End of exercise
        }
    }
}
