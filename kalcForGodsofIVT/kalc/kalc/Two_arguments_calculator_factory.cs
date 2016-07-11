using System;

namespace kalc
{
    public static class Two_arguments_calculator_factory
    {
        public static I_Two_arguments_calculator Create_calculator(String calculator_name)
        {

            switch (calculator_name)
            {
                case "addition":
                    return new Addition();

                case "division":
                    return new Division();

                case "multiplication":
                    return new Multiplication();

                case "subraction":
                    return new Subruction();

                default:
                    throw new Exception("unknown operation");

            }


        }
    }
}