using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class Swapping
    {
        public Swapping()
        {
            int num1, num2;
            int temp;
            Console.Write("Enter num1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swapping ");
            Console.WriteLine("Num1 : "+ num1);
            Console.WriteLine("num2 : "+ num2);
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping ");
            Console.WriteLine("Num1 : " + num1);
            Console.WriteLine("num2 : " + num2);

        }
    }
}
