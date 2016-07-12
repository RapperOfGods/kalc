using System;

namespace kalc.CalculatorsWithOneArgument
{
    public class Sec : IOneArgumentsCalculator
    {
        public double Calculate(double argument)
        {
            return 1.0/Math.Cos(argument);
        }
    }
}