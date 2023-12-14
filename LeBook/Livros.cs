using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeBook
{
    public partial class Livros : Form
    {
        public Livros()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Livro reservado anteriormente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Criar uma instância do novo formulário
            QuintaTela QuintaTela = new QuintaTela();

            // Exibir o novo formulário
            QuintaTela.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Criar uma instância do novo formulário
            QuintaTela QuintaTela = new QuintaTela();

            // Exibir o novo formulário
            QuintaTela.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Criar uma instância do novo formulário
            QuintaTela QuintaTela = new QuintaTela();

            // Exibir o novo formulário
            QuintaTela.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Criar uma instância do novo formulário
            QuintaTela QuintaTela = new QuintaTela();

            // Exibir o novo formulário
            QuintaTela.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Criar uma instância do novo formulário
            QuintaTela QuintaTela = new QuintaTela();

            // Exibir o novo formulário
            QuintaTela.Show();
        }

        private void romanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar uma instância do novo formulário
            Romance Romance = new Romance();

            // Exibir o novo formulário
            Romance.Show();
        }

        private void autoAjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar uma instância do novo formulário
           Auto Auto = new Auto();

            // Exibir o novo formulário
           Auto.Show();
        }

        private void terrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar uma instância do novo formulário
            Terror Terror = new Terror();

            // Exibir o novo formulário
            Terror.Show();
        }

        private void ficçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ficção Ficção = new Ficção();

            Ficção.Show();
        }
    }
}
