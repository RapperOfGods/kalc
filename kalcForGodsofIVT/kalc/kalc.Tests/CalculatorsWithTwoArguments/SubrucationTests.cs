using kalc.CalculatorsWithTwoArguments;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithTwoArguments
{
    [TestFixture]
    public class SubructionTests
    {
        [TestCase(6, 2, 4)]
        [TestCase(8, 2, 6)]
        public void SubructionTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Subruction();
            double result = calculator.Calculate(first, second);

            Assert.AreEqual(expected, result);
        }
    }
}
