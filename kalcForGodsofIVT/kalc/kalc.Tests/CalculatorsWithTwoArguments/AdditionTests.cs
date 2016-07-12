using kalc.CalculatorsWithTwoArguments;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithTwoArguments
{
    [TestFixture]
    public class AdditionTests
    {
        [TestCase(6, 2, 8)]
        [TestCase(8, 2, 10)]
        public void AdditionTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Addition();
            double result = calculator.Calculate(first, second);

            Assert.AreEqual(expected, result);
        }
    }
}
