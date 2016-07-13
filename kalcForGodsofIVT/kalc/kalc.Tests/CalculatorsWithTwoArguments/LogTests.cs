using System;
using kalc.CalculatorsWithTwoArguments;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithTwoArguments
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(6, 6, 1)]
        [TestCase(36, 6, 2)]
        public void LogTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Log();
            double result = calculator.Calculate(first, second);

            Assert.AreEqual(expected, result);
        }

        [TestCase(-7, 6)]
        [TestCase(213, -6)]
        public void LogForNaNTest(double first, double second)
        {
            ITwoArgumentsCalculator calculator = new Log();
            Assert.Throws<Exception>(() => calculator.Calculate(first, second));
        }

    }
}
