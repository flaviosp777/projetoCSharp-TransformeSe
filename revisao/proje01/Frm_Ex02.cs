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
    public partial class Frm_Ex02 : Form
    {
        public Frm_Ex02()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(Txt_Valor1.Text);
            double valor2 = Convert.ToDouble(Txt_Valor2.Text);
            double resultado = valor1 + valor2;

            Lbl_Resultadosoma.Text = resultado.ToString();
        }

        private void Lbl_Resultadosoma_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(Txt_Valor1.Text);
            double valor2 = Convert.ToDouble(Txt_Valor2.Text);
            double resultado = valor1 / valor2;

            Lbl_Resultadosoma.Text = resultado.ToString();
        }

        private void Btn_Multiplicar_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(Txt_Valor1.Text);
            double valor2 = Convert.ToDouble(Txt_Valor2.Text);
            double resultado = valor1 * valor2;

            Lbl_Resultadosoma.Text = resultado.ToString();
        }

        private void Btn_Subtrair_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(Txt_Valor1.Text);
            double valor2 = Convert.ToDouble(Txt_Valor2.Text);
            double resultado = valor1 - valor2;

            Lbl_Resultadosoma.Text = resultado.ToString();
        }

        private void Btn_Voltar_Click_1(object sender, EventArgs e)
        {
            Form1 frm_Ex01 = new Form1();
            frm_Ex01.Show();
            this.Hide();
        }
    }
}
