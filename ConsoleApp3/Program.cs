using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Fraction f1 = new Fraction(2, 4);
            Fraction f2 = new Fraction(2, 5);
        
            Fraction f3 = f1 + f2;
            Fraction f4 = f2 - f1;
            Fraction f5 = f1 * f2;
            Fraction f6 = f1 / f2;
   
            Console.WriteLine(f6);
            Console.WriteLine(f5);
            Console.WriteLine(f3);
            Console.WriteLine(f4);

           

            Monomial m1 = new Monomial(5, 'a', 5);
            Monomial m2 = new Monomial(5, 'a', 3);
            Monomial m3 = m1 + m2;
            Monomial m4 = m1 * m2;
            Console.WriteLine(m3);
            Console.WriteLine(m4);




           
            Console.ReadKey();




        }
    }
}
