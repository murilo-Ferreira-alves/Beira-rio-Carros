using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BeiraRioFuncionarios.DAL
{
    internal class LoginDalComandos
    {
        public bool tem = false;
        public String Mensagem =  "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool VerificarCadrastro(string IDCadrastro, string Senha)
        {
            cmd.CommandText = "Select * from Login where IDCadrastro = @IDCadrastro and Senha  = @Senha ";
            cmd.Parameters.AddWithValue("@IDCadrastro", IDCadrastro);
            cmd.Parameters.AddWithValue("@Senha ", Senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows) 
                {
                     tem = true;
                }
            }
            catch (SqlException)
            {

                this.Mensagem = "Erro com Banco de Dados!";
            }
            return tem;

        }
       
    }
}
