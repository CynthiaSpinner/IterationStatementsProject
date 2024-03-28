using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
                       
        {
          
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
