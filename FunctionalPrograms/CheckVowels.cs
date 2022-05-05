using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class CheckVowels
    {
        public CheckVowels()
        {
            char c;
            Console.Write("Enter the Alphabet for checking the Vowel or Not : ");
            c = Convert.ToChar(Console.ReadLine());
            if (c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c== 'U')
            {
                Console.WriteLine(c + " : is a VOWEL");
            }
            else
            {
                Console.WriteLine(c + " : is a CONSTANT");
            }
            

        }
    }
}
