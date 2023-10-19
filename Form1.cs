using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool operationPerformed = false;

        private void HandleButtonClick(Button button)
        {
            if (operationPerformed)
            {
                textBox1.Clear();
                operationPerformed = false;
            }
            textBox1.Text += button.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pi_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);

        }

        private void one_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void eight_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);

        }

        private void six_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);

        }

        private void nine_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);

        }

        private void two_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);

        }

        private void four_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);

        }

        private void five_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);

        }

        private void e_Click(object sender, EventArgs e)
        {
            if (operationPerformed)
            {
                textBox1.Clear();
                operationPerformed = false;
            }
            textBox1.Text += " 2.71828 ";
        }

        private void three_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);

        }

        private void zero_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);

        }

        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(textBox1.Text, "");
                textBox1.Text = result.ToString();
                operationPerformed = true;
            }
            catch (Exception ex)
            {
                textBox1.Text = "Error";
                // Handle and log the error, e.g., division by zero.
            }
            
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);
        }

        private void times_Click(object sender, EventArgs e)
        {
            if (operationPerformed)
            {
                textBox1.Clear();
                operationPerformed = false;
            }
            textBox1.Text += ((Button)sender).Text; ;
        }

        private void over_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);
        }

        private void dot_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
