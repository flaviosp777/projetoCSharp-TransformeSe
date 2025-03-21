using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }

        private void txbNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (txbNome.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores válidos");
            }
           if (e.KeyCode == Keys.Enter)
            {
                cmbListarnome.Items.Add(txbNome.Text);
                txbNome.Clear();
                txbNome.Focus();
            }

        }

        private void ckbLivros_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLivros.Checked)
            {
                ltblistarProdutos.Items.Add("Livros");
            }
            else
            {
                ltblistarProdutos.Items.RemoveAt(0);
            }
        }

        private void ckbComputador_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbComputador.Checked)
            {
                ltblistarProdutos.Items.Add("Computador");
            }
            else
            {
                ltblistarProdutos.Items.RemoveAt(0);
            }
        }

        private void ckbMesa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMesa.Checked)
            {
                ltblistarProdutos.Items.Add("Mesa");
            }
            else
            {
                ltblistarProdutos.Items.RemoveAt(0);
            }
        }

        private void ckbBanana_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBanana.Checked)
            {
                ltblistarProdutos.Items.Add("Banana");
            }
            else
            {
                ltblistarProdutos.Items.RemoveAt(0);
            }
        }
    }
}
