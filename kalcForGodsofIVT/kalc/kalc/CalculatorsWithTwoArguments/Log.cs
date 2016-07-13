using System;

namespace kalc.CalculatorsWithTwoArguments
{
    public class Log: ITwoArgumentsCalculator
    {
        /// <summary>
        /// method calculate log
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            if (first < 0 || second <= 0)
            {
                throw new Exception("Некорректные значения");
            }
            return Math.Log(first, second);
        }

    }
}