using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns_z7;

namespace CalcTest
{
    [TestClass]
    public class CalcTest
    {
        Calculator calculator = new Calculator();
       
        [TestMethod]
        public void TestPlus()
        {
            int res = calculator.Plus(10, 10);
            Assert.AreEqual(20, res);
        }

        [TestMethod]
        public void TestMinus()
        {
            int res = calculator.Minus(10, 5);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void TestMult()
        {

           
            int res = calculator.Mult(10, 10);
            Assert.AreEqual(200 ,res);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDevWithZeroEx()
        {
            int res = calculator.Dev(10, 0);
            
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestSqrtWithE()
        {
            double res = calculator.Sqrt(-10);

        }
        [TestMethod]
        public void TestSqrt()
        {
            double res = calculator.Sqrt(36);
            Assert.AreEqual(6, res);
        }


        [TestMethod]
        public void TestDev()
        {
            int res = calculator.Dev(10, 2);
            Assert.AreEqual(5, res);
        }
    }
}
