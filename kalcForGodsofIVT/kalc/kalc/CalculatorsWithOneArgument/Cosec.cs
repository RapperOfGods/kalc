using System;

namespace kalc.CalculatorsWithOneArgument
{
    public class Cosec : IOneArgumentsCalculator
    {
        /// <summary>
        /// calculate cosec
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return 1.0 / Math.Sin(argument);
        }

    }
}