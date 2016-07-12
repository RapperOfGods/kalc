using System;

namespace kalc.CalculatorsWithOneArgument
{
    public class Sqrt : IOneArgumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sqrt(argument);
        }
    }
}