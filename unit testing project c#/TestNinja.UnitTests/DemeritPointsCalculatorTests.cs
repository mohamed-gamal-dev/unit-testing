using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            var calc = new DemeritPointsCalculator();


            Assert.That(() => calc.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    

        [Test]
        [TestCase(0,0)]
        [TestCase(50,0)]
        [TestCase(65,0)]
        [TestCase(66,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemiritPoints(int speed,int expectedResult)
        {
            var calc = new DemeritPointsCalculator();

            var result = calc.CalculateDemeritPoints(speed);

            Assert.That(result,Is.EqualTo(expectedResult));
        }



      
    }
}
