namespace kalc.CalculatorsWithOneArgument
{
    public class Sqr : IOneArgumentsCalculator
    {
        /// <summary>
        /// calculate sqr
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return argument*argument;
        }
    }
}