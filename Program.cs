using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 natural numbers:");
            for (int n = 1; n <= 10; n++)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine(); // Add a newline for better readability           
            Console.WriteLine("First 10 even natural numbers:");// Using a while loop to print the first 10 even natural numbers
            int even = 2;
            int countEven = 0;
            while (countEven < 10)
            {
                Console.Write(even + " ");
                even += 2;
                countEven++;
            }
            Console.WriteLine(); // Add a newline for better readability           
            Console.WriteLine("First 10 odd natural numbers:");// Using a do-while loop to print the first 10 odd natural numbers
            int odd = 1;
            int countOdd = 0;
            do
            {
                Console.Write(odd + " ");
                odd += 2;
                countOdd++;
            } while (countOdd < 10);
        }
    }
}
