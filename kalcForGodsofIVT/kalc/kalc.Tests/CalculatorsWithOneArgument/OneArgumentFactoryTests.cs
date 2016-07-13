using System;
using kalc.CalculatorsWithOneArgument;
using NUnit.Framework;

namespace kalc.Tests.CalculatorsWithOneArgument
{
    [TestFixture]
    public class OneArgumentFactoryTests
    {
        [TestCase("cos", typeof(Cos))]
        [TestCase("sin", typeof(Sin))]
        [TestCase("cosec", typeof(Cosec))]
        [TestCase("exp", typeof(Exp))]
        [TestCase("ln", typeof(Ln))]
        [TestCase("sec", typeof(Sec))]
        [TestCase("sqr", typeof(Sqr))]
        [TestCase("sqrt", typeof(Sqrt))]
        public void OneArgumentFactoryTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.Create_calculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}
