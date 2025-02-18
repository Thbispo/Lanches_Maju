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

namespace Lanches_Maju
{
    public partial class GerenciamentoPro : Form
    {
        private readonly string connectionString = "Server=localhost; Port=3306; Database=bd_lanchesdamaju; Uid=root; Pwd=;";

        public GerenciamentoPro()
        {
            InitializeComponent();
        }

        private void button_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_pesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    consulta.Open();
                    string listagem = "SELECT ID_produtos, Nome, Valor, Descricao, Categoria  FROM tb_produtos";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dadosProdutos = new DataTable();
                        dadosProdutos.Load(reader);
                        dgvProdutos.DataSource = dadosProdutos;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os Produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_removerCliente_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um produto para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int produtosID = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["ID_produtos"].Value);
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection consulta = new MySqlConnection(connectionString))
                    {
                        consulta.Open();
                        string query = "DELETE FROM tb_produtos WHERE ID_produtos = @ID_produtos";

                        using (MySqlCommand cmd = new MySqlCommand(query, consulta))
                        {
                            cmd.Parameters.AddWithValue("@ID_produtos", produtosID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("Falha ao excluir o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }  
}
