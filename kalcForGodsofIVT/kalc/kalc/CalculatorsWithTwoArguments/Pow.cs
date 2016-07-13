using System;

namespace kalc.CalculatorsWithTwoArguments
{
    public class Pow : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            if (first == 0)
            {
                throw new Exception("Возведения нулика в степень");
            }
            return Math.Pow(first, second);
        }
    }
}