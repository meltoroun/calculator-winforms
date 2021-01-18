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
        public string d;
        public string n1;
        public bool n2; 
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            d = b.Text;
            n1 = textBox1.Text;
            n2 = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double dn1, dn2;
            double res = 0;
            dn1 = Convert.ToDouble(n1);
            dn2 = Convert.ToDouble(textBox1.Text);

                if (d == "+")                    
                    res = dn1 + dn2;
                if (d == "-")
                    res = dn1 - dn2;
                if (d == "*")
                    res = dn1 * dn2;
                if (d == "/")
                    res = dn1 / dn2;
                
            
            
            n2 = true;
            textBox1.Text = res.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn, 2);
            textBox1.Text = res.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = 1/dn;
            textBox1.Text = res.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains("."))
                textBox1.Text = textBox1.Text + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button b = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = b.Text;
            else textBox1.Text = textBox1.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
