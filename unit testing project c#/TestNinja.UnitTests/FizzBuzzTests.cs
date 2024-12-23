using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class FizzBuzzTests
    {
        [Test]
        public void GetOutput_NumberIsDivisibleBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result,Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_NumberIsDivisibleBy3Only_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(9);

            Assert.That(result, Is.EqualTo("Fizz"));
        } 
        
        [Test]
        public void GetOutput_NumberIsDivisibleBy5Only_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(10);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_NumberIsNotDivisibleBy5Or3_ReturnSameNumber()
        {
            var result = FizzBuzz.GetOutput(8);

            Assert.That(result, Is.EqualTo("8"));
        }
    }
}
