using System;
using System.Windows.Forms;
using kalc.CalculatorsWithOneArgument;
using kalc.CalculatorsWithTwoArguments;
using kalc.SortArray;

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
            try
            {

                double argument1 = Convert.ToDouble(arg1.Text);
                double argument2 = Convert.ToDouble(arg2.Text);

                String name = ((Button) sender).Name;
                ITwoArgumentsCalculator calculator = TwoArgumentsCalculatorFactory.Create_calculator(name);

                double resultValue = calculator.Calculate(argument1, argument2);

                result.Text = resultValue.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка: " + exc.Message);
            }
        }


        private void MathOperationForOneArguments(object sender, EventArgs e)
        {
            try
            {
                double argument1 = Convert.ToDouble(arg1.Text);

                String name = ((Button) sender).Name;
                IOneArgumentsCalculator calculator = OneArgumentFactory.Create_calculator(name);

                double resultValue = calculator.Calculate(argument1);

                result.Text = resultValue.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка: " + exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = textBox1.Text.Split(' ');
                int[] intArray = new int[stringArray.Length];

                for (int i = 0; i < stringArray.Length; i++)
                {
                    intArray[i] = Convert.ToInt32(stringArray[i]);
                }

                string name = ((Button) sender).Name;
                int[] resultArray = SortFactory.getSort(name).sort(intArray);
                string resultString = "";

                for (int i = 0; i < resultArray.Length; i++)
                {
                    resultString += resultArray[i].ToString() + " ";
                }
                result.Text = resultString;

            }
            catch (Exception exp)
            {
                MessageBox.Show("ERROR " + exp.Message);
            }
        }
    }




}
