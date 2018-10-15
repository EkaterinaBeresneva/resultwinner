using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinnerDinner;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double max = 0;
            int index = 0;
            double[,] arr = {
                { 1.0, 2.0, 3.0},
                { 4.0, 5.0, 6.0},
                { 1.0, 1.0, 2.0},
                { 2.0, 2.0, 4.0},
                { 4.0, 5.0, 6.0}
            };
            WinnerDinner.Program.findMax(arr, out max, out index,5,3);

            Assert.AreEqual(6, max, 0.01);
            Assert.AreEqual(1, index);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double max = 0;
            int index = 0;
            double[,] arr = {
                { -1.0, -2.0, -3.0},
                { 4.0, 5.0, 6.0},
                { -1.0,-1.0, -2.0},
                { -2.0, -2.0, 4.0},
                { 4.0, 5.0, 6.0}
            };
            WinnerDinner.Program.findMax(arr, out max, out index,5,3);

            Assert.AreEqual(6, max);
            Assert.AreEqual(1, index);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double max = 0;
            int index = 0;
            double[,] arr = {
                { -1.0, -2.0, -3.0},
                { 4.0, 5.0, 6.0},
                { -1.0,-1.0, -2.0},
                { -2.0, -2.0, 4.0}
            };
            WinnerDinner.Program.findMax(arr, out max, out index,4,3);

            Assert.AreEqual(6, max);
            Assert.AreEqual(1, index);
        }
    }
}
