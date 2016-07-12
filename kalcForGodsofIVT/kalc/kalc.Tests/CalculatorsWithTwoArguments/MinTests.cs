using kalc.CalculatorsWithTwoArguments;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithTwoArguments
{
    [TestFixture]
    public class MinTests
    {
        [TestCase(6, 2, 2)]
        [TestCase(8, 2, 2)]
        public void MinTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Min();
            double result = calculator.Calculate(first, second);

            Assert.AreEqual(expected, result);
        }
    }
}
