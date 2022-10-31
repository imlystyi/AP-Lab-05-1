using Microsoft.VisualStudio.TestTools.UnitTesting;
using AP_Lab_05_1;

namespace AP_Lab_05_1_UT
{
    [TestClass]
    public class Lab_05_1_UT
    {
        [TestMethod]
        public void TestF()
        {
            double n = Lab_05_1.F(0);

            Assert.AreEqual(n, 1);
        }
    }
}
