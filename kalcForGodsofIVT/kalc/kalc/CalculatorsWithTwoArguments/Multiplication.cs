
namespace kalc.CalculatorsWithTwoArguments
{
    public class Multiplication: ITwoArgumentsCalculator
    {
        /// <summary>
        /// method multiplication the first by second
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first*second;
        }
    }
}
