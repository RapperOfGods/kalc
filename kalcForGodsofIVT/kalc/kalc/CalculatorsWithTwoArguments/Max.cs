using System;

namespace kalc.CalculatorsWithTwoArguments
{
    public class Max : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Max(first, second);
        }

    }
}