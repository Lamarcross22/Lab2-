using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //this program will read two numbers, then show the sum
            //of those numbers

            // input
            int input1;
            int input2;
            Console.WriteLine("please enter a number");
           input1= int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a number");
            input2 = int.Parse(Console.ReadLine());


            // processing

            int result = input1 + input2;


            //Output


            Console.WriteLine($"The result of adding {input1} and {input2} is {result}");



        }
    }
}
