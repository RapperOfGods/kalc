using System;

namespace kalc.CalculatorsWithOneArgument
{
    public class Cosec : IOneArgumentsCalculator
    {
        public double Calculate(double argument)
        {
            return 1.0 / Math.Sin(argument);
        }

    }
}