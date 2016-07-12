using kalc.CalculatorsWithTwoArguments;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithTwoArguments
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(6, 2, 3)]
        [TestCase(8, 2, 4)]
        public void DivisionTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Division();
            double result = calculator.Calculate(first, second);

            Assert.AreEqual(expected, result);
        }
    }
}
