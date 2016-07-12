using System;

namespace kalc.CalculatorsWithOneArgument
{
    public class Exp : IOneArgumentsCalculator
    {

        public double Calculate(double argument)
        {
            return Math.Exp(argument);
        }

    }
}