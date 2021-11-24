using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_Banco_de_Dados
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao() 
        {
            con.ConnectionString = "server=localhost;uid=root;pwd=1234;database=pimviii";
        }

        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed) 
            {
                con.Open();
            }
            return con;
        }

        public void desconectar() 
        {
            if(con.State == System.Data.ConnectionState.Open) 
            {
                con.Close();

            }
        }
    }
}
