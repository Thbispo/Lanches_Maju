using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanches_Maju
{
    public partial class CadProdutos : Form
    {
        public CadProdutos()
        {
            InitializeComponent();
        }

        
        

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            maskedTextBoxValor.Text = "";
            richTextBoxDescricao.Text = "";
            comboBoxCategoria.Text = "";
            textBoxNome.Focus();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadastrarPro_Click(object sender, EventArgs e)
        {
            string conexaoString = "Server=localhost; Port=3306; Database=bd_lanchesdamaju; Uid=root; Pwd=;";

            //Defina a inserção de registro no BD

            string query = "INSERT INTO tb_produtos (Nome,Valor,Descricao,Categoria) VALUES (@Nome,@Valor,@Descricao,@Categoria)";

            //Crie uma conexão com o BD

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    //Abre a conexão
                    conexao.Open();
                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        //Adicionar os parâmentros com os valores dos TextBox
                        comando.Parameters.AddWithValue("@Nome", textBoxNome.Text);
                        comando.Parameters.AddWithValue("@Valor", maskedTextBoxValor.Text);
                        comando.Parameters.AddWithValue("@Descricao", richTextBoxDescricao.Text);
                        comando.Parameters.AddWithValue("@Categoria", comboBoxCategoria.Text);
                        

                        // Executa o comando de inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");
                        
                    }
                }
                catch (Exception ex)
                {
                    // em caso de erro, exiba menssagem do erro
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
    }
    
}
