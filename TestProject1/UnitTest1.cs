using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRealMult()
        {
            double real1 = -55, real2 = 11;
            realCalc RC = new realCalc();
            RC.aReal = real1;
            RC.bReal = real2;
            double mult = -605;

            RC.realMult();
            Assert.AreEqual(mult, RC.realResult, 0.001);

        }
    }
}
