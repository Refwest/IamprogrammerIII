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
        int number = 0;

        while (number < 2024)
        {
            Console.WriteLine(number);
            {
                number++;
            }
        }

    }
}


