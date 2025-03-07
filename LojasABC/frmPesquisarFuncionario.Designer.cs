
namespace LojasABC
{
    partial class frmPesquisarFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarFuncionario));
            this.gpbPesquisarPor = new System.Windows.Forms.GroupBox();
            this.rbtCodigo = new System.Windows.Forms.RadioButton();
            this.rbtNome = new System.Windows.Forms.RadioButton();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.ltbPesquisar = new System.Windows.Forms.ListBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbPesquisarPor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisarPor
            // 
            this.gpbPesquisarPor.Controls.Add(this.txbDescricao);
            this.gpbPesquisarPor.Controls.Add(this.lblDescricao);
            this.gpbPesquisarPor.Controls.Add(this.rbtNome);
            this.gpbPesquisarPor.Controls.Add(this.rbtCodigo);
            this.gpbPesquisarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarPor.Location = new System.Drawing.Point(12, 12);
            this.gpbPesquisarPor.Name = "gpbPesquisarPor";
            this.gpbPesquisarPor.Size = new System.Drawing.Size(572, 126);
            this.gpbPesquisarPor.TabIndex = 0;
            this.gpbPesquisarPor.TabStop = false;
            this.gpbPesquisarPor.Text = "Pesquisa por";
            // 
            // rbtCodigo
            // 
            this.rbtCodigo.AutoSize = true;
            this.rbtCodigo.Location = new System.Drawing.Point(119, 35);
            this.rbtCodigo.Name = "rbtCodigo";
            this.rbtCodigo.Size = new System.Drawing.Size(77, 24);
            this.rbtCodigo.TabIndex = 1;
            this.rbtCodigo.TabStop = true;
            this.rbtCodigo.Text = "Código";
            this.rbtCodigo.UseVisualStyleBackColor = true;
            // 
            // rbtNome
            // 
            this.rbtNome.AutoSize = true;
            this.rbtNome.Location = new System.Drawing.Point(202, 35);
            this.rbtNome.Name = "rbtNome";
            this.rbtNome.Size = new System.Drawing.Size(69, 24);
            this.rbtNome.TabIndex = 2;
            this.rbtNome.TabStop = true;
            this.rbtNome.Text = "Nome";
            this.rbtNome.UseVisualStyleBackColor = true;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(19, 68);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(105, 65);
            this.txbDescricao.MaxLength = 100;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(347, 26);
            this.txbDescricao.TabIndex = 3;
            // 
            // ltbPesquisar
            // 
            this.ltbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPesquisar.FormattingEnabled = true;
            this.ltbPesquisar.ItemHeight = 20;
            this.ltbPesquisar.Location = new System.Drawing.Point(12, 154);
            this.ltbPesquisar.Name = "ltbPesquisar";
            this.ltbPesquisar.Size = new System.Drawing.Size(572, 124);
            this.ltbPesquisar.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(594, 23);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(181, 115);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(594, 154);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(181, 124);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // frmPesquisarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.ltbPesquisar);
            this.Controls.Add(this.gpbPesquisarPor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmPesquisarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LojaABC - Pesquisar funcionario";
            this.Load += new System.EventHandler(this.frmPesquisarFuncionario_Load);
            this.gpbPesquisarPor.ResumeLayout(false);
            this.gpbPesquisarPor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisarPor;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RadioButton rbtNome;
        private System.Windows.Forms.RadioButton rbtCodigo;
        private System.Windows.Forms.ListBox ltbPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
    }
}