using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_Banco_de_Dados.Model
{
    public class Pessoa
    {
        public int id_Pessoa;

        public string nome;

        public long CPF;

        public string email;

        public Endereco endereco;

        public List<Telefone> telefone;
    }
}
