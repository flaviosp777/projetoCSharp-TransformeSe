using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Mudar_Click(object sender, EventArgs e)
        {
            Lbl_Texto.Text = "Mudei";
            Lbl_Texto.ForeColor = Color.Red;
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Lbl_Texto.Text = "Texto";
            Lbl_Texto.ForeColor = Color.Black;
        }

        private void Txt_Mudartexto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_apoio_Click(object sender, EventArgs e)
        {
            Lbl_Texto.Text = Txt_Mudartexto.Text;
            Txt_Mudartexto.Clear();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_proximo_Click(object sender, EventArgs e)
        {
            Frm_Ex02 frm_Ex02 = new Frm_Ex02();
            frm_Ex02.Show();
            this.Hide();
        }
    }
}
