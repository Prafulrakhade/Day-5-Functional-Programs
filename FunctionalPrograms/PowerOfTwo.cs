using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class PowerOfTwo
    {
        public PowerOfTwo()
        {
            int num, i;
            int result = 1;
            Console.Write("Enter the number which you want to power of two(2) : ");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                result = result * 2;
            }
            Console.WriteLine("Power of Two (2) = "+ result);
        }
    }
}
