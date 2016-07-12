using System;
using kalc.CalculatorsWithOneArgument;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithOneArgument
{
    [TestFixture]
    public class LnTests
    {
        [TestCase(1, 0)]
        [TestCase(Math.E, 1)]
        public void LnTest(double argument, double expected)
        {
            IOneArgumentsCalculator calculator = new Ln();
            double result = calculator.Calculate(argument);

            Assert.AreEqual(expected, result);
        }
    }
}
