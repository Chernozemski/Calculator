using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculator
{
    public partial class Form1 : Form
    {
        string operation = "";
        double firstValue = 0;
        bool operationChosen = false;
        bool decimalPointChosen = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void number_clicked(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            textBox1.Text += number.Text;
        }

        private void result(object sender, EventArgs e)
        {

        }
        private void operation_clicked(object sender, EventArgs e)
        {
            if (textBox1.TextLength >= 1)
            {
                Button operation_clicked = (Button)sender;
                operation = operation_clicked.Text.ToString();
                operationChosen = true;
                firstValue = Double.Parse(textBox1.Text);
                textBox1.Clear();
                decimalPointChosen = false;
                label1.Text = firstValue + operation;
            }
        }

        private void clearButton_clicked(object sender, EventArgs e)
        {
            textBox1.Clear();
            decimalPointChosen = false;
        }
        private void Equal(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1)
            {
                switch (operation)
                {
                    case "+":
                        textBox1.Text = (firstValue + double.Parse(textBox1.Text)).ToString();
                        break;
                    case "-":
                        textBox1.Text = (firstValue - double.Parse(textBox1.Text)).ToString();
                        break;
                    case "*":
                        textBox1.Text = (firstValue * double.Parse(textBox1.Text)).ToString();
                        break;
                    case "/":
                        textBox1.Text = (firstValue / double.Parse(textBox1.Text)).ToString();
                        break;
                    default:
                        break;
                }
                operationChosen = false;
                label1.Text = firstValue + operation;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (decimalPointChosen == false && textBox1.Text.Length > 0)
            {
                textBox1.Text += ".";
                decimalPointChosen = true;
            }
        }

        private void ghostCalculation(object sender, EventArgs e)
        {
           
        }
    }
}
