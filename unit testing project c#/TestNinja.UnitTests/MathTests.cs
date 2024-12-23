using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        [Test]
        [Ignore("Because I wanted to!")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            // Arrange
            //var math = new Math();

            // Act
            var result = _math.Add(1, 2);

            // Assert
            Assert.That(result,Is.EqualTo(3));

        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_RetrunTheGreaterArgument(int a,int b,int expectedResult)
        {

            var result = _math.Max(a, b);

            Assert.That(result,Is.EqualTo(expectedResult));
        } 
        
        //public void Max_SecondArgumentIsGreater_RetrunTheSecondArgument()
        //{
        //    //var math = new Math();

        //    var result = _math.Max(1, 2);

        //    Assert.That(result,Is.EqualTo(2));
        //}
        
        //public void Max_ArgumentsAreEqual_RetrunTheSameArgument()
        //{
        //    //var math = new Math();

        //    var result = _math.Max(1, 1);

        //    Assert.That(result,Is.EqualTo(1));
        //}

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            // you can write any of theses tests according to your need

            //Assert.That(result,Is.Not.Empty);

            //Assert.That(result.Count(), Is.EqualTo(3));

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            // this assertion is equivalent to the direct above ones
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            //Assert.That(result, Is.Ordered);
            //Assert.That(result,Is.Unique);
        }

    }
}
