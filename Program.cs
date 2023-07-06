using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesI;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to sum, or \"-1\" to quit");
        int number = int.Parse(Console.ReadLine());
        int sumResult = 0;

        while (number != -1)
        {
            sumResult += number;
            Console.WriteLine("Result is {0}. Enter next number to sum, or write \"-1\" to quit", sumResult);
            number = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("Result is {0}", sumResult);

        // !For Loop

        int forNumber = 0;
        for (forNumber = 0; forNumber < 5; forNumber++)
        {
            Console.WriteLine(forNumber);
            Console.WriteLine(" second");
        }
        //

            Console.WriteLine("Enter how mony times display hello");
            int hello = int.Parse(Console.ReadLine());

            int helloooo = 0;

        for (helloooo = 0; hello > helloooo; helloooo++)
        {
            Console.WriteLine("hello");
        }


        }

    }



