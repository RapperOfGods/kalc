namespace kalc.CalculatorsWithOneArgument
{
    public class Sqr : IOneArgumentsCalculator
    {
        public double Calculate(double argument)
        {
            return argument*argument;
        }
    }
}