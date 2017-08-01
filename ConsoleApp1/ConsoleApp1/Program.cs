using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BintyLearning
{
    class Fizzbuzz
    {
        static void Main(string[] args)
        {
            for (int num = 1; num < 51; num++)
            {
                if ((num % 5 == 0) && (num % 3 == 0))
                {
                    Console.WriteLine("fizzbuzz");
                }

                else if (num % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }

                else if (num % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }

                else
                {
                    Console.WriteLine(num);
                }

            }

            Console.ReadLine();
        }
    }
}