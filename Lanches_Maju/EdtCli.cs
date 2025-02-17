using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sitema2
{
    public partial class Gerenciamento_Clientes : Form
    {
        public Gerenciamento_Clientes()
        {
            InitializeComponent();
        }

        private void button_pesquisarCliente_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";
            try
            {
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    consulta.Open();

                    string listagem = "SELECT ID_clientes, Nome, Cpf, Telefone FROM tb_clientes";
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        MySqlDataReader reader = cmd.ExecuteReader();

                        DataTable dadosCliente = new DataTable();
                        dadosCliente.Load(reader);

                        dgvClientes.DataSource = dadosCliente;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os Clientes" + ex.Message);
            }
        }

        private void button_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_removerCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {

                int clientesID = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["ID_Clientes"].Value);
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

                    try
                    {
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {

                            consulta.Open();

                            string listagem = "DELETE FROM tb_clientes WHERE ID_clientes = @ID_Clientes";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("ID_Clientes", clientesID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluído com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o cliente.");
                                }
                            }
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma cliente poara excluir");
                }
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
