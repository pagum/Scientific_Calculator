using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool enter_value = false;
        float iCelsius, iFahrenheit, iKelvin;
        char iOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 245; ;
            txtDisplay.Width = 215;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 245; ;
            txtDisplay.Width = 215;

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width =480;
            txtDisplay.Width = 450;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 770;
            txtDisplay.Width = 450;
            txtConvert.Focus();
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox1.Location = new Point(465, 25);
            groupBox1.Width= 367;
            groupBox1.Height = 386;
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 770;
            txtDisplay.Width = 450;
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 770;
            txtDisplay.Width = 450;
            txtMultiply.Focus();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;

            groupBox3.Location = new Point(465,25);
            groupBox1.Width = 367;
            groupBox1.Height = 386;


        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains(","))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text=="")
            {
                txtDisplay.Text = "0";
            }
        }

        private void Aritmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            label1.Text = System.Convert.ToString(result) + " " + operation;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Mod":
                    txtDisplay.Text = (result % Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double q;
                    q = (result);
                    txtDisplay.Text = Math.Exp(i*Math.Log(q*4)).ToString();
                    break;
            }
           
            
           
        }

        private void button32_Click(object sender, EventArgs e)
        {
            txtDisplay.Text =(Math.PI).ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("log" + "(" + Double.Parse(txtDisplay.Text) + ")");
            ilog = Math.Log10(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
            
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("log" + "(" + Double.Parse(txtDisplay.Text) + ")");
            sqrt = Math.Sqrt(sqrt);
            txtDisplay.Text = System.Convert.ToString(sqrt);

        }

        private void button29_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double qsinh = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("sinh" + "(" + Double.Parse(txtDisplay.Text) + ")");
            qsinh = Math.Sinh(qsinh);
            txtDisplay.Text = System.Convert.ToString(qsinh);

        }

        private void button27_Click(object sender, EventArgs e)
        {
            double qsin = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("sin" + "(" + Double.Parse(txtDisplay.Text) + ")");
            qsin = Math.Sin(qsin);
            txtDisplay.Text = System.Convert.ToString(qsin);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double qcosh = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("cosh" + "(" + Double.Parse(txtDisplay.Text) + ")");
            qcosh = Math.Cosh(qcosh);
            txtDisplay.Text = System.Convert.ToString(qcosh);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double qcos = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("cos" + "(" + Double.Parse(txtDisplay.Text) + ")");
            qcos = Math.Cos(qcos);
            txtDisplay.Text = System.Convert.ToString(qcos);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double qtanh = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("tanh" + "(" + Double.Parse(txtDisplay.Text) + ")");
            qtanh = Math.Tanh(qtanh);
            txtDisplay.Text = System.Convert.ToString(qtanh);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double qtan = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("tan" + "(" + Double.Parse(txtDisplay.Text) + ")");
            qtan = Math.Tan(qtan);
            txtDisplay.Text = System.Convert.ToString(qtan);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 2);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 16);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 8);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text)* Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double a;
            a =  Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double iln = Double.Parse(txtDisplay.Text);
            label1.Text = System.Convert.ToString("ln" + "(" + Double.Parse(txtDisplay.Text) + ")");
            iln = Math.Log(iln);
            txtDisplay.Text = System.Convert.ToString(iln);

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void FahToCel_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void rbKel_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {
            txtConvert.Clear();
            labelConvert.Text = "";
            rbCelToFah.Checked = false;
            rbFahToCel.Checked = false;
            rbKelvin.Checked = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txtMultiply.Text);
            for (int i=1;i<13;i++)
            {
                lbMultiply.Items.Add(i+"x"+a+"="+a*i);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                case 'C':
                    //Cel to Fah
                    iCelsius = float.Parse(txtConvert.Text);
                    labelConvert.Text = ((((iCelsius*9) / 5) +32).ToString());
                    break;
                case 'F':
                    //Fah to Cle
                    iFahrenheit = float.Parse(txtConvert.Text);
                    labelConvert.Text = ((((iFahrenheit - 32) * 5) / 9).ToString());
                    break;
                case 'K':
                    //Convert to Kelvin
                    iKelvin = float.Parse(txtConvert.Text);
                    labelConvert.Text = (((((iKelvin * 9) / 5) + 32)+273.15).ToString());
                    break;
            }
        }
    }
}
