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
    }
}
