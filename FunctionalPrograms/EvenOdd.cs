using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class EvenOdd
    {
        public EvenOdd()
        {
            int num;
            Console.Write("Enter the Number For Checking Even or Odd : ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is Even Number ");
            }
            else
            {
                Console.WriteLine(num + " is Odd Number ");
            }
        }
    }
}
