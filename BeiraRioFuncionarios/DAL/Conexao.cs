using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeiraRioFuncionarios.DAL
{
    internal class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=LAPTOP-2526HPK6\SQLEXPRESS;Initial Catalog=BeiraRioBancoDeDados;Integrated Security=True;Encrypt=False";
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
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
