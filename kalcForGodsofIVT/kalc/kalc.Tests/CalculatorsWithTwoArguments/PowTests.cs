using System;
using kalc.CalculatorsWithTwoArguments;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithTwoArguments
{
    [TestFixture]
    public class PowTests
    { 
        [TestCase(6, 2, 36)]
        [TestCase(8, 2, 64)]
        public void PowTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Pow();
            double result = calculator.Calculate(first, second);

            Assert.AreEqual(expected, result);
        }

        [TestCase(0, 6)]
        public void PowByZeroTest(double first, double second)
        {
            ITwoArgumentsCalculator calculator = new Pow();
            Assert.Throws<Exception>(() => calculator.Calculate(first, second));
        }

    }
}
