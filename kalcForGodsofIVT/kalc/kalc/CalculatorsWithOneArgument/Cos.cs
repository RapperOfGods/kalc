using System;

namespace kalc.CalculatorsWithOneArgument
{
    public class Cos : IOneArgumentsCalculator
    {
        /// <summary>
        /// calculate cos
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {

            return Math.Cos(argument);

        }

    }
}