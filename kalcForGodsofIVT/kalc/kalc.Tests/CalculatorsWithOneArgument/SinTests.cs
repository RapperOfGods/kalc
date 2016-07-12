using System;
using kalc.CalculatorsWithOneArgument;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithOneArgument
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(0, 0)]
        [TestCase(Math.PI / 2, 1)]
        public void SinTest(double argument, double expected)
        {
            IOneArgumentsCalculator calculator = new Sin();
            double result = calculator.Calculate(argument);

            Assert.AreEqual(expected, result);
        }
    }
}
