using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void escolhaOperador(int numero, string operadorEscolhido)
        {

            lbTemp.Text = numero.ToString();
            lbOperador.Text = operadorEscolhido;
            txbNumero1.Text = "";

        }

        public int calculos(int num1, int num2, string operador)
        {
            int resultado = 0;

            if (operador == "+")
            {
                resultado = num1 + num2;
            }
            else if (operador == "-")
            {
                resultado = num1 - num2;
            }
            else if (operador == "x")
            {
                resultado = num1 * num2;
            }
            else if (operador == "/")
            {
                resultado = num1 / num2;
            }
            else if (operador == "resto")
            {
                resultado = num1 % num2;
            }

            return resultado;
        }

        private void btnOperadores_Click(object sender, EventArgs e)
        {

            if (txbNumero1.Text != "" && txbNumero1.Text != "Error" )
            {

                int numero1 = int.Parse(txbNumero1.Text);

                //int numero2 = int.Parse( txbNumero2.Text );
                int numero2 = 0;
                int total;

                Button botao = (Button)sender;
                string operadorSelecionado = botao.Text;

                //total = resultadoSoma(numero1, numero2);

                //total = calculos(numero1, numero2, operadorSelecionado);
                //lbResultado.Text = total.ToString();

                escolhaOperador(numero1, operadorSelecionado);

            } else
            {
                txbNumero1.Text = "Error";
            }
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button valorBotao = (Button)sender;

            //MessageBox.Show(valorBotao.Text);
            //txbNumero1.Text = txbNumero1.Text + valorBotao.Text;

            txbNumero1.Text += valorBotao.Text;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNumero1.Text = "";
        }

        private void btnIgual_Click (object sender, EventArgs e)
        {

            int primeiro_numero = int.Parse(lbTemp.Text);
            int segundo_numero = int.Parse(txbNumero1.Text);
            string operador = lbOperador.Text;

            int total = calculos(primeiro_numero, segundo_numero, operador);

            lbResultado.Text = total.ToString();

            //MessageBox.Show( primeiro_numero + " | " + segundo_numero + " | " + operador  );
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txbNumero1.Text);
            int numeroConvertido = numero * -1;

            txbNumero1.Text = numeroConvertido.ToString();
        }

        private void btnLimpaTudo_Click(object sender, EventArgs e)
        {
            txbNumero1.Text = "";
            lbResultado.Text = "R";
            lbTemp.Text = "temp";
            lbOperador.Text = "op";

        }
    }
}
