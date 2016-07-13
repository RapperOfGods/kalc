using System;

namespace kalc.CalculatorsWithOneArgument
{
    public class Ln : IOneArgumentsCalculator
    {
        /// <summary>
        /// calculate ln
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Log(argument, Math.E);
        }

    }
}