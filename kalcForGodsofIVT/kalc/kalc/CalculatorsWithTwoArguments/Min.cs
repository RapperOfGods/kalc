using System;

namespace kalc.CalculatorsWithTwoArguments
{
    public class Min : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }

    }
}