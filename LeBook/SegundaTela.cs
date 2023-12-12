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
    public partial class SegundaTela : Form
    {
        public SegundaTela()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        
        
        private List<Pessoa> CarregarDadosPessoas()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            if (File.Exists(Environment.CurrentDirectory + "\\DadosPessoas.xml"))
            {
                XmlSerializer serial = new XmlSerializer(typeof(List<Pessoa>));

                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\DadosPessoas.xml", FileMode.Open, FileAccess.Read))
                {
                    listaPessoas = serial.Deserialize(fs) as List<Pessoa>;
                }
            }
            return listaPessoas;
        }

        private bool VerificarCredenciais(string email, string senha)
        {
            List<Pessoa> listaPessoas = CarregarDadosPessoas();
            return listaPessoas.Any(p => p.email == email && p.senha == senha);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string emailDigitado = textBox2.Text;
            string senhaDigitada = maskedTextBox1.Text;

            if (VerificarCredenciais(emailDigitado, senhaDigitada))
            {
                MessageBox.Show("Login bem-sucedido!");
                this.Close();
             
                Livros Livros = new Livros();
                Livros.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas. Tente novamente.");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    }
}

