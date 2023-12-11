using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeBook
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carregar a imagem do projeto
            Image Domquixote = Properties.Resources.Domquixote; // Certifique-se de substituir "MinhaImagem" pelo nome real da sua imagem

            // Atribuir a imagem ao controle PictureBox
            pictureBox1.Image = Domquixote;
        }

        private void ahdsgiuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cONSULTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exibir uma caixa de diálogo de confirmação
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se o usuário clicar em "Sim", fechar o programa
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            // Se o usuário clicar em "Não", não fazer nada
            else if (result == DialogResult.No)
            {
                // Não fazer nada ou adicionar lógica adicional, se necessário
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }

        private void lIVROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar uma instância do novo formulário
            Livros Livros = new Livros();

            // Exibir o novo formulário
            Livros.Show();
        }

        private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar uma instância do novo formulário
            QuartaTela QuartaTela = new QuartaTela();

            // Exibir o novo formulário
            QuartaTela.Show();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar uma instância do novo formulário
            Tela segundaTela = new SegundaTela();

            // Exibir o novo formulário
            segundaTela.Show();
        }

        private void dEVOLUÇÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar uma instância do novo formulário
            Devolução Devolução = new Devolução();

            // Exibir o novo formulário
            Devolução.Show();
        }

        private void aJUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // URL do site externo
            string url = "https://answers.microsoft.com/pt-br/msoffice/forum/all/suporte-para-microsoft-forms/0eb71c22-efd8-4479-8e02-fffd6616f090";

            // Abrir o navegador padrão com a URL
            Process.Start(url);
        }
    }
}

