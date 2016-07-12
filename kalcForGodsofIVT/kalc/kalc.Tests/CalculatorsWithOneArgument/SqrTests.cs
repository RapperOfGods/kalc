using kalc.CalculatorsWithOneArgument;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithOneArgument
{
    [TestFixture]
    public class SqrTests
    {
        [TestCase(6, 36)]
        [TestCase(8, 64)]
        public void SqrTest(double argument, double expected)
        {
            IOneArgumentsCalculator calculator = new Sqr();
            double result = calculator.Calculate(argument);

            Assert.AreEqual(expected, result);
        }
    }
}
