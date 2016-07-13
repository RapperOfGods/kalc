using System;

namespace kalc.CalculatorsWithOneArgument
{
    public class Exp : IOneArgumentsCalculator
    {
        /// <summary>
        /// calculate exp
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Exp(argument);
        }

    }
}