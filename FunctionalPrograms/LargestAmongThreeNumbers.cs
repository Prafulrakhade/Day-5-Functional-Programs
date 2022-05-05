using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class LargestAmongThreeNumbers
    {
        public LargestAmongThreeNumbers()
        {
            int num1, num2, num3;
            Console.Write("Enter the Num1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Num2 : ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Num3 : ");
            num3 = int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine(num1 + " : num1 is Greater");
                }
                else
                {
                    Console.WriteLine(num3 + " : num3 is Greater");
                }
            }
            else
            {
                if(num2>num3)
                {
                    Console.WriteLine(num2 + " : num2 is Greater");
                }
                else
                {
                    Console.WriteLine(num3 + " : Num3 is Greater");
                }
            }

        }
    }
}
