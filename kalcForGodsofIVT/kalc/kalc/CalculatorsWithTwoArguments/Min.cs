using System;

namespace kalc.CalculatorsWithTwoArguments
{
    public class Min : ITwoArgumentsCalculator
    {
        /// <summary>
        ///  method calculate min value by two arguments
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }

    }
}