using System;

namespace WWCI_CSharp_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * A program that loops over a number and prints it
             * Let's create a quick algorithm / pseudocode
             * 
             * 1) Identify number of times we'll be looping
             * this will be the condition of our loop statement, meaning if the number we're on is less than or equal to this number, we'll print it.
             * 2) We'll need a variable to hold the number we're counting. We'll then increment that number after every loop
             * 3) Inside the loop, write out the number to the screen.             
            */

            int upperLimit = 10; //condition for the loop.
            int iterator; //number we're counting in the loop. I'm declaring it here, and will assign it in the loop itself.

            //now the loop!

            for (iterator =1; iterator<=upperLimit; iterator++) //this is a popular way to write a loop. It's called a FOR loop.
            {
                System.Console.WriteLine(iterator); //we're writing out the number to the screen as we count our loop. Passing argument iterator to Console.WriteLine method
            }
        }
    }
}
