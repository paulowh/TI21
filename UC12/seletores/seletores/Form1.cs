using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seletores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //decimal texto = numericUpDown1.Value;
            //MessageBox.Show(texto.ToString());

            double numero =  double.Parse(textBox1.Text);
            bool temDescricao = checkBox1.Checked; //tabela verdade (verdadeiro ou falso)
            string descricao = "", mensagem = "";
            bool comAlerta = checkBox2.Checked;

            if ( radioButton1.Checked )
            {
                double fahrenheit = 0;
                fahrenheit = (numero * 1.8) + 32;

                if (temDescricao)
                {
                    descricao = " fahrenheit";
                }

                mensagem = fahrenheit.ToString() + descricao;

                if (comAlerta)
                {
                    MessageBox.Show(mensagem);
                } else
                {
                    label1.Text = mensagem;
                }
                
            }
            if (radioButton2.Checked)
            {
                double kelvin = 0;
                kelvin = numero + 273;

                if (temDescricao)
                {
                    descricao = " kelvin";
                }

                mensagem = kelvin.ToString() + descricao;

                if (comAlerta)
                {
                    MessageBox.Show(mensagem);
                }
                else
                {
                    label1.Text = mensagem;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string continente = "";

            continente = comboBox1.SelectedItem.ToString();

            MessageBox.Show(continente);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(checkedListBox1.CheckedItems.ToString());

            int contador = 0;

            foreach (string elemento in checkedListBox1.CheckedItems)
            {
                MessageBox.Show(elemento);

                contador++;
            }

            MessageBox.Show("ao total foi selecionado " + contador.ToString() + " checkbox");

        }

        private void menu4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("oieeeee");
        }
    }
}
