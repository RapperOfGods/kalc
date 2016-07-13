namespace kalc.CalculatorsWithTwoArguments
{
    public interface ITwoArgumentsCalculator
    {
        /// <summary>
        /// interface's method for math operations
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        double Calculate(double first, double second);
    }
}