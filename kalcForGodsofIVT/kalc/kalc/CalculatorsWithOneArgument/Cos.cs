using System;

namespace kalc.CalculatorsWithOneArgument
{
    public class Cos : IOneArgumentsCalculator
    {

        public double Calculate(double argument)
        {

            return Math.Cos(argument);

        }

    }
}