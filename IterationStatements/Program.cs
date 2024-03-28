using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        // PLEASE READ
        // ****had to remove "int numbers" from parameters to make it run...
        // dont know why that was in there or how. kept throwing error on the name of the variable "numbers"
        // "var 'numbers' = new List<int>();*****

            //dispite; got it all working



        {
            //TODO - Read each comment and complete its instruction
            // like the example below

            //Create a List called "numbers" - DONE!
            var numbers = new List<int>();

            //Start------
            
            int num = 0;

            // do while loop            
            do
            {
                num++;
                numbers.Add(num);
            
            } while (num < 100); 

            // while loop
            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }
                        
            Console.WriteLine("Increase:");

            // foreach loop
            foreach (int i in numbers) 
            {
                Console.WriteLine(i);
            }
                 
            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // for loop
            for (int i = 199; i <= (numbers.Count)&& i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            //------------End of exercise
        }
    }
}
