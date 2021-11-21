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
            Pessoa p = new Pessoa();

        public void Deletar(int id)
        {
            cmd.CommandText = "delete from Banco_Pim ( id ) where id = @id ";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();

                conexao.desconectar();

                this.mensagem = "Deletado com sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao deletar";
                Console.WriteLine(e.Message);
            }
        }


        public void Cadastrar(string nome, int cpf, int telefone, string email, string endereco)
        {
            cmd.CommandText = "insert into Banco_Pim(nome, CPF, telefone, email, endereco) values (@nome, @cpf, @telefone, @email, @endereco)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("cpf", cpf);
            cmd.Parameters.AddWithValue("telefone", telefone);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("endereco", endereco);
            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();

                conexao.desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro aoi deletar";
                Console.WriteLine(e.Message);
            }
        }


        public void Alterar(string nome, int cpf, int telefone, string email, string endereco)
        {
            cmd.CommandText = "update Banco_Pim set nome=@nome, cpf=@cpf, email=@email, telefone=@telefone";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("cpf", cpf);
            cmd.Parameters.AddWithValue("telefone", telefone);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("endereco", endereco);
            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();

                conexao.desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro aoi deletar";
                Console.WriteLine(e.Message);
            }
        }


        public void Buscar(string nome)
        {
            cmd.CommandText = "select * from Banco_Pim where nome = @nome";
            cmd.Parameters.AddWithValue("nome", @nome);

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

