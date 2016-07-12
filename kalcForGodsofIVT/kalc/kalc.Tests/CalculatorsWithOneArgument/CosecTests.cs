using System;
using kalc.CalculatorsWithOneArgument;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithOneArgument
{
    [TestFixture]
    public class CosecTests
    {
        [TestCase(3/2.0 * Math.PI, -1)]
        [TestCase(Math.PI/2, 1)]
        public void CosecTest(double argument, double expected)
        {
            IOneArgumentsCalculator calculator = new Cosec();
            double result = calculator.Calculate(argument);

            Assert.AreEqual(expected, result);
        }
    }
}
