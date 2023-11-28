using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace quiz_p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conexaoString = 
            "server=localhost;user=root;password=;database=db_quiz_p;";

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string pergunta = "";
            string alternativaA = "", alternativaB = "", 
                alternativaC = "", alternativaD = "";
            long ultimoID = 0;


            pergunta = rtxPergunta.Text;

            alternativaA = txbAlternativaA.Text;
            alternativaB = txbAlternativaB.Text;
            alternativaC = txbAlternativaC.Text;
            alternativaD = txbAlternativaD.Text;


            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();
                string scriptInsert = "INSERT INTO tb_perguntas (questao) VALUE (@questao)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsert, conexao))
                {
                    //substitui os parametros para os valores reais
                    comando.Parameters.AddWithValue("@questao", pergunta
                        );
               

                    comando.ExecuteNonQuery();

                    ultimoID = comando.LastInsertedId;
                
                }

            }

            MessageBox.Show("Pergunta Cadastrada com Sucesso!!! " + ultimoID.ToString());


        
        }
    }
}
