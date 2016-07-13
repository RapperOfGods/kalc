using System;
using kalc.CalculatorsWithOneArgument;
using kalc.CalculatorsWithTwoArguments;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithTwoArguments
{
    class TwoArgumentsCalculatorFactoryTests
    {
        [TestCase("addition", typeof(Addition))]
        [TestCase("division", typeof(Division))]
        [TestCase("log", typeof(Log))]
        [TestCase("max", typeof(Max))]
        [TestCase("min", typeof(Min))]
        [TestCase("multiplication", typeof(Multiplication))]
        [TestCase("pow", typeof(Pow))]
        [TestCase("subruction", typeof(Subruction))]
        public void TwoArgumentsCalculatorFactoryTest(string name, Type type)
        {
            var calculator = TwoArgumentsCalculatorFactory.Create_calculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}
