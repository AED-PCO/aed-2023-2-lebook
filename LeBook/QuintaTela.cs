using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LeBook
{
    public partial class QuintaTela : Form
    {
        public QuintaTela()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Devolucao> listaDevolucao = new List<Devolucao>();
            SalvarParaArquivo(listaDevolucao);

        }

        public void SalvarParaArquivo(List<Devolucao> listaDevolucao)
        {
                XmlSerializer serial = new XmlSerializer(typeof(List<Devolucao>));
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\DadosDevolucao.xml", FileMode.Create, FileAccess.Write))
                {
                    serial.Serialize(fs, listaDevolucao);
                    MessageBox.Show("Criado e salvo");
                    this.Close();

                }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
    }

