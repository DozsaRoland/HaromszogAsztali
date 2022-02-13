using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaromszogAsztali;

namespace HaromszogTest
{
    [TestClass]
    class Szerkeszheto_e
    {
        [TestMethod]
        [DataRow(10, 10, 10)]
        [DataRow(2, 9, 8)]
        [DataRow(9823, 121, 9811)]
        public void SzerkesztIgaz(double a, double b, double c)
        {
            _3szogalapok s = new _3szogalapok(a, b, c);
            bool result = s.Szerkeszt();
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(0, 10, 10)]
        [DataRow(2, 3, 8)]
        [DataRow(1, 111, 1)]
        public void Szerkesztkivetelez(double a, double b, double c)
        {
            _3szogalapok s = new _3szogalapok(a, b, c);
            try
            {
                bool result = s.Szerkeszt();
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is _3szogkivetel);
            }
        }
    }
}
