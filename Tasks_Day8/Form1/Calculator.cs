using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private int num1;
        private int num2;
        private char op;

        private void btn_1_click_Click(object sender, EventArgs e)
        {
            rtb_equation.AppendText("1");
        }

        private void btn_2_click_Click(object sender, EventArgs e)
        {
            rtb_equation.AppendText("2");

        }

        private void btn_3_click_Click(object sender, EventArgs e)
        {
            rtb_equation.AppendText("3");

        }

        private void btn_4_click_Click(object sender, EventArgs e)
        {
            rtb_equation.AppendText("4");

        }

        private void btn_5_click_Click(object sender, EventArgs e)
        {
            rtb_equation.AppendText("5");

        }

        private void btn_plus_click_Click(object sender, EventArgs e)
        {
            num1 =int.Parse(rtb_equation.Text);
            op = '+';
            rtb_equation.Text= "";
        }

        private void btn_minus_click_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(rtb_equation.Text);
            op = '-';
            rtb_equation.Text = "";
        }

        private void btn_equal_click_Click(object sender, EventArgs e)
        {
            num2 =int.Parse(rtb_equation.Text);

            switch (op)
            {
                case '+':
                    rtb_equation.Text=(num1+ num2).ToString();
                    break;
                case '-':
                    rtb_equation.Text = (num1 - num2).ToString();
                    break;
                case '*':
                    rtb_equation.Text = (num1 * num2).ToString();
                    break;
                case '/':
                    rtb_equation.Text = (num1 / num2).ToString();
                    break;
                case '%':
                    rtb_equation.Text = (num1 % num2).ToString();
                    break;

            }
        }

        private void btn_AC_click_Click(object sender, EventArgs e)
        {
            num1 = num2 = 0;
            rtb_equation.Text = "";
        }

        

        private void btn_divide_click_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(rtb_equation.Text);
            op = '/';
            rtb_equation.Text = "";
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(rtb_equation.Text);
            op = '*';
            rtb_equation.Text = "";
        }

        private void btn_reminder_click_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(rtb_equation.Text);
            op = '%';
            rtb_equation.Text = "";
        }
    }
}
