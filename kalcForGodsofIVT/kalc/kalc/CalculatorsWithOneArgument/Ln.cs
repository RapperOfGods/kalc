using System;

namespace kalc.CalculatorsWithOneArgument
{
    public class Ln : IOneArgumentsCalculator
    {

        public double Calculate(double argument)
        {
            return Math.Log(argument, Math.E);
        }

    }
}