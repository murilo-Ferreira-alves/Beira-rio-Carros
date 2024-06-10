using BeiraRioFuncionarios.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BeiraRioFuncionarios.Modelo
{
    public class Controle
    {
        public bool tem;
        public String Mensagem = "";
        public bool Acessar (String IDCadrastro,string Senha)
        {
            LoginDalComandos loginDal = new LoginDalComandos();
            tem = loginDal.VerificarCadrastro(IDCadrastro, Senha);
            if (!loginDal.Mensagem.Equals(""))
            {
                this.Mensagem = loginDal.Mensagem;
            }
            return tem;
        }

        public String Cadastrar (String Cadrastro,String Senha , String ConfSenha)
        {
            return Mensagem;
        }
           
    }
    
} 
