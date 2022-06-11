using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddProgram
{
    public class CheckingEvenOdd
    {
        public static void EvenOdd()
        {
            Console.Write("Enter any number to check whether its even or not : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The given number {0} is Even ", number);
            }
            else
            {
                Console.WriteLine("The given number {0} is Odd ", number);
            }
        }
    }
}
