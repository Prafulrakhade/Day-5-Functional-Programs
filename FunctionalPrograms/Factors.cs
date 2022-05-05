using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class Factors
    {
        public Factors()
        {
            int num, i;
            int result = 1;
            Console.Write("Enter the Number Till you want factors  : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                result = result * i;
            }
            Console.WriteLine("Factors of : "+ num + " is : "+result);
        }
    }
}