using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            string numero1;
            string numero2;
            string numero3;

            numero1 = textBox1.Text;
            numero2 = textBox2.Text;
            numero3 = textBox3.Text;

            textBox1.Text = numero3;
            textBox2.Text = numero1;
            textBox3.Text = numero2;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int numero3 = int.Parse(textBox3.Text);

            //verificando o MAIOR NUMERO
            if (numero1 > numero2 && numero1 > numero3)
            {
                textBox1.Text = numero1.ToString();
            } else if (numero2 > numero1 && numero2 > numero3)
            {
                textBox1.Text = numero2.ToString();
            } else if (numero3 > numero1 && numero3 > numero2)
            {
                textBox1.Text = numero3.ToString();
            }

            //verificando o numero do MEIO
            if((numero1 > numero3 && numero1 < numero2) || (numero1 > numero2 && numero1 < numero3))
            {
                textBox2.Text = numero1.ToString();

            } else if ((numero2 > numero1 && numero2 < numero3) || (numero2 < numero1 && numero2 > numero3))
            {
                textBox2.Text = numero2.ToString();

            } else if ((numero3 > numero1 && numero3 < numero2) || (numero3 < numero1 && numero3 > numero2))
            {
                textBox2.Text = numero3.ToString() ;
            }

            //verificando o MENOR NUMERO
            if (numero1 < numero2 && numero1 < numero3)
            {
                textBox3.Text = numero1.ToString();
            }
            else if (numero2 < numero1 && numero2 < numero3)
            {
                textBox3.Text = numero2.ToString();
            }
            else if (numero3 < numero1 && numero3 < numero2)
            {
                textBox3.Text = numero3.ToString();
            }



        }
    }
}
