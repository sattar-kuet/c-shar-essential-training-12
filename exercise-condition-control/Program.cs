using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_condition_control
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int number = 10;
            int reminder = number % 2;
            if (reminder == 0)
            {
                Console.WriteLine("this number is even");
            }
            else
            {
                Console.WriteLine("this number is odd");
            }*/

            int age = 35;
           /* if(age>=25  && age <= 35)
            {
                Console.WriteLine("You are eligible");
            }
            */
            int experience = 2;
            if(age<35 || experience > 1)
            {
                Console.WriteLine("You are eligible");
            }

      

        }
    }
}
