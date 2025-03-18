
namespace proje01
{
    partial class Frm_Ex02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ex02));
            this.Lbl_Calculadora = new System.Windows.Forms.Label();
            this.Txt_Valor1 = new System.Windows.Forms.TextBox();
            this.Txt_Valor2 = new System.Windows.Forms.TextBox();
            this.Lbl_Resultadosoma = new System.Windows.Forms.Label();
            this.Btn_Adição = new System.Windows.Forms.Button();
            this.Btn_Dividir = new System.Windows.Forms.Button();
            this.Btn_Multiplicar = new System.Windows.Forms.Button();
            this.Btn_Subtrair = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Calculadora
            // 
            this.Lbl_Calculadora.AutoSize = true;
            this.Lbl_Calculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Calculadora.Location = new System.Drawing.Point(53, 57);
            this.Lbl_Calculadora.Name = "Lbl_Calculadora";
            this.Lbl_Calculadora.Size = new System.Drawing.Size(87, 18);
            this.Lbl_Calculadora.TabIndex = 1;
            this.Lbl_Calculadora.Text = "Calculadora";
            // 
            // Txt_Valor1
            // 
            this.Txt_Valor1.Location = new System.Drawing.Point(159, 38);
            this.Txt_Valor1.Name = "Txt_Valor1";
            this.Txt_Valor1.Size = new System.Drawing.Size(186, 20);
            this.Txt_Valor1.TabIndex = 2;
            // 
            // Txt_Valor2
            // 
            this.Txt_Valor2.Location = new System.Drawing.Point(159, 73);
            this.Txt_Valor2.Name = "Txt_Valor2";
            this.Txt_Valor2.Size = new System.Drawing.Size(186, 20);
            this.Txt_Valor2.TabIndex = 3;
            // 
            // Lbl_Resultadosoma
            // 
            this.Lbl_Resultadosoma.AutoSize = true;
            this.Lbl_Resultadosoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultadosoma.Location = new System.Drawing.Point(371, 52);
            this.Lbl_Resultadosoma.Name = "Lbl_Resultadosoma";
            this.Lbl_Resultadosoma.Size = new System.Drawing.Size(30, 25);
            this.Lbl_Resultadosoma.TabIndex = 4;
            this.Lbl_Resultadosoma.Text = "...";
            this.Lbl_Resultadosoma.Click += new System.EventHandler(this.Lbl_Resultadosoma_Click);
            // 
            // Btn_Adição
            // 
            this.Btn_Adição.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Adição.Location = new System.Drawing.Point(258, 168);
            this.Btn_Adição.Name = "Btn_Adição";
            this.Btn_Adição.Size = new System.Drawing.Size(87, 29);
            this.Btn_Adição.TabIndex = 5;
            this.Btn_Adição.Text = "Adição";
            this.Btn_Adição.UseVisualStyleBackColor = true;
            this.Btn_Adição.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // Btn_Dividir
            // 
            this.Btn_Dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dividir.Location = new System.Drawing.Point(159, 168);
            this.Btn_Dividir.Name = "Btn_Dividir";
            this.Btn_Dividir.Size = new System.Drawing.Size(87, 29);
            this.Btn_Dividir.TabIndex = 10;
            this.Btn_Dividir.Text = "Dividir";
            this.Btn_Dividir.UseVisualStyleBackColor = true;
            this.Btn_Dividir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Multiplicar
            // 
            this.Btn_Multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Multiplicar.Location = new System.Drawing.Point(258, 122);
            this.Btn_Multiplicar.Name = "Btn_Multiplicar";
            this.Btn_Multiplicar.Size = new System.Drawing.Size(87, 29);
            this.Btn_Multiplicar.TabIndex = 15;
            this.Btn_Multiplicar.Text = "Multiplicar";
            this.Btn_Multiplicar.UseVisualStyleBackColor = true;
            this.Btn_Multiplicar.Click += new System.EventHandler(this.Btn_Multiplicar_Click);
            // 
            // Btn_Subtrair
            // 
            this.Btn_Subtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Subtrair.Location = new System.Drawing.Point(159, 122);
            this.Btn_Subtrair.Name = "Btn_Subtrair";
            this.Btn_Subtrair.Size = new System.Drawing.Size(87, 29);
            this.Btn_Subtrair.TabIndex = 20;
            this.Btn_Subtrair.Text = "Subtrair";
            this.Btn_Subtrair.UseVisualStyleBackColor = true;
            this.Btn_Subtrair.Click += new System.EventHandler(this.Btn_Subtrair_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Location = new System.Drawing.Point(353, 410);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(78, 28);
            this.Btn_Voltar.TabIndex = 21;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click_1);
            // 
            // Frm_Ex02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Subtrair);
            this.Controls.Add(this.Btn_Multiplicar);
            this.Controls.Add(this.Btn_Dividir);
            this.Controls.Add(this.Btn_Adição);
            this.Controls.Add(this.Lbl_Resultadosoma);
            this.Controls.Add(this.Txt_Valor2);
            this.Controls.Add(this.Txt_Valor1);
            this.Controls.Add(this.Lbl_Calculadora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Ex02";
            this.Text = "Frm_Ex02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Calculadora;
        private System.Windows.Forms.TextBox Txt_Valor1;
        private System.Windows.Forms.TextBox Txt_Valor2;
        private System.Windows.Forms.Label Lbl_Resultadosoma;
        private System.Windows.Forms.Button Btn_Adição;
        private System.Windows.Forms.Button Btn_Dividir;
        private System.Windows.Forms.Button Btn_Multiplicar;
        private System.Windows.Forms.Button Btn_Subtrair;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}