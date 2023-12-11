using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LeBook
{
    public partial class SegundaTela : Form
    {
        private List<Cliente> clientes = new List<Cliente>();

        public SegundaTela()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string emailDigitado = textBox2.Text;
            string senhaDigitada = maskedTextBox1.Text;

            // Verifica se o cliente já está cadastrado
            if (clientes.Any(cliente => cliente.Email == emailDigitado))
            {
                MessageBox.Show("Este cliente já está cadastrado. Faça login em vez de se cadastrar.");
            }
            else
            {
                // Cria um novo cliente e adiciona à lista
                Cliente novoCliente = new Cliente
                {
                    Email = emailDigitado,
                    Senha = senhaDigitada
                };

                clientes.Add(novoCliente);

                MessageBox.Show("Cadastro bem-sucedido!");
            }
        }

        public class Cliente
        {
            public string Email { get; set; }
            public string Senha { get; set; }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                this.Email = new System.Windows.Forms.Label();
                this.Senha = new System.Windows.Forms.Label();
                this.textBox2 = new System.Windows.Forms.TextBox();
                this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
                this.pictureBox1 = new System.Windows.Forms.PictureBox();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                this.SuspendLayout();
                // 
                // Email
                // 
                this.Email.AutoSize = true;
                this.Email.Location = new System.Drawing.Point(89, 138);
                this.Email.Name = "Email";
                this.Email.Size = new System.Drawing.Size(32, 13);
                this.Email.TabIndex = 1;
                this.Email.Text = "Email";
                this.Email.Click += new System.EventHandler(this.label1_Click);
                // 
                // Senha
                // 
                this.Senha.AutoSize = true;
                this.Senha.Location = new System.Drawing.Point(89, 182);
                this.Senha.Name = "Senha";
                this.Senha.Size = new System.Drawing.Size(38, 13);
                this.Senha.TabIndex = 2;
                this.Senha.Text = "Senha";
                // 
                // textBox2
                // 
                this.textBox2.Location = new System.Drawing.Point(133, 135);
                this.textBox2.Name = "textBox2";
                this.textBox2.Size = new System.Drawing.Size(136, 20);
                this.textBox2.TabIndex = 4;
                // 
                // maskedTextBox1
                // 
                this.maskedTextBox1.Location = new System.Drawing.Point(133, 179);
                this.maskedTextBox1.Mask = "00000";
                this.maskedTextBox1.Name = "maskedTextBox1";
                this.maskedTextBox1.Size = new System.Drawing.Size(136, 20);
                this.maskedTextBox1.TabIndex = 5;
                this.maskedTextBox1.ValidatingType = typeof(int);
                // 
                // pictureBox1
                // 
                this.pictureBox1.Image = global::LeBook.Properties.Resources.pilha_de_quatro_livros_velhos_15440680;
                this.pictureBox1.Location = new System.Drawing.Point(293, 38);
                this.pictureBox1.Name = "pictureBox1";
                this.pictureBox1.Size = new System.Drawing.Size(100, 50);
                this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.pictureBox1.TabIndex = 6;
                this.pictureBox1.TabStop = false;
                // 
                // SegundaTela
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(405, 450);
                this.Controls.Add(this.pictureBox1);
                this.Controls.Add(this.maskedTextBox1);
                this.Controls.Add(this.textBox2);
                this.Controls.Add(this.Senha);
                this.Controls.Add(this.Email);
                this.Name = "SegundaTela";
                this.Text = "Form2";
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}
#endregion
