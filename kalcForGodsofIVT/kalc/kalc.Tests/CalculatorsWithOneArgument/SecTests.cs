using System;
using kalc.CalculatorsWithOneArgument;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithOneArgument
{
    [TestFixture]
    public class SecTests
    {
        [TestCase(0, 1)]
        [TestCase(Math.PI, -1)]
        public void SecTest(double argument, double expected)
        {
            IOneArgumentsCalculator calculator = new Sec();
            double result = calculator.Calculate(argument);

            Assert.AreEqual(expected, result);
        }
    }
}
