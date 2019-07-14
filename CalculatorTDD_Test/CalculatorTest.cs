using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCalculatorAPP;

namespace CalculatorTDD_Test
{
    [TestClass]
    public class CalculatorTest
    {
        ICalculator sut;
        [TestInitialize]
        public void TestSetUp() {
            sut = new Calculator();
        }

        [TestMethod]
        public void shouldAdd() {
            int result = sut.Add(8, 9);
            Assert.AreEqual(17,result);
        }
        
    }
}
