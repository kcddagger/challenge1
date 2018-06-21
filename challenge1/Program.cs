using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            extraNumber();            
        }

        private static void extraNumber()
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Enter a whole number");
            if ((int.TryParse(Console.ReadLine(), out a)) && (1 <= a && a <= Math.Pow(10, 9)))
            {

            }
            else
            {
                Console.WriteLine("Invalid input, please use a whole number.");
                int.TryParse(Console.ReadLine(), out a);
            }

            Console.WriteLine("Enter a different whole number");
            if ((int.TryParse(Console.ReadLine(), out b)) && (1 <= b && b <= Math.Pow(10, 9)))
            {

            }
            else
            {
                Console.WriteLine("Invalid input, please use a whole number.");
                int.TryParse(Console.ReadLine(), out b);
            }

            Console.WriteLine("Enter a whole number that is the same as your first or second number.");
            if ((int.TryParse(Console.ReadLine(), out c)) && (1 <= c && c <= Math.Pow(10, 9)) && (c == a || c == b))
            {

            }
            else
            {
                Console.WriteLine("Invalid input, please enter a number that matches your first or second number.");
                int.TryParse(Console.ReadLine(), out c);
            }

            if (c == a)
            {
                Console.WriteLine();
                Console.WriteLine(b.ToString());
                Console.ReadLine();
            }
            else if (c == b)
            {
                Console.WriteLine();
                Console.WriteLine(a.ToString());
                Console.ReadLine();
            }
        }
    }
}
