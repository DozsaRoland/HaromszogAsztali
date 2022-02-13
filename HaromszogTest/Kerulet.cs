using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HaromszogAsztali;

namespace HaromszogTest
{
    [TestClass]
    public class Kerulet
    {
        [TestMethod]
        [DataRow(10, 10, 10, 30)]
        [DataRow(2, 9, 8, 19)]
        [DataRow(9823, 121, 9811, 19755)]
        public void JoKerulet(double a, double b, double c, double expected)
        {
            _3szogalapok k = new _3szogalapok(a, b, c);
            double result = k.K();
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow(10, 10, 10, 30.000001)]
        [DataRow(2, 9, 8, 20)]
        [DataRow(9823, 121, 9811, 0)]
        public void RosszKerulet(double a, double b, double c, double expected)
        {
            _3szogalapok k = new _3szogalapok(a, b, c);
            double result = k.K();
            Assert.AreNotEqual(result, expected);
        }
    }
}
