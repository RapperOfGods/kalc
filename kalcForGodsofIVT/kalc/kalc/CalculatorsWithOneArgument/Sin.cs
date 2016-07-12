using System;

namespace kalc.CalculatorsWithOneArgument
{
    public class Sin : IOneArgumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}