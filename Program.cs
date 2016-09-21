using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try-Catch construct

            try
            {
                Console.WriteLine("Enter a number: ");
                string numberText = Console.ReadLine();
                int number = int.Parse(numberText);
                Console.WriteLine("Your number is " + number);
            }

            catch (FormatException objectName)
            {
                Console.WriteLine("That is not a valid number");
            }
        }
    }
}
