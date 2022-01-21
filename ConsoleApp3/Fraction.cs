using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Fraction
    {
        private int _num;
        private int _dem;
        private char _sym;
        private int _deg;

                
        public Fraction(int num, int dem) 
        {
            _dem = dem;
            _num = num;

        }

        public Fraction(int num)
        {
            this._num = num;
            _dem = 1;
        }


        private void  CheckDem(int dem)
        {
            if (dem == 0)
            {
                _dem = 1;
            }
            else
            {
                _dem = dem;
            }
           

        }


        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            if(f1._dem == f2._dem)
            {
                
                return new Fraction(f1._num + f2._num, f1._dem);
            }
            else
            {
                int n = f1._num * f2._dem + f2._num * f1._dem;
                int d = f1._dem * f2._dem;
                return new Fraction(n, d);
            }
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction(f1._num * f2._dem, f1._dem * f2._num);
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1._num * f2._num, f1._dem * f2._dem);
        }
        public static Fraction operator -(Fraction f1)
        {
           return  new Fraction(-f1._num, f1._dem);
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
           return  f1 + (-f2);
        }

        public override string ToString()
        {
            return _num+ "/"+_dem;
        }
    }
}
