using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }







        private void multiplication_Click(object sender, EventArgs e)
        {

            math_operations(sender);

        }

        private void division_Click(object sender, EventArgs e)
        {
            math_operations(sender);
        }

        private void subraction_Click(object sender, EventArgs e)
        {
            math_operations(sender);
        }

        private void addition_Click(object sender, EventArgs e)
        {
            math_operations(sender);
        }




        private void math_operations(object sender)
        {
            double argument1 = Convert.ToDouble(arg1.Text);
            double argument2 = Convert.ToDouble(arg2.Text);


            String name = ((Button) sender).Name;
            I_Two_arguments_calculator calculator = Two_arguments_calculator_factory.Create_calculator(name);

            double temp_result = calculator.Calculate(argument1, argument2);



            result.Text = temp_result.ToString();
        }


    }
}
