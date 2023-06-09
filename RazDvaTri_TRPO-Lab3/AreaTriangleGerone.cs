using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazDvaTri_TRPO_Lab3
{
    internal class Triangle
    {
        double a;
        double b;
        double c;

        public Triangle(double a_, double b_, double c_)
        {
            a = a_;
            b = b_;
            c = c_;
        }

        double p
        {
            get { return a+b+c; }
        }
        double S
        {
            get { return Math.Sqrt(p*(p-a)* (p - b) * (p - c)); }
        }
    }
}
