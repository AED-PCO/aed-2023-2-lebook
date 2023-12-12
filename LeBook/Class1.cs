using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBook
{
    public class Pessoa

    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string email { get; set; }

        public string cpf { get; set; }

        public string telefone { get; set;}

        public string senha { get; set; }

        public string cep { get; set; }

        public class Devolucao
        {

            public string Titulo_Livro { get; set; }
            public DateTime DataReserva { get; set; }

            public DateTime DataDevolucao { get; set; }
        }
    }
}
