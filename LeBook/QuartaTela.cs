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
using System.Xml;
using System.Xml.Serialization;

namespace LeBook
{
    public partial class QuartaTela : Form
    {
        public QuartaTela()
        {
            InitializeComponent();
            

        }

        private void NomePessoa_TextChanged(object sender, EventArgs e)
        {

        }
        private void EmailPessoa_TextChanged(object sender, EventArgs e)
        {

        }
        private void TelefonePessoa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SenhaPessoa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void CepPessoa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



        private void SalvarParaArquivo(List<Pessoa> listaPessoas)
        {
            XmlSerializer serial = new XmlSerializer(typeof(List<Pessoa>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\DadosPessoas.xml", FileMode.Create,FileAccess.Write))
            {
                serial.Serialize(fs, listaPessoas);
                MessageBox.Show("Criado e salvo");
                this.Close();
                
            }
        }
       
        private void Salvar(object sender, EventArgs e)
        {
            
            List<Pessoa> listaPessoas = new List<Pessoa>();

            listaPessoas = CarregarDoArquivo();

            int proximoId = listaPessoas.Count > 0 ? listaPessoas.Max(p => p.Id) + 1 : 1;
            string nomeDigitado = NomePessoa.Text;
                string emailDigitado = EmailPessoa.Text;
                string telefoneDigitado = TelefonePessoa.Text;
                string senhaDigitado = SenhaPessoa.Text;
                string cepDigitado = CepPessoa.Text;

           

            if (!string.IsNullOrEmpty(nomeDigitado))
            {
                Pessoa novaPessoa = new Pessoa()
                {
                    Id = proximoId,
                    Nome = nomeDigitado,
                    email = emailDigitado,
                    telefone = telefoneDigitado,
                    senha = senhaDigitado,
                    cep = cepDigitado
                };

                listaPessoas.Add(novaPessoa);

                SalvarParaArquivo(listaPessoas);
            }


        }

        private List<Pessoa> CarregarDoArquivo()
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





        private void Cadastro_Click_1(object sender, EventArgs e)
        { 
        }
        private void Nome_Click(object sender, EventArgs e)
        {
        }
        private void Email_Click(object sender, EventArgs e)
        {
        }
        private void Telefone_Click(object sender, EventArgs e)
        {
        }
        private void Senha_Click(object sender, EventArgs e)
        {
        }
        private void CEP_Click(object sender, EventArgs e)
        {
        }
    }
    }

