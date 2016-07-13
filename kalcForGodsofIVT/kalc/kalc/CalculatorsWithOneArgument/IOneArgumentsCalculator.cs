namespace kalc.CalculatorsWithOneArgument
{
    public interface IOneArgumentsCalculator
    {
        /// <summary>
        /// interface's method for math operations
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        double Calculate(double argument);
    }
}