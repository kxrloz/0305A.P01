using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double resultado=0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                resultado = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                textBox3.Text = resultado.ToString();
                label4.Visible = false;
            }
            else
                label4.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                resultado = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
                textBox3.Text = resultado.ToString();
                label4.Visible = false;
            }
            else
                label4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                resultado = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
                textBox3.Text = resultado.ToString();
                label4.Visible = false;
            }
            else
                label4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                resultado = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                textBox3.Text = resultado.ToString();
                label4.Visible = false;
            }
            else
                label4.Visible = true;
        }

       

     

       

        
        }
    }

