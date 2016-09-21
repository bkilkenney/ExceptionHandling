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

            //try
            //{
            //    Console.WriteLine("Enter a number: ");
            //    string numberText = Console.ReadLine();
            //    int number = int.Parse(numberText);
            //    Console.WriteLine("Your number is " + number);
            //}
            //catch (FormatException objectName)
            //{
            //    Console.WriteLine("That is not a valid number");
            //}

            //Try - Throw - Need an example, none in slides

            ////Try - Finally
            //try
            //{
            //    Console.WriteLine("Enter a number: ");
            //    string numberText = Console.ReadLine();
            //    int number = int.Parse(numberText);
            //    Console.WriteLine("Your number is " + number);
            //}
            //finally
            //{
            //    Console.WriteLine("Thanks for playing!");
            //}

            //declare 2 variables
            float result;
            int num;

            //Prompt the user for a number
            Console.Write("Enter Number: ");

            //Try block will run the code in the block
            try
            {
                num = int.Parse(Console.ReadLine());

                result = (float)Math.Sqrt(num);   //This is, which is similar to Parse or Convert
                Console.WriteLine("The result is: {0}", result);
            }


            //Catch block will handle the exception
            catch (Exception)
            {
            }
            }
        }
    }
