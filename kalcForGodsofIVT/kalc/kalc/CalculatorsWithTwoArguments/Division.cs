using System;

namespace kalc.CalculatorsWithTwoArguments
{
    public class Division: ITwoArgumentsCalculator
    {
        /// <summary>
        /// method division the first by second
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на нулик");
            }

            return first / second;
        }

    }
}