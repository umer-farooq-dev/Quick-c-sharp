using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 -- Addition\n 2 -- Substraction\n 3-- Multiplication\n 4 -- Division");

            int result = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the ist no");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd no");
            int num2= Convert.ToInt32(Console.ReadLine()); 
           



            switch (result)
            {
               case 1:
                    Console.WriteLine(num1+num2);  
                    break;
                case 2:
                    Console.WriteLine(num1 - num2);
                    break;
                case 3:
                    Console.WriteLine(num1 * num2);
                    break;
                case 4:
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("Input valid number");
                    break;
            }

        }
    }
}
