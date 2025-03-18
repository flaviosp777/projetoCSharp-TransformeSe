
namespace proje01
{
    partial class Frm_Calc3
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
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.TextBoxNro1 = new System.Windows.Forms.TextBox();
            this.TextBoxNro2 = new System.Windows.Forms.TextBox();
            this.TextBoxResultado = new System.Windows.Forms.TextBox();
            this.LabelOperacao = new System.Windows.Forms.Label();
            this.LabelResultado = new System.Windows.Forms.Label();
            this.RadioButtonSoma = new System.Windows.Forms.RadioButton();
            this.RadioButtonSubtracao = new System.Windows.Forms.RadioButton();
            this.RadioButtonMultiplicacao = new System.Windows.Forms.RadioButton();
            this.RadioButtonDivisao = new System.Windows.Forms.RadioButton();
            this.LabelErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Location = new System.Drawing.Point(135, 24);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(179, 28);
            this.Btn_Calcular.TabIndex = 0;
            this.Btn_Calcular.Text = "Calcular";
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // TextBoxNro1
            // 
            this.TextBoxNro1.Location = new System.Drawing.Point(12, 78);
            this.TextBoxNro1.Name = "TextBoxNro1";
            this.TextBoxNro1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNro1.TabIndex = 1;
            // 
            // TextBoxNro2
            // 
            this.TextBoxNro2.Location = new System.Drawing.Point(170, 78);
            this.TextBoxNro2.Name = "TextBoxNro2";
            this.TextBoxNro2.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNro2.TabIndex = 2;
            // 
            // TextBoxResultado
            // 
            this.TextBoxResultado.Location = new System.Drawing.Point(321, 78);
            this.TextBoxResultado.Name = "TextBoxResultado";
            this.TextBoxResultado.Size = new System.Drawing.Size(100, 20);
            this.TextBoxResultado.TabIndex = 3;
            // 
            // LabelOperacao
            // 
            this.LabelOperacao.AutoSize = true;
            this.LabelOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOperacao.Location = new System.Drawing.Point(132, 81);
            this.LabelOperacao.Name = "LabelOperacao";
            this.LabelOperacao.Size = new System.Drawing.Size(15, 16);
            this.LabelOperacao.TabIndex = 4;
            this.LabelOperacao.Text = "+";
            // 
            // LabelResultado
            // 
            this.LabelResultado.AutoSize = true;
            this.LabelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResultado.Location = new System.Drawing.Point(286, 79);
            this.LabelResultado.Name = "LabelResultado";
            this.LabelResultado.Size = new System.Drawing.Size(15, 16);
            this.LabelResultado.TabIndex = 5;
            this.LabelResultado.Text = "=";
            // 
            // RadioButtonSoma
            // 
            this.RadioButtonSoma.AutoSize = true;
            this.RadioButtonSoma.Location = new System.Drawing.Point(191, 158);
            this.RadioButtonSoma.Name = "RadioButtonSoma";
            this.RadioButtonSoma.Size = new System.Drawing.Size(52, 17);
            this.RadioButtonSoma.TabIndex = 6;
            this.RadioButtonSoma.TabStop = true;
            this.RadioButtonSoma.Text = "Soma";
            this.RadioButtonSoma.UseVisualStyleBackColor = true;
            this.RadioButtonSoma.CheckedChanged += new System.EventHandler(this.RadioButtonSoma_CheckedChanged);
            // 
            // RadioButtonSubtracao
            // 
            this.RadioButtonSubtracao.AutoSize = true;
            this.RadioButtonSubtracao.Location = new System.Drawing.Point(191, 236);
            this.RadioButtonSubtracao.Name = "RadioButtonSubtracao";
            this.RadioButtonSubtracao.Size = new System.Drawing.Size(74, 17);
            this.RadioButtonSubtracao.TabIndex = 7;
            this.RadioButtonSubtracao.TabStop = true;
            this.RadioButtonSubtracao.Text = "Subtração";
            this.RadioButtonSubtracao.UseVisualStyleBackColor = true;
            this.RadioButtonSubtracao.CheckedChanged += new System.EventHandler(this.RadioButtonSubtracao_CheckedChanged);
            // 
            // RadioButtonMultiplicacao
            // 
            this.RadioButtonMultiplicacao.AutoSize = true;
            this.RadioButtonMultiplicacao.Location = new System.Drawing.Point(191, 279);
            this.RadioButtonMultiplicacao.Name = "RadioButtonMultiplicacao";
            this.RadioButtonMultiplicacao.Size = new System.Drawing.Size(87, 17);
            this.RadioButtonMultiplicacao.TabIndex = 8;
            this.RadioButtonMultiplicacao.TabStop = true;
            this.RadioButtonMultiplicacao.Text = "Multiplicação";
            this.RadioButtonMultiplicacao.UseVisualStyleBackColor = true;
            this.RadioButtonMultiplicacao.CheckedChanged += new System.EventHandler(this.RadioButtonMultiplicacao_CheckedChanged);
            // 
            // RadioButtonDivisao
            // 
            this.RadioButtonDivisao.AutoSize = true;
            this.RadioButtonDivisao.Location = new System.Drawing.Point(191, 195);
            this.RadioButtonDivisao.Name = "RadioButtonDivisao";
            this.RadioButtonDivisao.Size = new System.Drawing.Size(60, 17);
            this.RadioButtonDivisao.TabIndex = 9;
            this.RadioButtonDivisao.TabStop = true;
            this.RadioButtonDivisao.Text = "Divisão";
            this.RadioButtonDivisao.UseVisualStyleBackColor = true;
            this.RadioButtonDivisao.CheckedChanged += new System.EventHandler(this.RadioButtonDivisao_CheckedChanged);
            // 
            // LabelErro
            // 
            this.LabelErro.AutoSize = true;
            this.LabelErro.ForeColor = System.Drawing.Color.Red;
            this.LabelErro.Location = new System.Drawing.Point(188, 126);
            this.LabelErro.Name = "LabelErro";
            this.LabelErro.Size = new System.Drawing.Size(0, 13);
            this.LabelErro.TabIndex = 10;
            // 
            // Frm_Calc3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelErro);
            this.Controls.Add(this.RadioButtonDivisao);
            this.Controls.Add(this.RadioButtonMultiplicacao);
            this.Controls.Add(this.RadioButtonSubtracao);
            this.Controls.Add(this.RadioButtonSoma);
            this.Controls.Add(this.LabelResultado);
            this.Controls.Add(this.LabelOperacao);
            this.Controls.Add(this.TextBoxResultado);
            this.Controls.Add(this.TextBoxNro2);
            this.Controls.Add(this.TextBoxNro1);
            this.Controls.Add(this.Btn_Calcular);
            this.Name = "Frm_Calc3";
            this.Text = "Frm_Calc3";
            this.Load += new System.EventHandler(this.Frm_Calc3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.TextBox TextBoxNro1;
        private System.Windows.Forms.TextBox TextBoxNro2;
        private System.Windows.Forms.TextBox TextBoxResultado;
        private System.Windows.Forms.Label LabelOperacao;
        private System.Windows.Forms.Label LabelResultado;
        private System.Windows.Forms.RadioButton RadioButtonSoma;
        private System.Windows.Forms.RadioButton RadioButtonSubtracao;
        private System.Windows.Forms.RadioButton RadioButtonMultiplicacao;
        private System.Windows.Forms.RadioButton RadioButtonDivisao;
        private System.Windows.Forms.Label LabelErro;
    }
}