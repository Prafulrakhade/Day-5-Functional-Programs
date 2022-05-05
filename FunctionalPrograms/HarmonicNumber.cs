using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class HarmonicNumber
    {
        public HarmonicNumber()
        {
            double num, i;
            double result = 0;
            Console.Write("Enter the Number of Harmonic Number Till You Want : ");
            num = Convert.ToDouble(Console.ReadLine());
            for ( i = 1; i <= num; i++)
            {
                result = result + 1 / i;
            }
            Console.WriteLine("Harmonic Number Of : " + num + "  is : " + result );
        }
    }
}
