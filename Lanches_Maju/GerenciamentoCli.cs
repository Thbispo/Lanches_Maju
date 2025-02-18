using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lanches_Maju
{
    public partial class GerenciamentoCli : Form
    {
        private readonly string connectionString = "Server=localhost; Port=3306; Database=bd_lanchesdamaju; Uid=root; Pwd=;";

        public GerenciamentoCli()
        {
            InitializeComponent();
        }

        

        private void button_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

                   

        private void button_pesquisarCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    consulta.Open();
                    string listagem = "SELECT ID_clientes, Nome, Senha, Email, Telefone  FROM tb_clientes";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dadosCliente = new DataTable();
                        dadosCliente.Load(reader);
                        dgvClientes.DataSource = dadosCliente;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os Clientes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_removerCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um cliente para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clientesID = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["ID_clientes"].Value);
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection consulta = new MySqlConnection(connectionString))
                    {
                        consulta.Open();
                        string query = "DELETE FROM tb_clientes WHERE ID_clientes = @ID_clientes";

                        using (MySqlCommand cmd = new MySqlCommand(query, consulta))
                        {
                            cmd.Parameters.AddWithValue("@ID_clientes", clientesID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              
                            }
                            else
                            {
                                MessageBox.Show("Falha ao excluir o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
       
}
