using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Monomial
    {
        private int _num;
        private char _sym;
        private int _deg;

        public Monomial(int num, char sym, int deg)
        {
            _num = num; 
            _sym = sym;
            _deg = deg;
        }
        public static Monomial operator +(Monomial m1, Monomial m2)
        {
            if (m1._sym == m2._sym && m1._deg == m2._deg)
            {
                int n = m1._num + m2._num;
                char c=m1._sym;
                int d = m1._deg;

                Monomial monomialResult = new Monomial(n, c, d);
                return monomialResult;
            }

            else
            {
                throw new Exception();
            }
        }


        public static Monomial operator *(Monomial m1, Monomial m2)
        {
            if (m1._sym == m2._sym)
            {
                int n = m1._num * m2._num;
                char c = m1._sym;
                int d = m1._deg + m2._deg;

                Monomial monomialResult = new Monomial(n, c, d);
                return monomialResult;
            }

            else
            {
                throw new Exception();
            }
        }


        public override string ToString()
        {
            return _num +""+  _sym + "^" + _deg;
        }
    }

}
