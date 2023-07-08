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

        //// !For Loop


        for (int forNumber = 1; forNumber < 5; forNumber++)
        {
            Console.Write(forNumber);
            Console.WriteLine(" seconds");
        }


        Console.WriteLine("Enter how many times \"hello\" should display ");
        int hello = int.Parse(Console.ReadLine());


        for (int helloooo = 0; hello > helloooo; helloooo++)
        {
            Console.WriteLine("hello again");
        }

        // !Do while

        int ten = 10;

        do
        {
            Console.WriteLine("What's up?");
        }
        while (ten > 15);

        // Next task

        Console.WriteLine("Type againg to hello one more time!");

        string helloAgain;
        do
        {
            Console.WriteLine("Hello");
            helloAgain = Console.ReadLine();

        }
        while (helloAgain == "again");


        //!Nested Loops
        //* square

        int rowColumns = 10;

        for (int m = 0; m < rowColumns; m++)
        {
            for (int n = 0; n < rowColumns; n++)
            {
                Console.Write("{0,3}", "*");
            }
            Console.WriteLine();
        }
        

    }



    }




