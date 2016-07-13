using System;

namespace kalc.CalculatorsWithTwoArguments
{
    public class Max : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method calculate max value by two arguments
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Max(first, second);
        }

    }
}