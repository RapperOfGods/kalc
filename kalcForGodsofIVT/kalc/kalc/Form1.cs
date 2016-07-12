using System;
using System.Windows.Forms;
using kalc.CalculatorsWithOneArgument;
using kalc.CalculatorsWithTwoArguments;

namespace kalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MathOperationForTwoArguments(object sender, EventArgs e)
        {
            double argument1 = Convert.ToDouble(arg1.Text);
            double argument2 = Convert.ToDouble(arg2.Text);
            
            String name = ((Button)sender).Name;
            ITwoArgumentsCalculator calculator = TwoArgumentsCalculatorFactory.Create_calculator(name);
            
            double resultValue = calculator.Calculate(argument1, argument2);
            
            result.Text = resultValue.ToString();
        }


        private void MathOperationForOneArguments(object sender, EventArgs e)
        {
            double argument1 = Convert.ToDouble(arg1.Text);

            String name = ((Button)sender).Name;
            IOneArgumentsCalculator calculator = OneArgumentFactory.Create_calculator(name);

            double resultValue = calculator.Calculate(argument1);

            result.Text = resultValue.ToString();
        }
    }
}
