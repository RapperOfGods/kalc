namespace kalc.CalculatorsWithTwoArguments
{
    public class Addition: ITwoArgumentsCalculator
    {
        /// <summary>
        /// method addition two arguments
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first + second;
        }

    }
}