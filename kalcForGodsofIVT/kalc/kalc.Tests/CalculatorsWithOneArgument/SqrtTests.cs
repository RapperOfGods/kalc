using kalc.CalculatorsWithOneArgument;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithOneArgument
{
    [TestFixture]
    public class SqrtTests
    {
        [TestCase(9, 3)]
        [TestCase(4, 2)]
        public void SqrtTest(double argument, double expected)
        {
            IOneArgumentsCalculator calculator = new Sqrt();
            double result = calculator.Calculate(argument);

            Assert.AreEqual(expected, result);
        }
    }
}
