using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie_B3
{
    class trójkątprostokątny
    {
        private double a;
        private double b;
        public string kolor
        {
            get;
            set;
        }
        public double obwod
        {
            get
            {
                return A + B + obliczC();
            }
        }
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
            }
        }
        public double oblicztanges()
        {
            return A / B;
        }
        private double obliczC()
        {
            return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        }
        public double OblicznSina()
        {
            return B / obliczC();
        }      
    }
}
