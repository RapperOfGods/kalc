using System;

namespace kalc.CalculatorsWithOneArgument
{
    public class Sin : IOneArgumentsCalculator
    {
        /// <summary>
        /// calculate sin
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}