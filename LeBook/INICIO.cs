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
            Image Domquixote = Properties.Resources.Domquixote;

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

            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }

        private void lIVROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Livros Livros = new Livros();

            Livros.Show();
        }

        private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuartaTela QuartaTela = new QuartaTela();
            QuartaTela.Show();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SegundaTela segundaTela = new SegundaTela();

            segundaTela.Show();
        }

        private void aJUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://answers.microsoft.com/pt-br/msoffice/forum/all/suporte-para-microsoft-forms/0eb71c22-efd8-4479-8e02-fffd6616f090";


            Process.Start(url);
        }
    }
}

