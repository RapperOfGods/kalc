using System;

namespace kalc.CalculatorsWithOneArgument
{
    public class Sqrt : IOneArgumentsCalculator
    {
        /// <summary>
        /// calculate sqrt
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Sqrt(argument);
        }
    }
}