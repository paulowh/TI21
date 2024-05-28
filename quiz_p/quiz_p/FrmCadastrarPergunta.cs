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
    public partial class frmCadastrarPergunta : Form
    {
        public frmCadastrarPergunta()
        {
            InitializeComponent();
        }

        string conexaoString =
            "server=localhost;user=root;password=;database=db_quiz_p;";
        public long CadastrarAlternativas(string alternativa, long perguntaID)
        {
            long idAlternativa = 0;
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();

                string insert_tb_alternativa = "INSERT INTO tb_alternativa (respostas, id_pergunta) VALUE (@respostas, @id_pergunta)";

                using (MySqlCommand comando = new MySqlCommand(insert_tb_alternativa, conexao))
                {
                    comando.Parameters.AddWithValue("@respostas", alternativa);
                    comando.Parameters.AddWithValue("@id_pergunta", perguntaID);

                    comando.ExecuteNonQuery();
                    idAlternativa = comando.LastInsertedId;
                }
            }

            return idAlternativa;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string pergunta = "";
            string alternativaA = "", alternativaB = "",
                alternativaC = "", alternativaD = "";
            long ultimoID = 0;
            long idAlternativaA = 0, idAlternativaB = 0, idAlternativaC = 0, idAlternativaD = 0;

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
                    comando.Parameters.AddWithValue("@questao", pergunta);

                    comando.ExecuteNonQuery();

                    ultimoID = comando.LastInsertedId;
                }
            }

            idAlternativaA = CadastrarAlternativas(alternativaA, ultimoID);
            idAlternativaB = CadastrarAlternativas(alternativaB, ultimoID);
            idAlternativaC = CadastrarAlternativas(alternativaC, ultimoID);
            idAlternativaD = CadastrarAlternativas(alternativaD, ultimoID);

            if (rbAlternativaCorretaA.Checked)
            {
                CadastrarResposta(ultimoID, idAlternativaA);
            }
            else if (rbAlternativaCorretaB.Checked)
            {
                CadastrarResposta(ultimoID, idAlternativaB);
            }
            else if (rbAlternativaCorretaC.Checked)
            {
                CadastrarResposta(ultimoID, idAlternativaC);
            }
            else if (rbAlternativaCorretaD.Checked)
            {
                CadastrarResposta(ultimoID, idAlternativaD);
            }

            MessageBox.Show("Pergunta Cadastrada com Sucesso!!! " + ultimoID.ToString());
        }

        public void CadastrarResposta(long idPergunta, long idAlternativa)
        {
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();
                string scriptInsertResposta = "INSERT INTO tb_resposta (id_altenativa, id_pergunta) VALUE (@id_alternativa, @id_pergunta)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsertResposta, conexao))
                {
                    comando.Parameters.AddWithValue("@id_pergunta", idPergunta);
                    comando.Parameters.AddWithValue("@id_alternativa", idAlternativa);

                    comando.ExecuteNonQuery();
                }
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Form consultarPergunta = new FrmConsultarPergunta();

            consultarPergunta.Show();

        }
    }
}
