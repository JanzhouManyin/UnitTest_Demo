using Calculate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_test
{
    [TestClass]
    public class CalculatorOpTest
    {
        [TestMethod]
        public void ShouldAddReturnNineWhenPassFiveandFour() {
            //Average
            Calculater sut = new Calculater();
            int result = sut.Add(5, 4);
            Assert.AreEqual(9, result);

        }
        [TestMethod]
        public void ShouldMulReturnTwentyWhenPassFiveandFour() {
            Calculater sut = new Calculater();
            int result = sut.Mul(4, 5);

            Assert.AreEqual(20, result);

        }
    }
}
