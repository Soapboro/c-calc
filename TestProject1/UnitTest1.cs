using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System.Numerics;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestReal()
        {
            RealNum RC = new RealNum(-55, 11);
            double sum = -44;
            double subtr = -66;
            double mult = -605;
            double div = -5;

            RC.findSum(); Assert.AreEqual(sum, RC.getRes(), 0.001);
            RC.findSubstr(); Assert.AreEqual(subtr, RC.getRes(), 0.001);
            RC.findMult(); Assert.AreEqual(mult, RC.getRes(), 0.001);
            RC.findDiv(); Assert.AreEqual(div, RC.getRes(), 0.001);
        }

        [TestMethod]
        public void TestComplex()
        {
            ComplexNum CN = new ComplexNum(-4, 2, 1, -3);
            double sumR = -3; double sumI = -1;
            double subtrR = -5; double subtrI = 5;
            double multR = 2; double multI = 14;
            double divR = -1; double divI = -1;

            double realbuf, imgbuf;
            CN.findSum(); CN.getRes(out realbuf, out imgbuf);
            Assert.AreEqual(sumR, realbuf, 0.001); Assert.AreEqual(sumI, imgbuf, 0.001);

            CN.findSubstr(); CN.getRes(out realbuf, out imgbuf);
            Assert.AreEqual(subtrR, realbuf, 0.001); Assert.AreEqual(subtrI, imgbuf, 0.001);

            CN.findMult(); CN.getRes(out realbuf, out imgbuf);
            Assert.AreEqual(multR, realbuf, 0.001); Assert.AreEqual(multI, imgbuf, 0.001);

            CN.findDiv(); CN.getRes(out realbuf, out imgbuf);
            Assert.AreEqual(divR, realbuf, 0.001); Assert.AreEqual(divI, imgbuf, 0.001);
        }

        [TestMethod]
        public void TestQuaternion()
        {
            QuaternionNum QN = new QuaternionNum(1, -1, -1, 3, 1, 3, 4, 3);
            float sumR = 2; Vector3 sumV = new Vector3(2, 3, 6);
            float subtrR = 0; Vector3 subtV = new Vector3(-4, -5, 0);
            float multR = -1; Vector3 multV = new Vector3(-13, 15, 5);

            float realbuf; Vector3 vecbuf;
            QN.findSum(); QN.getRes(out realbuf, out vecbuf);
            Assert.AreEqual(sumR, realbuf, 0.001); Assert.AreEqual(sumV, vecbuf);

            QN.findSubstr(); QN.getRes(out realbuf, out vecbuf);
            Assert.AreEqual(subtrR, realbuf, 0.001); Assert.AreEqual(subtV, vecbuf);

            QN.findMult(); QN.getRes(out realbuf, out vecbuf);
            Assert.AreEqual(multR, realbuf, 0.001); Assert.AreEqual(multV, vecbuf);
        }

        [TestMethod]
        public void TestMod()
        {
            ModNum MN = new ModNum(12, 3, 7);
            int sumM = 1;
            int subtrM = 2;
            int multM = 1;

            MN.findSum(); Assert.AreEqual(sumM, MN.getRes());

            MN.findSubstr(); Assert.AreEqual(subtrM, MN.getRes());

            MN.findMult(); Assert.AreEqual(multM, MN.getRes());
        }
    }
}
