using Math;
using NUnit.Framework;

// ReSharper disable ConvertToConstant.Local

namespace MathTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_WhenPositive_ValidExpected()
        {
            var first = 5;
            var second = 10;hjkhk

            var expected = 15;
            var result = Calculator.Add(first, second);

            Assert.AreEqual(expected, result);
        }
    }
}