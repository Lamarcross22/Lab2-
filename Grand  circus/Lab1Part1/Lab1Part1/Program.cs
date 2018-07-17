using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            //first list of numbers
            bool repeat = true;
            while(repeat)
            {

                Console.WriteLine("please enter first number");
                int userInput1 = int.Parse(Console.ReadLine());

                Console.WriteLine("please enter second number");
                int userInput2 = int.Parse(Console.ReadLine());

                Console.WriteLine("please third number");
                int userInput3 = int.Parse(Console.ReadLine());

                Console.WriteLine("please enter fourth number");
                int userInput4 = int.Parse(Console.ReadLine());

                int inputSet1 = userInput1 + userInput3;
                int inputSet2 = userInput2 + userInput4;

                //checkes to see if the sets equal each other or not
                if (inputSet1 == inputSet2)
                {
                    Console.WriteLine("THESE NUMBERS EQUAL");
                }
                else
                {
                    Console.WriteLine("THESE NUMBERS DONT MATCH");
                }

                Console.WriteLine("Would you like to try again? Type Y or N.");
                string userResponse = Console.ReadLine();

                if (userResponse == "Y" || userResponse == "y")
                {
                    repeat = true;
                }
                else if (userResponse == "N" || userResponse == "n")
                {
                    repeat = false;
                }

            }
        }
    }
}
