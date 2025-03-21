﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LojasABC
{
    public partial class frmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmFuncionarios()
        {
            InitializeComponent();
            //desabilitando os campos
            desabilitarCampos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //executando habilitar campos
            habilitarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || 
                txtEmail.Text.Equals("") ||
                mskCPF.Text.Equals("   .   .   -") ||
                mskTelefone.Text.Equals("     -") ||
                txbLogradouro.Text.Equals("") || 
                txtNumero.Text.Equals("") || 
                txbComplemento.Text.Equals("") || 
                txbCidade.Text.Equals("") || 
                cbbEstado.Text.Equals("") || 
                mskCEP.Text.Equals("") || 
                cbbUF.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher os campos!!!");
            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso!!!");
                LimpararCampos();
                desabilitarCampos();
                btnNovo.Enabled = true;
                btnNovo.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //executando limpar dados
            LimpararCampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                frmPesquisarFuncionario abrir = new frmPesquisarFuncionario();
                abrir.ShowDialog();
                this.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        //desabilitando os componentes
        public void desabilitarCampos()
        {
            txtCódigo.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mskCPF.Enabled = false;
            dtpDatadeNascimento.Enabled = false;
            mskTelefone.Enabled = false;
            gpbSexo.Enabled = false;

            txbLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            mskCEP.Enabled = false;
            txbCidade.Enabled = false;
            cbbEstado.Enabled = false;
            cbbUF.Enabled = false;
            txbComplemento.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        //Habilitar os campos
        public void habilitarCampos()
        {
            txtCódigo.Enabled = true;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskCPF.Enabled = true;
            dtpDatadeNascimento.Enabled = true;
            mskTelefone.Enabled = true;
            gpbSexo.Enabled = true;

            txbLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            mskCEP.Enabled = true;
            txbCidade.Enabled = true;
            cbbEstado.Enabled = true;
            cbbUF.Enabled = true;
            txbComplemento.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;

            btnNovo.Enabled = false;

            txtNome.Focus();
        }

        //Limpar os Campos 
        public void LimpararCampos()
        {
            txtCódigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            mskCPF.Clear();
            dtpDatadeNascimento.Text = "";
            mskTelefone.Clear();
            
            rbtFeminino.Checked = false;
            rbtMasculino.Checked = false;
            rbtNaoDesejoInformar.Checked = false;

            txbLogradouro.Clear();
            txtNumero.Clear();
            mskCEP.Clear();
            txbCidade.Clear();
            txbCidade.Clear();
            cbbUF.Text = "";
            txbComplemento.Clear();

            txtNome.Focus();
        }

    }
}
