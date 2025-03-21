namespace Componentes
{
    partial class frmComponentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentes));
            this.gpbComponentes = new System.Windows.Forms.GroupBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.ltblistarProdutos = new System.Windows.Forms.ListBox();
            this.LblListarProdutos = new System.Windows.Forms.Label();
            this.cmbListarnome = new System.Windows.Forms.ComboBox();
            this.LbllistarNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.ckbLivros = new System.Windows.Forms.CheckBox();
            this.ckbComputador = new System.Windows.Forms.CheckBox();
            this.ckbMesa = new System.Windows.Forms.CheckBox();
            this.ckbBanana = new System.Windows.Forms.CheckBox();
            this.pcbImagens = new System.Windows.Forms.PictureBox();
            this.gpbComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbComponentes
            // 
            this.gpbComponentes.Controls.Add(this.pcbImagens);
            this.gpbComponentes.Controls.Add(this.ckbBanana);
            this.gpbComponentes.Controls.Add(this.ckbMesa);
            this.gpbComponentes.Controls.Add(this.ckbComputador);
            this.gpbComponentes.Controls.Add(this.ckbLivros);
            this.gpbComponentes.Controls.Add(this.lblEscolha);
            this.gpbComponentes.Controls.Add(this.txbNome);
            this.gpbComponentes.Controls.Add(this.LbllistarNome);
            this.gpbComponentes.Controls.Add(this.cmbListarnome);
            this.gpbComponentes.Controls.Add(this.LblListarProdutos);
            this.gpbComponentes.Controls.Add(this.ltblistarProdutos);
            this.gpbComponentes.Controls.Add(this.LblNome);
            this.gpbComponentes.Location = new System.Drawing.Point(12, 12);
            this.gpbComponentes.Name = "gpbComponentes";
            this.gpbComponentes.Size = new System.Drawing.Size(756, 386);
            this.gpbComponentes.TabIndex = 0;
            this.gpbComponentes.TabStop = false;
            this.gpbComponentes.Text = "Componentes";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(34, 60);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(44, 16);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // ltblistarProdutos
            // 
            this.ltblistarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltblistarProdutos.FormattingEnabled = true;
            this.ltblistarProdutos.ItemHeight = 16;
            this.ltblistarProdutos.Location = new System.Drawing.Point(229, 79);
            this.ltblistarProdutos.Name = "ltblistarProdutos";
            this.ltblistarProdutos.Size = new System.Drawing.Size(204, 116);
            this.ltblistarProdutos.TabIndex = 3;
            // 
            // LblListarProdutos
            // 
            this.LblListarProdutos.AutoSize = true;
            this.LblListarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListarProdutos.Location = new System.Drawing.Point(226, 60);
            this.LblListarProdutos.Name = "LblListarProdutos";
            this.LblListarProdutos.Size = new System.Drawing.Size(96, 16);
            this.LblListarProdutos.TabIndex = 2;
            this.LblListarProdutos.Text = "Listar Produtos";
            // 
            // cmbListarnome
            // 
            this.cmbListarnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbListarnome.FormattingEnabled = true;
            this.cmbListarnome.Location = new System.Drawing.Point(37, 186);
            this.cmbListarnome.Name = "cmbListarnome";
            this.cmbListarnome.Size = new System.Drawing.Size(129, 24);
            this.cmbListarnome.TabIndex = 2;
            // 
            // LbllistarNome
            // 
            this.LbllistarNome.AutoSize = true;
            this.LbllistarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbllistarNome.Location = new System.Drawing.Point(34, 170);
            this.LbllistarNome.Name = "LbllistarNome";
            this.LbllistarNome.Size = new System.Drawing.Size(79, 16);
            this.LbllistarNome.TabIndex = 4;
            this.LbllistarNome.Text = "Listar Nome";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(37, 79);
            this.txbNome.MaxLength = 32;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(129, 22);
            this.txbNome.TabIndex = 1;
            this.txbNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNome_KeyDown);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.Location = new System.Drawing.Point(34, 225);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(55, 16);
            this.lblEscolha.TabIndex = 6;
            this.lblEscolha.Text = "escolha";
            // 
            // ckbLivros
            // 
            this.ckbLivros.AutoSize = true;
            this.ckbLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLivros.Location = new System.Drawing.Point(37, 246);
            this.ckbLivros.Name = "ckbLivros";
            this.ckbLivros.Size = new System.Drawing.Size(62, 20);
            this.ckbLivros.TabIndex = 4;
            this.ckbLivros.Text = "Livros";
            this.ckbLivros.UseVisualStyleBackColor = true;
            this.ckbLivros.CheckedChanged += new System.EventHandler(this.ckbLivros_CheckedChanged);
            // 
            // ckbComputador
            // 
            this.ckbComputador.AutoSize = true;
            this.ckbComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbComputador.Location = new System.Drawing.Point(37, 272);
            this.ckbComputador.Name = "ckbComputador";
            this.ckbComputador.Size = new System.Drawing.Size(103, 20);
            this.ckbComputador.TabIndex = 5;
            this.ckbComputador.Text = "Computador ";
            this.ckbComputador.UseVisualStyleBackColor = true;
            this.ckbComputador.CheckedChanged += new System.EventHandler(this.ckbComputador_CheckedChanged);
            // 
            // ckbMesa
            // 
            this.ckbMesa.AutoSize = true;
            this.ckbMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMesa.Location = new System.Drawing.Point(37, 298);
            this.ckbMesa.Name = "ckbMesa";
            this.ckbMesa.Size = new System.Drawing.Size(60, 20);
            this.ckbMesa.TabIndex = 6;
            this.ckbMesa.Text = "Mesa";
            this.ckbMesa.UseVisualStyleBackColor = true;
            this.ckbMesa.CheckedChanged += new System.EventHandler(this.ckbMesa_CheckedChanged);
            // 
            // ckbBanana
            // 
            this.ckbBanana.AutoSize = true;
            this.ckbBanana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBanana.Location = new System.Drawing.Point(37, 323);
            this.ckbBanana.Name = "ckbBanana";
            this.ckbBanana.Size = new System.Drawing.Size(73, 20);
            this.ckbBanana.TabIndex = 7;
            this.ckbBanana.Text = "Banana";
            this.ckbBanana.UseVisualStyleBackColor = true;
            this.ckbBanana.CheckedChanged += new System.EventHandler(this.ckbBanana_CheckedChanged);
            // 
            // pcbImagens
            // 
            this.pcbImagens.Location = new System.Drawing.Point(231, 214);
            this.pcbImagens.Name = "pcbImagens";
            this.pcbImagens.Size = new System.Drawing.Size(202, 128);
            this.pcbImagens.TabIndex = 8;
            this.pcbImagens.TabStop = false;
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 410);
            this.Controls.Add(this.gpbComponentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComponentes";
            this.gpbComponentes.ResumeLayout(false);
            this.gpbComponentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbComponentes;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label LbllistarNome;
        private System.Windows.Forms.ComboBox cmbListarnome;
        private System.Windows.Forms.Label LblListarProdutos;
        private System.Windows.Forms.ListBox ltblistarProdutos;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.CheckBox ckbBanana;
        private System.Windows.Forms.CheckBox ckbMesa;
        private System.Windows.Forms.CheckBox ckbComputador;
        private System.Windows.Forms.CheckBox ckbLivros;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.PictureBox pcbImagens;
    }
}