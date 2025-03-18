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
    public partial class Frm_Calc3 : Form
    {
        public Frm_Calc3()
        {
            InitializeComponent();
        }

        private void Frm_Calc3_Load(object sender, EventArgs e)
        {

        }

        private void LimparTextBox()
        {
            TextBoxNro1.Clear();
            TextBoxNro2.Clear();
        }
        
        private static double Somar(double val1, double val2)
        {
            return val1 + val2;
        }

        private static double Subtrair(double val1, double val2)
        {
            return val1 - val2;
        }

        private static double Multiplicar(double val1, double val2)
        {
            return val1 * val2;
        }

        private static double Dividir(double val1, double val2)
        {
            return val1 / val2;
        }

        private bool ValidarForm()
        {
            if (string.IsNullOrWhiteSpace(TextBoxNro1.Text))
            {
                LabelErro.Text = "O valor 1 é obrigatório";
                TextBoxNro1.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(TextBoxNro2.Text))
            {
                LabelErro.Text = "O valor 2 é obrigatório";
                TextBoxNro1.Focus();
                return false;
            }
            try
            {
                double doubleValor1 = Convert.ToDouble(TextBoxNro1.Text);
                double doubleValor2 = Convert.ToDouble(TextBoxNro2.Text);
                return true;
            }
            catch
            {
                LabelErro.Text = "Insira somente números";
                LimparTextBox();
                TextBoxNro1.Focus();
                return false;

            }

        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Clear();
            LabelErro.Text = "";

            if (!ValidarForm())
            {
                return;
            }
            double doubleValor1 = Convert.ToDouble(TextBoxNro1.Text);
            double doubleValor2 = Convert.ToDouble(TextBoxNro2.Text);
            double resultado;

            switch (LabelOperacao.Text)
            {
                case "+":
                    resultado = Somar(doubleValor1, doubleValor2);
                    break;
                case "-":
                    resultado = Subtrair(doubleValor1, doubleValor2);
                    break;
                case "*":
                    resultado = Multiplicar(doubleValor1, doubleValor2);
                    break;
                case "/":
                    resultado = Dividir(doubleValor1, doubleValor2);
                    break;
                default:
                    resultado = Somar(doubleValor1, doubleValor2);
                    break;
            }
            TextBoxResultado.Text = Convert.ToString(resultado);
            LimparTextBox();
        }

        private void RadioButtonSoma_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxNro1.Visible = true;
            LabelOperacao.Text = "+";
        }

        private void RadioButtonSubtracao_CheckedChanged(object sender, EventArgs e)
        {
            LabelOperacao.Text = "-";
        }

        private void RadioButtonDivisao_CheckedChanged(object sender, EventArgs e)
        {
            LabelOperacao.Text = "/";
        }

        private void RadioButtonMultiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            LabelOperacao.Text = "*";
        }
    }
}
