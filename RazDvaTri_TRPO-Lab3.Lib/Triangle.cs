namespace RazDvaTri_TRPO_Lab3.Lib
{
    public class Triangle
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
            get { return (a + b + c) / 2; }
        }
        public double S
        {
            get { return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); }
        }


    }
}
