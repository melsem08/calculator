using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        string enterOperator;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                    {
                        txtResult.Text += num.Text;
                    }
                }
                else
                {
                    txtResult.Text += num.Text;
                }
            }
        }

        private void mathOperators(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enterFirstValue = Convert.ToDouble(txtResult.Text);
            enterOperator = num.Text;
            txtResult.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtResult.Text);

            switch (enterOperator)
            {
                case "+":
                    txtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;
                case "-":
                    txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;
                case "*":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;
                case "/":
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

            string firstValue, secondValue;

            firstValue = Convert.ToString(enterFirstValue);
            secondValue = Convert.ToString(enterSecondValue);

            firstValue = "";
            secondValue = "";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double currentValue = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * currentValue);
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }

            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 270; //818
            txtResult.Width = 238;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 535; //818
            txtResult.Width = 500;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCalculator;

            exitCalculator = MessageBox.Show("Confirm if you want to exit", "Calculator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitCalculator == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 270; //818
            txtResult.Width = 238;
            
        }
    }
}
