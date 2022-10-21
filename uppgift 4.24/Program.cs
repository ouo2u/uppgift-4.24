using System;

namespace upggift4._24
{
    class program
    {
        static void Main(string[]args)
        {
            for (int i = 0; i <= 100; i++) 
            { 
            Console.WriteLine(i);
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");

                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");



            }
        }
       
    }
}
