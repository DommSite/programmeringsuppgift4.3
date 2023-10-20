using System;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace inlämningsuppgift4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for(int tal=1; tal<=100; tal++)
            {
                if (tal % 3 == 0 && tal % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                } 
                else if(tal % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (tal % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else {
                    Console.WriteLine(tal);
                }

               
            }
            Console.WriteLine("Done");
        }
    }
}
