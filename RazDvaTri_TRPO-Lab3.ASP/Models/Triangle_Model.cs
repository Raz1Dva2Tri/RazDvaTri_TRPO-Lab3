using RazDvaTri_TRPO_Lab3.Lib;

namespace RazDvaTri_TRPO_Lab3.ASP.Models
{
    public class Triangle_Model : Triangle
    {
        public Triangle_Model() : base()
        {
        }
        public Triangle_Model(double a_, double b_, double c_) : base(a_, b_, c_)
        {
        }
        


        public bool TryLength()
        {
            if (a + b > c
            && a + c > b
            && b + c > a) return true;
            else return false;
        }
    }
}
