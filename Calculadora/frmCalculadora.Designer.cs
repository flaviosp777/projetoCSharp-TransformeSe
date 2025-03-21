namespace Calculadora
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblNumeroUm = new System.Windows.Forms.Label();
            this.lblNumeroDois = new System.Windows.Forms.Label();
            this.txtNumeroUm = new System.Windows.Forms.TextBox();
            this.txtNumeroDois = new System.Windows.Forms.TextBox();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.gpbOperacoes = new System.Windows.Forms.GroupBox();
            this.rbtSomar = new System.Windows.Forms.RadioButton();
            this.rbtSubtrair = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rdbDividir = new System.Windows.Forms.RadioButton();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroUm
            // 
            this.lblNumeroUm.AutoSize = true;
            this.lblNumeroUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroUm.Location = new System.Drawing.Point(22, 37);
            this.lblNumeroUm.Name = "lblNumeroUm";
            this.lblNumeroUm.Size = new System.Drawing.Size(78, 20);
            this.lblNumeroUm.TabIndex = 0;
            this.lblNumeroUm.Text = "Número 1";
            // 
            // lblNumeroDois
            // 
            this.lblNumeroDois.AutoSize = true;
            this.lblNumeroDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDois.Location = new System.Drawing.Point(23, 124);
            this.lblNumeroDois.Name = "lblNumeroDois";
            this.lblNumeroDois.Size = new System.Drawing.Size(78, 20);
            this.lblNumeroDois.TabIndex = 1;
            this.lblNumeroDois.Text = "Número 2";
            // 
            // txtNumeroUm
            // 
            this.txtNumeroUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroUm.Location = new System.Drawing.Point(26, 60);
            this.txtNumeroUm.Name = "txtNumeroUm";
            this.txtNumeroUm.Size = new System.Drawing.Size(100, 26);
            this.txtNumeroUm.TabIndex = 2;
            // 
            // txtNumeroDois
            // 
            this.txtNumeroDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDois.Location = new System.Drawing.Point(26, 147);
            this.txtNumeroDois.Name = "txtNumeroDois";
            this.txtNumeroDois.Size = new System.Drawing.Size(100, 26);
            this.txtNumeroDois.TabIndex = 3;
            // 
            // txtResposta
            // 
            this.txtResposta.Enabled = false;
            this.txtResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResposta.Location = new System.Drawing.Point(26, 236);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(100, 26);
            this.txtResposta.TabIndex = 4;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(23, 213);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(82, 20);
            this.lblResposta.TabIndex = 5;
            this.lblResposta.Text = "Resposta ";
            // 
            // gpbOperacoes
            // 
            this.gpbOperacoes.Controls.Add(this.rdbDividir);
            this.gpbOperacoes.Controls.Add(this.rdbMultiplicar);
            this.gpbOperacoes.Controls.Add(this.rbtSubtrair);
            this.gpbOperacoes.Controls.Add(this.rbtSomar);
            this.gpbOperacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOperacoes.Location = new System.Drawing.Point(252, 60);
            this.gpbOperacoes.Name = "gpbOperacoes";
            this.gpbOperacoes.Size = new System.Drawing.Size(224, 204);
            this.gpbOperacoes.TabIndex = 6;
            this.gpbOperacoes.TabStop = false;
            this.gpbOperacoes.Text = "Operações";
            // 
            // rbtSomar
            // 
            this.rbtSomar.AutoSize = true;
            this.rbtSomar.Location = new System.Drawing.Point(64, 55);
            this.rbtSomar.Name = "rbtSomar";
            this.rbtSomar.Size = new System.Drawing.Size(74, 24);
            this.rbtSomar.TabIndex = 0;
            this.rbtSomar.TabStop = true;
            this.rbtSomar.Text = "Somar";
            this.rbtSomar.UseVisualStyleBackColor = true;
            // 
            // rbtSubtrair
            // 
            this.rbtSubtrair.AutoSize = true;
            this.rbtSubtrair.Location = new System.Drawing.Point(64, 87);
            this.rbtSubtrair.Name = "rbtSubtrair";
            this.rbtSubtrair.Size = new System.Drawing.Size(83, 24);
            this.rbtSubtrair.TabIndex = 1;
            this.rbtSubtrair.TabStop = true;
            this.rbtSubtrair.Text = "Subtrair";
            this.rbtSubtrair.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicar
            // 
            this.rdbMultiplicar.AutoSize = true;
            this.rdbMultiplicar.Location = new System.Drawing.Point(64, 145);
            this.rdbMultiplicar.Name = "rdbMultiplicar";
            this.rdbMultiplicar.Size = new System.Drawing.Size(97, 24);
            this.rdbMultiplicar.TabIndex = 2;
            this.rdbMultiplicar.TabStop = true;
            this.rdbMultiplicar.Text = "Multiplicar";
            this.rdbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdbDividir
            // 
            this.rdbDividir.AutoSize = true;
            this.rdbDividir.Location = new System.Drawing.Point(64, 115);
            this.rdbDividir.Name = "rdbDividir";
            this.rdbDividir.Size = new System.Drawing.Size(69, 24);
            this.rdbDividir.TabIndex = 3;
            this.rdbDividir.TabStop = true;
            this.rdbDividir.Text = "Dividir";
            this.rdbDividir.UseVisualStyleBackColor = true;
            // 
            // bntCalcular
            // 
            this.bntCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCalcular.Image = ((System.Drawing.Image)(resources.GetObject("bntCalcular.Image")));
            this.bntCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntCalcular.Location = new System.Drawing.Point(644, 31);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(131, 63);
            this.bntCalcular.TabIndex = 7;
            this.bntCalcular.Text = "&Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(644, 108);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(131, 63);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(644, 186);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(131, 63);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.gpbOperacoes);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.txtNumeroDois);
            this.Controls.Add(this.txtNumeroUm);
            this.Controls.Add(this.lblNumeroDois);
            this.Controls.Add(this.lblNumeroUm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbOperacoes.ResumeLayout(false);
            this.gpbOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroUm;
        private System.Windows.Forms.Label lblNumeroDois;
        private System.Windows.Forms.TextBox txtNumeroUm;
        private System.Windows.Forms.TextBox txtNumeroDois;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.GroupBox gpbOperacoes;
        private System.Windows.Forms.RadioButton rdbDividir;
        private System.Windows.Forms.RadioButton rdbMultiplicar;
        private System.Windows.Forms.RadioButton rbtSubtrair;
        private System.Windows.Forms.RadioButton rbtSomar;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

