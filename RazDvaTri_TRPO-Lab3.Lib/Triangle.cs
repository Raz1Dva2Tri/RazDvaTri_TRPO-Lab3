namespace RazDvaTri_TRPO_Lab3.Lib
{
    public class Triangle
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Triangle()
        {

        }

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
