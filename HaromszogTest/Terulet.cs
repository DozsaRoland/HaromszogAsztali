using Microsoft.VisualStudio.TestTools.UnitTesting;
using HaromszogAsztali;
using System;


namespace HaromszogTest
{
    [TestClass]
    public class Terulet 
    {
        [TestMethod]
        [DataRow(10, 10, 10, 43.3)]
        [DataRow(2, 9, 8, 7.3)]
        [DataRow(9823, 121, 9811, 590989.3)]
        public void JoTerulet(double a, double b, double c, double expected)
        {
            _3szogalapok t = new _3szogalapok(a, b, c);
            double result = t.T();
            Assert.AreEqual(Math.Round(result, 1), expected);
        }

        [TestMethod]
        [DataRow(10, 10, 10, 43.3)]
        [DataRow(2, 9, 8, 20)]
        [DataRow(9823, 121, 9811, 0)]
        public void RosszTerulet(double a, double b, double c, double expected)
        {
            _3szogalapok t = new _3szogalapok(a, b, c);
            double result = t.T();
            Assert.AreNotEqual(result, expected);
        }

    }
}
