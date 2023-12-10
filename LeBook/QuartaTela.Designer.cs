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
            this.Nome = new System.Windows.Forms.Label();
            this.NomePessoa = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.EmailPessoa = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.TelefonePessoa = new System.Windows.Forms.MaskedTextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.SenhaPessoa = new System.Windows.Forms.MaskedTextBox();
            this.CEP = new System.Windows.Forms.Label();
            this.CepPessoa = new System.Windows.Forms.MaskedTextBox();
            this.Cadastro = new System.Windows.Forms.Label();
            this.SalvarCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(73, 117);
            this.Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(44, 16);
            this.Nome.TabIndex = 5;
            this.Nome.Text = "Nome";
            this.Nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // NomePessoa
            // 
            this.NomePessoa.Location = new System.Drawing.Point(163, 117);
            this.NomePessoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NomePessoa.Name = "NomePessoa";
            this.NomePessoa.Size = new System.Drawing.Size(239, 22);
            this.NomePessoa.TabIndex = 0;
            this.NomePessoa.TextChanged += new System.EventHandler(this.NomePessoa_TextChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(73, 182);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 6;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // EmailPessoa
            // 
            this.EmailPessoa.Location = new System.Drawing.Point(163, 182);
            this.EmailPessoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailPessoa.Name = "EmailPessoa";
            this.EmailPessoa.Size = new System.Drawing.Size(239, 22);
            this.EmailPessoa.TabIndex = 1;
            this.EmailPessoa.TextChanged += new System.EventHandler(this.EmailPessoa_TextChanged);
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(73, 236);
            this.Telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(61, 16);
            this.Telefone.TabIndex = 9;
            this.Telefone.Text = "Telefone";
            this.Telefone.Click += new System.EventHandler(this.Telefone_Click);
            // 
            // TelefonePessoa
            // 
            this.TelefonePessoa.Location = new System.Drawing.Point(163, 236);
            this.TelefonePessoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TelefonePessoa.Mask = "(999) 00000-0000";
            this.TelefonePessoa.Name = "TelefonePessoa";
            this.TelefonePessoa.Size = new System.Drawing.Size(239, 22);
            this.TelefonePessoa.TabIndex = 12;
            this.TelefonePessoa.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TelefonePessoa_MaskInputRejected);
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(73, 293);
            this.Senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(46, 16);
            this.Senha.TabIndex = 8;
            this.Senha.Text = "Senha";
            this.Senha.Click += new System.EventHandler(this.Senha_Click);
            // 
            // SenhaPessoa
            // 
            this.SenhaPessoa.Location = new System.Drawing.Point(163, 293);
            this.SenhaPessoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SenhaPessoa.Mask = "00000";
            this.SenhaPessoa.Name = "SenhaPessoa";
            this.SenhaPessoa.Size = new System.Drawing.Size(239, 22);
            this.SenhaPessoa.TabIndex = 10;
            this.SenhaPessoa.ValidatingType = typeof(int);
            this.SenhaPessoa.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SenhaPessoa_MaskInputRejected);
            // 
            // CEP
            // 
            this.CEP.AutoSize = true;
            this.CEP.Location = new System.Drawing.Point(73, 358);
            this.CEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(34, 16);
            this.CEP.TabIndex = 14;
            this.CEP.Text = "CEP";
            this.CEP.Click += new System.EventHandler(this.CEP_Click);
            // 
            // CepPessoa
            // 
            this.CepPessoa.Location = new System.Drawing.Point(163, 354);
            this.CepPessoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CepPessoa.Mask = "00000-000";
            this.CepPessoa.Name = "CepPessoa";
            this.CepPessoa.Size = new System.Drawing.Size(239, 22);
            this.CepPessoa.TabIndex = 15;
            this.CepPessoa.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CepPessoa_MaskInputRejected);
            // 
            // Cadastro
            // 
            this.Cadastro.AutoSize = true;
            this.Cadastro.Location = new System.Drawing.Point(244, 64);
            this.Cadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(62, 16);
            this.Cadastro.TabIndex = 16;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.Click += new System.EventHandler(this.Cadastro_Click_1);
            // 
            // SalvarCadastro
            // 
            this.SalvarCadastro.Location = new System.Drawing.Point(321, 442);
            this.SalvarCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SalvarCadastro.Name = "SalvarCadastro";
            this.SalvarCadastro.Size = new System.Drawing.Size(112, 31);
            this.SalvarCadastro.TabIndex = 17;
            this.SalvarCadastro.Text = "Salvar";
            this.SalvarCadastro.UseVisualStyleBackColor = true;
            this.SalvarCadastro.Click += new System.EventHandler(this.Salvar);
            // 
            // QuartaTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 554);
            this.Controls.Add(this.SalvarCadastro);
            this.Controls.Add(this.Cadastro);
            this.Controls.Add(this.CepPessoa);
            this.Controls.Add(this.CEP);
            this.Controls.Add(this.TelefonePessoa);
            this.Controls.Add(this.SenhaPessoa);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.EmailPessoa);
            this.Controls.Add(this.NomePessoa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuartaTela";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomePessoa;
        private System.Windows.Forms.TextBox EmailPessoa;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.MaskedTextBox SenhaPessoa;
        private System.Windows.Forms.MaskedTextBox TelefonePessoa;
        private System.Windows.Forms.Label CEP;
        private System.Windows.Forms.MaskedTextBox CepPessoa;
        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.Button SalvarCadastro;
    }
}