using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        int number = 1;
        int i = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            b7.Visible = true;
            randomaizer();
        }

        private void randomaizer()
        {
            int[] a = new int[16]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            int value = rnd.Next(number, 17);
            this.b1.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b2.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b3.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b4.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b5.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b6.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b7.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b8.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b9.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b10.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b11.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b12.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b13.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b14.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b15.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
             while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b16.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
        }

        private void randomaizer2()
        {
            int[] a = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            int value = rnd.Next(number, 17);
            if(b1.Visible == true)
            {
                this.b1.Text = Convert.ToString(a[value - 1]);
                a[value - 1] = 0;
            }
            
            if (b2.Visible == true)
            {
                while (a[value - 1] == 0)
                {
                    value = rnd.Next(number, 17);
                }
                this.b2.Text = Convert.ToString(a[value - 1]);
                a[value - 1] = 0;
            }
            if (b3.Visible == true)
            {
                while (a[value - 1] == 0)
                {
                    value = rnd.Next(number, 17);
                }
                this.b3.Text = Convert.ToString(a[value - 1]);
                a[value - 1] = 0;
            }
            if (b4.Visible == true)
            {

                while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b4.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            }
            if (b5.Visible == true)
            {
            while (a[value - 1] == 0)
            {
                value = rnd.Next(number, 17);
            }
            this.b5.Text = Convert.ToString(a[value - 1]);
            a[value - 1] = 0;
            }
                
            if (b6.Visible == true)
            {
                while (a[value - 1] == 0)
                {
                    value = rnd.Next(number, 17);
                }
                this.b6.Text = Convert.ToString(a[value - 1]);
                a[value - 1] = 0;
            }
               
            if (b7.Visible == true)
            {
                while (a[value - 1] == 0)
                {
                    value = rnd.Next(number, 17);
                }
                this.b7.Text = Convert.ToString(a[value - 1]);
                a[value - 1] = 0;
            }
                
            if (b8.Visible == true)
            {
                while (a[value - 1] == 0)
                {
                    value = rnd.Next(number, 17);
                }
                this.b8.Text = Convert.ToString(a[value - 1]);
                a[value - 1] = 0;
            }
            if (b9.Visible == true)
            {
                while (a[value - 1] == 0)
                {
                    value = rnd.Next(number, 17);
                }
                this.b9.Text = Convert.ToString(a[value - 1]);
                a[value - 1] = 0;
            }
                
            if (b10.Visible == true)
            {
                while (a[value - 1] == 0)
                {
                    value = rnd.Next(number, 17);
                }
                this.b10.Text = Convert.ToString(a[value - 1]);
                a[value - 1] = 0;
            }
                
            if (b11.Visible == true)
            {
                while (a[value - 1] == 0)
                {
                    value = rnd.Next(number, 17);
                }
                this.b11.Text = Convert.ToString(a[value - 1]);
                a[value - 1] = 0;
            }
               
            if (b12.Visible == true)
            {
                while (a[value - 1] == 0)
                {
                    value = rnd.Next(number, 17);
                }
                this.b12.Text = Convert.ToString(a[value - 1]);
                a[value - 1] = 0;
            }
                
            if (b13.Visible == true)
            {
                while (a[value - 1] == 0)
                {
                    value = rnd.Next(number, 17);
                }
                this.b13.Text = Convert.ToString(a[value - 1]);
                a[value - 1] = 0;
            }
                
            if (b14.Visible == true)
            {
                while (a[value - 1] == 0)
                {
                    value = rnd.Next(number, 17);
                }
                this.b14.Text = Convert.ToString(a[value - 1]);
                a[value - 1] = 0;
            }
                
            if (b15.Visible == true)
            {
                while (a[value - 1] == 0)
                {
                    value = rnd.Next(number, 17);
                }
                this.b15.Text = Convert.ToString(a[value - 1]);
                a[value - 1] = 0;
            }
               
            if (b16.Visible == true)
            {
                while (a[value - 1] == 0)
                {
                    value = rnd.Next(number, 17);
                }
                this.b16.Text = Convert.ToString(a[value - 1]);
                a[value - 1] = 0;
            }
               
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                i++;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i != 0)
            {
                comboBox1.Items.RemoveAt(i - 1);
                i--;
            }
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void b1_Click(object sender, EventArgs e)
        {
            if (number == Convert.ToInt32((sender as Button).Text))
            {
                (sender as Button).Visible = false;
                number++;
                randomaizer2();
                this.textBox2.Text = "";
                textBox2_TextChanged(sender, e);
            }
            else
            {
                b1.Visible = true;
                b2.Visible = true;
                b3.Visible = true;
                b4.Visible = true;
                b5.Visible = true;
                b6.Visible = true;
                b7.Visible = true;
                b8.Visible = true;
                b9.Visible = true;
                b10.Visible = true;
                b11.Visible = true;
                b12.Visible = true;
                b13.Visible = true;
                b14.Visible = true;
                b15.Visible = true;
                b16.Visible = true;
                number = 1;
                randomaizer();
                
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(number == 17)
            {
                this.textBox2.Text = "Молодець!!!";
                b1.Visible = true;
                b2.Visible = true;
                b3.Visible = true;
                b4.Visible = true;
                b5.Visible = true;
                b6.Visible = true;
                b7.Visible = true;
                b8.Visible = true;
                b9.Visible = true;
                b10.Visible = true;
                b11.Visible = true;
                b12.Visible = true;
                b13.Visible = true;
                b14.Visible = true;
                b15.Visible = true;
                b16.Visible = true;
                number = 1;
                randomaizer();
            }
        }

 
    }
}
