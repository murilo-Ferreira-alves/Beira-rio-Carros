using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BeiraRioFuncionarios.DAL;
using BeiraRioFuncionarios.Modelo;

namespace BeiraRioFuncionarios.Apresentacao
{
    public partial class ExCadastroForm : Form

    {
       
        public ExCadastroForm()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-2526HPK6\SQLEXPRESS;Initial Catalog=BeiraRioBancoDeDados;Integrated Security=True;Encrypt=False");
        SqlCommand cm = new SqlCommand();
        SqlDataReader objDados;

        public void limpaCampo()
        {
            TxbCadastro.Text = "";
            TxbSenha.Text = "";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == System.Data.ConnectionState.Closed) { cn.Open(); }
                string strSQL = "delete from Login where IDCadrastro =" + TxbCadastro.Text;
                cm.Connection = cn;
                cm.CommandText = strSQL;
                cm.ExecuteNonQuery();
                MessageBox.Show("Cadastro excluido ", "Excluindo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                limpaCampo();
                BtnApagar.Enabled = false;
                if (cn.State == System.Data.ConnectionState.Open) { cn.Close(); }




            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
                cn.Close();
            }
            

        }

        private void ExCadastroForm_Load(object sender, EventArgs e)
        {
            
            BtnApagar.Enabled = false;
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Acessar(TxbCadastro.Text, TxbSenha.Text);
            if (controle.Mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Cadastro e senha encontrados", "Buscando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnApagar.Enabled = true;   
                }
                else
                {
                    MessageBox.Show("Cadastro ou senha estão Inexistente", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpaCampo();
                    
                }
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
