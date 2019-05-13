using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter any number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any number again: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.ReadLine();
        }

         
    }
}
