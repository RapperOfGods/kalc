using System;
using kalc.CalculatorsWithOneArgument;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithOneArgument
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(0, 1)]
        [TestCase(Math.PI, -1)]
        public void CosTest(double argument, double expected)
        {
            IOneArgumentsCalculator calculator = new Cos();
            double result = calculator.Calculate(argument);

            Assert.AreEqual(expected, result);
        }
    }
}
