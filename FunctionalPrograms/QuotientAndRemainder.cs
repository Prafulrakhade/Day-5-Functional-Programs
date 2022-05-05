using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class QuotientAndRemainder
    {
        public QuotientAndRemainder()
        {
            int num1;
            int num2;
            int remainder;
            int quotient;
            Console.Write("Enter the Number 1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Number 2 : ");
            num2 = int.Parse(Console.ReadLine());

            quotient = num1 / num2;
            remainder = num1 % num2;

            Console.WriteLine("Quotient : " + quotient);
            Console.WriteLine("Remainder : " + remainder);
        }
    }
}
