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
                case "Mod":
                    txtResult.Text = (enterFirstValue % enterSecondValue).ToString();
                    break;
                case "Exp":
                    txtResult.Text = (enterFirstValue * Math.Pow(10, enterSecondValue)).ToString();
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

        private void btnPI_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double log = Convert.ToDouble(txtResult.Text);
            log = Math.Log10(log);
            txtResult.Text = Convert.ToString(log);
        }

        private void btnSine_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtResult.Text);
            sin = Math.Sin(sin);
            txtResult.Text = Convert.ToString(sin);
        }

        private void btnCosine_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtResult.Text);
            cos = Math.Cos(cos);
            txtResult.Text = Convert.ToString(cos);
        }

        private void btnTangent_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txtResult.Text);
            tan = Math.Tan(tan);
            txtResult.Text = Convert.ToString(tan);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            txtResult.Text = (enterFirstValue / 100 * Convert.ToDouble(txtResult.Text)).ToString();
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            int binary = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(binary, 8);
        }

        private void btnNaturalLog_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(txtResult.Text);
            lnx = Math.Log(lnx);
            txtResult.Text = Convert.ToString(lnx);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int binary = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(binary, 16);
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            txtResult.Text = (1.0 / Convert.ToDouble(txtResult.Text)).ToString();  
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            int binary = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(binary, 2);
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            double x = Math.Pow(Convert.ToDouble(txtResult.Text), 3);
            txtResult.Text = x.ToString();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToInt32(dec).ToString();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double x = Math.Pow(Convert.ToDouble(txtResult.Text), 2);
            txtResult.Text = x.ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(txtResult.Text);
            sqrt = Math.Sqrt(sqrt);
            txtResult.Text = Convert.ToString(sqrt);
        }

        private void btnHypSine_Click(object sender, EventArgs e)
        {
            double sinh = Convert.ToDouble(txtResult.Text);
            sinh = Math.Sinh(sinh);
            txtResult.Text = Convert.ToString(sinh);
        }

        private void btnHypCosine_Click(object sender, EventArgs e)
        {
            double cosh = Convert.ToDouble(txtResult.Text);
            cosh = Math.Cosh(cosh);
            txtResult.Text = Convert.ToString(cosh);
        }

        private void btnHypTangent_Click(object sender, EventArgs e)
        {
            double tanh = Convert.ToDouble(txtResult.Text);
            tanh = Math.Tanh(tanh);
            txtResult.Text = Convert.ToString(tanh);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 270; //818
            txtResult.Width = 238;
            
        }
    }
}
