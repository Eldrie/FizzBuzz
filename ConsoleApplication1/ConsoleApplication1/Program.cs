﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Divisible entre 3 Fizz o 5 Buzz o entre los 2 Fizz Buzz
            Console.WriteLine("Fizz & Buzz");
            for (int i = 1; i <= 100; i++)
            {

                if (i%3==0) {
                    Console.WriteLine(i+ "Fizz");
                            }
            
            }
            


            Console.ReadLine();


        }
    }
}
