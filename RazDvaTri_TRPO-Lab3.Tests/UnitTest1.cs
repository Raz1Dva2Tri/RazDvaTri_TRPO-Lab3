using RazDvaTri_TRPO_Lab3;
using RazDvaTri_TRPO_Lab3.Lib;

namespace RazDvaTri_TRPO_Lab3.Tests
    
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestArea()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;
            Triangle triangle = new(a, b, c);
            Assert.AreEqual(expected, triangle.S);   
            
        }
    }
}