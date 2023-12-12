using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
=======
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
>>>>>>> c11bcabc61fee38aba9bdffd0755fde0cdfb9733

namespace LeBook
{
    public partial class QuintaTela : Form
    {
<<<<<<< HEAD
        public List<Devolucao> listaDevolucao = new List<Devolucao>();

=======
>>>>>>> c11bcabc61fee38aba9bdffd0755fde0cdfb9733
        public QuintaTela()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        public void label1_Click(object sender, EventArgs e)
        {
            // Código do evento label1_Click
        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Código do evento textBox3_TextChanged
        }

        public void label2_Click(object sender, EventArgs e)
        {
            // Código do evento label2_Click
        }

        public void label3_Click(object sender, EventArgs e)
        {
            // Código do evento label3_Click
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Código do evento textBox1_TextChanged
        }

        public void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Código do evento maskedTextBox1_MaskInputRejected
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            DateTime dataDevolucao;

            if (DateTime.TryParse(maskedTextBox1.Text, out dataDevolucao))
            {
                // Cria uma instância de Devolucao
                Devolucao devolucao = new Devolucao
                {
                    Nome = nome,
                    DataDevolucao = dataDevolucao
                };

                // Adiciona a instância à lista
                listaDevolucao.Add(devolucao);

                // Ordena a lista após adicionar um elemento
                OrdenarLista();

                // Chame métodos ou faça o que for necessário com a lista
                // Exemplo: Salvar a lista em um arquivo XML
                SalvarListaParaArquivo();
            }
            else
            {
                MessageBox.Show("Formato de data inválido. Preencha corretamente.");
            }
        }

        public void OrdenarLista()
        {
            // Ordena a lista por algum critério (por exemplo, Nome)
            listaDevolucao = listaDevolucao.OrderBy(item => item.Nome).ToList();
        }

        public void SalvarListaParaArquivo()
        {
            // Implemente lógica para salvar a lista em um arquivo conforme necessário
            // Exemplo usando serialização XML:
            XmlSerializer serial = new XmlSerializer(typeof(List<Devolucao>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\DadosDevolucao.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, listaDevolucao);
                MessageBox.Show("Criado e salvo");
                this.Close();
            }
        }


            

            public class Devolucao
            {
                // Implemente a classe Devolucao conforme necessário
                // Por exemplo:
                public string Nome { get; set; }
                public DateTime DataDevolucao { get; set; }
                // ... outros membros e métodos necessários
            }
        }
    }

   






=======
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
>>>>>>> c11bcabc61fee38aba9bdffd0755fde0cdfb9733
