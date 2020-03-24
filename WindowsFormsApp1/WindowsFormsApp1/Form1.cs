using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool isDot = false;
        double leftOperand;
        double rightOperand;
        Operand operand;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {

            }
            else
            {
                rightOperand = double.Parse(this.textBox1.Text);
                this.textBox1.Text = (rightOperand * (-1)).ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "3";
            }
            else
            {
                this.textBox1.Text += "3";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            operand = Operand.Plus;
            if (this.textBox1.Text == "")
            {
                this.textBox1.Text = "";
            }
            else
            {
                leftOperand = double.Parse(this.textBox1.Text);
                this.textBox1.Text = "";
            }
            isDot = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operand = Operand.Multiply;
            if (this.textBox1.Text == "")
            {
                this.textBox1.Text = "";
            }
            else
            {
                leftOperand = double.Parse(this.textBox1.Text);
                this.textBox1.Text = "";
            }
            isDot = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {          
            if (this.textBox1.Text != "0")
            {
                this.textBox1.Text += "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "8";
            }
            else
            {
                this.textBox1.Text += "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "9";
            }
            else
            {
                this.textBox1.Text += "9";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "1";
            }
            else
            {
                this.textBox1.Text += "1";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "2";
            }
            else
            {
                this.textBox1.Text += "2";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "4";
            }
            else
            {
                this.textBox1.Text += "4";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "5";
            }
            else
            {
                this.textBox1.Text += "5";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "6";
            }
            else
            {
                this.textBox1.Text += "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "7";
            }
            else
            {
                this.textBox1.Text += "7";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!isDot)
            {
                this.textBox1.Text += ",";
                isDot = true;
            }           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operand = Operand.Devide;
            if (this.textBox1.Text == "")
            {
                this.textBox1.Text = "";
            }
            else
            {
                leftOperand = double.Parse(this.textBox1.Text);
                this.textBox1.Text = "";
            }
            isDot = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operand = Operand.Minus;
            if (this.textBox1.Text == "")
            {
                this.textBox1.Text = "";
            }
            else
            {
                leftOperand = double.Parse(this.textBox1.Text);
                this.textBox1.Text = "";
            }
            isDot = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.textBox1.Text = "";
            }
            else
            {
                rightOperand = double.Parse(this.textBox1.Text);
                switch (operand)
                {
                    case Operand.Plus:
                        this.textBox1.Text = Math.Round((leftOperand + rightOperand), 5).ToString();
                        break;
                    case Operand.Minus:
                        this.textBox1.Text = Math.Round((leftOperand - rightOperand),5).ToString();
                        break;
                    case Operand.Multiply:
                        this.textBox1.Text = Math.Round((leftOperand * rightOperand), 5).ToString();
                        break;
                    case Operand.Devide:
                        this.textBox1.Text = Math.Round((leftOperand / rightOperand), 5).ToString();
                        break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "0";
            rightOperand = 0;
            leftOperand = 0;
            isDot = false;
        }

        enum Operand
        {
            Plus,
            Minus,
            Multiply,
            Devide
        }           
    }
}
