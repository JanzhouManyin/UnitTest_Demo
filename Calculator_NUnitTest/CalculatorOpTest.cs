using Calculate;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_NUnitTest
{
    [TestFixture]
    public class CalculatorOpTest
    {
        [Test]
        public void ShouldAddReturnNineWhenPassFiveandFour()
        {
            //Average
            Calculater sut = new Calculater();
            int result = sut.Add(5, 4);
            Assert.That(result,Is.EqualTo(9));
        }
        [Test]
        public void ShouldAddReturnTwentyWhenPassFiveandFour()
        {
            //Average
            Calculater sut = new Calculater();
            int result = sut.Add(5, 4);
            Assert.That(result, Is.EqualTo(20));
        }
    }
}
