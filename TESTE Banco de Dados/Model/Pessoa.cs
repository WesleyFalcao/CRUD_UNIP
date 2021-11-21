using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_Banco_de_Dados.Model
{
    class Pessoa
    {
        protected int id_Pessoa;

        protected string nome;

        protected long CPF;

        protected Endereco endereco;

        protected List<Telefone> telefone;
    }
}
