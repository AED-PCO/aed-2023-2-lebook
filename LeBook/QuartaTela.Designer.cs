namespace LeBook
{
    partial class QuartaTela
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.CEP = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.Cadastro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(55, 96);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 5;
            this.Nome.Text = "Nome";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(52, 129);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 6;
            this.Email.Text = "Email";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Location = new System.Drawing.Point(52, 168);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(27, 13);
            this.CPF.TabIndex = 7;
            this.CPF.Text = "CPF";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(52, 247);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(38, 13);
            this.Senha.TabIndex = 8;
            this.Senha.Text = "Senha";
            this.Senha.Click += new System.EventHandler(this.Senha_Click);
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(52, 208);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(49, 13);
            this.Telefone.TabIndex = 9;
            this.Telefone.Text = "Telefone";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(122, 247);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(180, 20);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(122, 161);
            this.maskedTextBox2.Mask = "000-00-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(180, 20);
            this.maskedTextBox2.TabIndex = 11;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(122, 205);
            this.maskedTextBox3.Mask = "(999) 000-0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(180, 20);
            this.maskedTextBox3.TabIndex = 12;
            // 
            // CEP
            // 
            this.CEP.AutoSize = true;
            this.CEP.Location = new System.Drawing.Point(55, 291);
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(28, 13);
            this.CEP.TabIndex = 14;
            this.CEP.Text = "CEP";
            this.CEP.Click += new System.EventHandler(this.label2_Click);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(122, 288);
            this.maskedTextBox4.Mask = "00000-9999";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(180, 20);
            this.maskedTextBox4.TabIndex = 15;
            // 
            // Cadastro
            // 
            this.Cadastro.AutoSize = true;
            this.Cadastro.Location = new System.Drawing.Point(183, 52);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(49, 13);
            this.Cadastro.TabIndex = 16;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // QuartaTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.Cadastro);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.CEP);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "QuartaTela";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label CEP;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label Cadastro;
    }
}