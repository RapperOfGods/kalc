using System;

namespace kalc.CalculatorsWithTwoArguments
{
    public class Pow : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}