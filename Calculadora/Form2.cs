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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(conversiones));
        }

        double resultado=0, temperatura=0;
        int idConversor=0;

        enum conversiones
        {
            Celsius_Fahrenheit,
            Celsius_Kelvin,
            Fahrenheit_Celsius,
            Fahrenheit_Kelvin,
            Kelvin_Celsius,
            Kelvin_Fahrenheit
        };

      
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                temperatura = double.Parse(textBox1.Text);
                idConversor = Convert.ToInt32(comboBox1.SelectedIndex);

                switch (idConversor)
                {
                    case 0:
                        resultado = (temperatura * 9.0 / 5.0) + 32 ;
                        break;
                    case 1:
                        resultado = temperatura + 273;
                        break;
                    case 2:
                        resultado = (temperatura - 32) * (5.0 / 9.0);
                        break;
                    case 3:
                        resultado = (temperatura + 459.67) * 5.0 / 9.0;
                        break;
                    case 4:
                        resultado = temperatura - 273;
                        break;
                    case 5:
                        resultado = (9.0 / 5.0 * temperatura) - 459.67;
                        break;
                }
                label4.Visible = false;

                textBox2.Text = resultado.ToString();
            }
            else
                label4.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
