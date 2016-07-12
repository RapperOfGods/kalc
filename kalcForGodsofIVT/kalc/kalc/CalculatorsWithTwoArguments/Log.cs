using System;

namespace kalc.CalculatorsWithTwoArguments
{
    public class Log: ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }

    }
}