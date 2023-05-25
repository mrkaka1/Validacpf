namespace Forms3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.mx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tx_altura = new System.Windows.Forms.TextBox();
            this.tx_idade = new System.Windows.Forms.TextBox();
            this.tx_peso = new System.Windows.Forms.TextBox();
            this.cmb_sexo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_resu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cpf:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Peso:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Idade:";
            // 
            // tx_nome
            // 
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_nome.Location = new System.Drawing.Point(97, 61);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(230, 22);
            this.tx_nome.TabIndex = 6;
            // 
            // mx_cpf
            // 
            this.mx_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mx_cpf.Location = new System.Drawing.Point(97, 107);
            this.mx_cpf.Mask = "000,000,000-00";
            this.mx_cpf.Name = "mx_cpf";
            this.mx_cpf.Size = new System.Drawing.Size(182, 22);
            this.mx_cpf.TabIndex = 7;
            // 
            // tx_altura
            // 
            this.tx_altura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_altura.Location = new System.Drawing.Point(314, 228);
            this.tx_altura.Name = "tx_altura";
            this.tx_altura.Size = new System.Drawing.Size(77, 22);
            this.tx_altura.TabIndex = 8;
            this.tx_altura.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tx_idade
            // 
            this.tx_idade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_idade.Location = new System.Drawing.Point(97, 286);
            this.tx_idade.Name = "tx_idade";
            this.tx_idade.Size = new System.Drawing.Size(100, 22);
            this.tx_idade.TabIndex = 9;
            this.tx_idade.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tx_peso
            // 
            this.tx_peso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_peso.Location = new System.Drawing.Point(97, 230);
            this.tx_peso.Name = "tx_peso";
            this.tx_peso.Size = new System.Drawing.Size(75, 22);
            this.tx_peso.TabIndex = 10;
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.FormattingEnabled = true;
            this.cmb_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cmb_sexo.Location = new System.Drawing.Point(97, 161);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(137, 24);
            this.cmb_sexo.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(46, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(276, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 51);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(519, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Resultado IMC:";
            // 
            // tx_resu
            // 
            this.tx_resu.AutoSize = true;
            this.tx_resu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_resu.Location = new System.Drawing.Point(531, 113);
            this.tx_resu.Name = "tx_resu";
            this.tx_resu.Size = new System.Drawing.Size(70, 25);
            this.tx_resu.TabIndex = 15;
            this.tx_resu.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 480);
            this.Controls.Add(this.tx_resu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_sexo);
            this.Controls.Add(this.tx_peso);
            this.Controls.Add(this.tx_idade);
            this.Controls.Add(this.tx_altura);
            this.Controls.Add(this.mx_cpf);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.MaskedTextBox mx_cpf;
        private System.Windows.Forms.TextBox tx_altura;
        private System.Windows.Forms.TextBox tx_idade;
        private System.Windows.Forms.TextBox tx_peso;
        private System.Windows.Forms.ComboBox cmb_sexo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tx_resu;
    }
}

