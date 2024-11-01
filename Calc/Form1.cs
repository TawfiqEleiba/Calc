using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }
        string c;
        double x;
        private void button10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text =="0")
                textBox1.Clear();

            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            c=b.Text;
            x=Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + " " +c;
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            switch(c)
            {
                case "+":
                    {
                        double y= Convert.ToDouble(textBox1.Text);
                        textBox1.Text=(x+y).ToString();

                    }
                    break;
                case "-":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x - y).ToString();

                    }
                    break;
                case "/":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x / y).ToString();

                    }
                    break;
                case "*":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x * y).ToString();

                    }
                    break;
            }
           
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
    }

