using System;

namespace kalc.CalculatorsWithOneArgument
{
    public static class OneArgumentFactory
    {
        /// <summary>
        /// method create calculator object
        /// </summary>
        /// <param name="calculator_name"></param>
        /// <returns></returns>
        public static IOneArgumentsCalculator Create_calculator(String calculator_name)
        {

            switch (calculator_name)
            {
                case "cos":
                    return new Cos();

                case "sin":
                    return new Sin();

                case "ln":
                    return new Ln();

                case "exp":
                    return new Exp();

                case "sqr":
                    return new Sqr();

                case "sqrt":
                    return new Sqrt();

                case "cosec":
                    return new Cosec();

                case "sec":
                    return new Sec();

                default:
                    throw new Exception("unknown operation");

            }

        }
    }
}