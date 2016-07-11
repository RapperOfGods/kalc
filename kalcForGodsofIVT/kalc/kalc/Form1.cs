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

            double temp_result = 0;

            switch (( (Button)sender).Name )
            {
                case "addition":
                    temp_result = argument1 + argument2; break;

                case "division":
                    temp_result = argument1 / argument2; break;

                case "multiplication": 
                    temp_result = argument1 * argument2; break;

                case "subraction": 
                    temp_result = argument1 - argument2; break;

                default:
                    throw new Exception("unknown operation");

            }


            result.Text = temp_result.ToString();
        }


    }
}
