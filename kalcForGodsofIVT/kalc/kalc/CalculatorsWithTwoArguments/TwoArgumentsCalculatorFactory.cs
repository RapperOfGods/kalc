using System;

namespace kalc.CalculatorsWithTwoArguments
{
    public static class TwoArgumentsCalculatorFactory
    {
        public static ITwoArgumentsCalculator Create_calculator(String calculator_name)
        {

            switch (calculator_name)
            {
                case "addition":
                    return new Addition();

                case "division":
                    return new Division();

                case "multiplication":
                    return new Multiplication();

                case "subruction":
                    return new Subruction();

                case "log":
                    return new Log();

                case "max":
                    return new Max();

                case "min":
                    return new Min();

                case "pow":
                    return new Pow();

                default:
                    throw new Exception("unknown operation");

            }
        }
    }
}