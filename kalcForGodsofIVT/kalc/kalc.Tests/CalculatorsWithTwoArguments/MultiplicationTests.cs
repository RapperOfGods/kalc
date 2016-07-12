using kalc.CalculatorsWithTwoArguments;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithTwoArguments
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(6, 2, 12)]
        [TestCase(8, 2, 16)]
        public void MultiplicationTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Multiplication();
            double result = calculator.Calculate(first, second);

            Assert.AreEqual(expected, result);
        }
    }
}
