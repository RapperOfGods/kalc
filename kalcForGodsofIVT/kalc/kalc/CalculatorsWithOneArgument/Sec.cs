using System;

namespace kalc.CalculatorsWithOneArgument
{
    public class Sec : IOneArgumentsCalculator
    {
        /// <summary>
        /// calculate sec
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return 1.0/Math.Cos(argument);
        }
    }
}