
namespace proje01
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lbl_Texto = new System.Windows.Forms.Label();
            this.Btn_Mudar = new System.Windows.Forms.Button();
            this.Txt_Mudartexto = new System.Windows.Forms.TextBox();
            this.Btn_apoio = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_proximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Texto
            // 
            this.Lbl_Texto.AutoSize = true;
            this.Lbl_Texto.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Texto.Location = new System.Drawing.Point(88, 54);
            this.Lbl_Texto.Name = "Lbl_Texto";
            this.Lbl_Texto.Size = new System.Drawing.Size(117, 44);
            this.Lbl_Texto.TabIndex = 0;
            this.Lbl_Texto.Text = "Texto";
            // 
            // Btn_Mudar
            // 
            this.Btn_Mudar.Location = new System.Drawing.Point(61, 195);
            this.Btn_Mudar.Name = "Btn_Mudar";
            this.Btn_Mudar.Size = new System.Drawing.Size(71, 33);
            this.Btn_Mudar.TabIndex = 1;
            this.Btn_Mudar.Text = "Mudar";
            this.Btn_Mudar.UseVisualStyleBackColor = true;
            this.Btn_Mudar.Click += new System.EventHandler(this.Btn_Mudar_Click);
            // 
            // Txt_Mudartexto
            // 
            this.Txt_Mudartexto.Location = new System.Drawing.Point(61, 134);
            this.Txt_Mudartexto.Name = "Txt_Mudartexto";
            this.Txt_Mudartexto.Size = new System.Drawing.Size(162, 20);
            this.Txt_Mudartexto.TabIndex = 3;
            this.Txt_Mudartexto.TextChanged += new System.EventHandler(this.Txt_Mudartexto_TextChanged);
            // 
            // Btn_apoio
            // 
            this.Btn_apoio.Location = new System.Drawing.Point(294, 129);
            this.Btn_apoio.Name = "Btn_apoio";
            this.Btn_apoio.Size = new System.Drawing.Size(69, 29);
            this.Btn_apoio.TabIndex = 4;
            this.Btn_apoio.Text = "Exibir";
            this.Btn_apoio.UseVisualStyleBackColor = true;
            this.Btn_apoio.Click += new System.EventHandler(this.Btn_apoio_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Location = new System.Drawing.Point(153, 195);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(70, 33);
            this.Btn_Voltar.TabIndex = 2;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(61, 366);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(71, 34);
            this.Btn_Sair.TabIndex = 5;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_proximo
            // 
            this.Btn_proximo.Location = new System.Drawing.Point(664, 366);
            this.Btn_proximo.Name = "Btn_proximo";
            this.Btn_proximo.Size = new System.Drawing.Size(72, 34);
            this.Btn_proximo.TabIndex = 6;
            this.Btn_proximo.Text = "Próximo";
            this.Btn_proximo.UseVisualStyleBackColor = true;
            this.Btn_proximo.Click += new System.EventHandler(this.Btn_proximo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_proximo);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_apoio);
            this.Controls.Add(this.Txt_Mudartexto);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Mudar);
            this.Controls.Add(this.Lbl_Texto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Revisão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Texto;
        private System.Windows.Forms.Button Btn_Mudar;
        private System.Windows.Forms.TextBox Txt_Mudartexto;
        private System.Windows.Forms.Button Btn_apoio;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_proximo;
    }
}

