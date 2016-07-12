using kalc.CalculatorsWithTwoArguments;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithTwoArguments
{
    [TestFixture]
    public class MaxTests
    {
        [TestCase(6, 2, 6)]
        [TestCase(8, 2, 8)]
        public void MaxTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Max();
            double result = calculator.Calculate(first, second);

            Assert.AreEqual(expected, result);
        }
    }
}
