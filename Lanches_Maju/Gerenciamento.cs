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
    public partial class Gerenciamento : Form
    {
        public Gerenciamento()
        {
            InitializeComponent();
        }

        private void buttonCadCliente_Click(object sender, EventArgs e)
        {
            CadCliente form = new CadCliente();
            form.ShowDialog();

        }

        private void buttonCadProdutos_Click(object sender, EventArgs e)
        {
            CadProdutos form = new CadProdutos();
            form.ShowDialog();
        }

        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            Ed
        }
    }
}
