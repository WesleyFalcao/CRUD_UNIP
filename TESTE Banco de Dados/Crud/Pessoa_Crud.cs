using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using TESTE_Banco_de_Dados.Model;

namespace TESTE_Banco_de_Dados.Crud
{
    public class Pessoa_Crud 
    {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            string mensagem = "";
            

        public bool Excluir(Pessoa p)
        {
            cmd.CommandText = "delete from Banco_Pim ( id ) where id = @id ";
            cmd.Parameters.AddWithValue("@id", p.id_Pessoa);

            bool retorno = false;
            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();

                conexao.desconectar();

                this.mensagem = "Deletado com sucesso";

                retorno = true;
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao deletar";
                Console.WriteLine(e.Message);
            }

            return retorno;
        }


        public bool Cadastrar(Pessoa p)
        {
            cmd.CommandText = "insert into Banco_Pim(nome, CPF, telefone, email, endereco) values (@nome, @cpf, @telefone, @email, @endereco)";
            cmd.Parameters.AddWithValue("@nome", p.nome);
            cmd.Parameters.AddWithValue("cpf", p.CPF);
            cmd.Parameters.AddWithValue("telefone", p.telefone);
            cmd.Parameters.AddWithValue("email", p.email);
            cmd.Parameters.AddWithValue("endereco", p.endereco);

            bool retorno = false;
            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();

                conexao.desconectar();

                retorno = true;
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro aoi deletar";
                Console.WriteLine(e.Message);
            }

            return retorno;
        }


        public bool Alterar(Pessoa p)
        {
            cmd.CommandText = "update Banco_Pim set nome=@nome, cpf=@cpf, email=@email, telefone=@telefone";

            cmd.Parameters.AddWithValue("@nome", p.nome);
            cmd.Parameters.AddWithValue("cpf", p.CPF);
            cmd.Parameters.AddWithValue("telefone", p.telefone);
            cmd.Parameters.AddWithValue("email", p.email);
            cmd.Parameters.AddWithValue("endereco", p.endereco);

            bool retorno = false;
            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();

                conexao.desconectar();

                retorno = true;
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao deletar";
                Console.WriteLine(e.Message);
            }

            return retorno;
        }


        public void Buscar(Pessoa p)
        {
            cmd.CommandText = "select * from Banco_Pim where nome = @nome";
            cmd.Parameters.AddWithValue("nome", p.nome);

            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();

                conexao.desconectar();

                this.mensagem = "Sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao buscar";
                Console.WriteLine(e.Message);
            }
        }
    }
}

