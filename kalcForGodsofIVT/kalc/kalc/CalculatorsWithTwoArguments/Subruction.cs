namespace kalc.CalculatorsWithTwoArguments
{
    public class Subruction: ITwoArgumentsCalculator
    {
        /// <summary>
        /// method subtraction from the first by second
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}