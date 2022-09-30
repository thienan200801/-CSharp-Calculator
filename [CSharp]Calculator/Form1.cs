using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _CSharp_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double a, b;

        private void btn0_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == null || resultTxt.Text == "0") resultTxt.Text = "0";
            else resultTxt.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == null || resultTxt.Text == "0") resultTxt.Text = "1";
            else resultTxt.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == null || resultTxt.Text == "0") resultTxt.Text = "2";
            else resultTxt.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == null || resultTxt.Text == "0") resultTxt.Text = "3";
            else resultTxt.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == null || resultTxt.Text == "0") resultTxt.Text = "4";
            else resultTxt.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == null || resultTxt.Text == "0") resultTxt.Text = "5";
            else resultTxt.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == null || resultTxt.Text == "0") resultTxt.Text = "6";
            else resultTxt.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == null || resultTxt.Text == "0") resultTxt.Text = "7";
            else resultTxt.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == null || resultTxt.Text == "8") resultTxt.Text = "8";
            else resultTxt.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == null || resultTxt.Text == "0") resultTxt.Text = "9";
            else resultTxt.Text += btn9.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == null || resultTxt.Text == "0") resultTxt.Text = "0.";
            else resultTxt.Text += btnDot.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultTxt.Text == null || resultTxt.Text == "0");
                else resultTxt.Text = resultTxt.Text.Remove(resultTxt.Text.Length - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            resultTxt.Text = "0";
        }
        private double Plus(double x, double y)
        {
            return x + y;
        }
        private double Minus(double x, double y)
        {
            return x - y;
        }
        private double Multiply(double x, double y)
        {
            return x * y;
        }
        private bool Divide(double x, double y, out double ans)
        {
            if (y != 0)
            {
                ans = x / y;
                return true;
            }
            else
            {
                ans = 0;
                return false;
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            int signIndex = 0;
            double ans = 0;
            char sign = ' ';
            for(int i = 0; i<resultTxt.Text.Length; i++)
            {
                if (resultTxt.Text[i] == '+' || 
                    resultTxt.Text[i] == '-' ||
                    resultTxt.Text[i] == '*' || 
                    resultTxt.Text[i] == '/')
                {
                    signIndex = i;
                    sign = resultTxt.Text[i];
                    break;
                }
            }
            a = Double.Parse(resultTxt.Text.Substring(0, signIndex));
            b = Double.Parse(resultTxt.Text.Substring(signIndex+1));

            if (sign == '+') ans = Plus(a, b);
            else if (sign == '-') ans = Minus(a, b);
            else if (sign == '*') ans = Multiply(a, b);
            else if (sign == '/')
            {
                if (!Divide(a, b, out ans)) MessageBox.Show("Cannot divide for 0");
                else Divide(a, b, out ans);
            }

            resultTxt.Text = ans.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(resultTxt.Text == null || resultTxt.Text == "0") resultTxt.Text = "0";
            else resultTxt.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == null || resultTxt.Text == "0") resultTxt.Text = "0";
            else resultTxt.Text += "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == null || resultTxt.Text == "0") resultTxt.Text = "0";
            else resultTxt.Text += "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == null || resultTxt.Text == "0") resultTxt.Text = "0";
            else resultTxt.Text += "/";
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            resultTxt.Text = "";
        }
    }

}
