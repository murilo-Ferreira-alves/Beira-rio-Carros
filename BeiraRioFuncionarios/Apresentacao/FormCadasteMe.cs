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

namespace BeiraRioFuncionarios.Apresentacao
{
    public partial class FormCadasteMe : Form
    {
        public FormCadasteMe()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-2526HPK6\SQLEXPRESS;Initial Catalog=BeiraRioBancoDeDados;Integrated Security=True;Encrypt=False");
        SqlCommand cm = new SqlCommand();
        SqlDataReader objDados;

        public void limpaCampo ()
        {
            TxbCriarCadrastro.Text = "";
            TxbCriarSenha.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCadaste_Me_Load(object sender, EventArgs e)
        {
          
        }

        private void BtnCadrastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == System.Data.ConnectionState.Closed) { cn.Open(); }

                string strSql = "Select IDCadrastro from Login where IDCadrastro = " + TxbCriarCadrastro.Text;
                cm.Connection = cn;
                cm.CommandText = strSql;
                objDados = cm.ExecuteReader();


                if(objDados.HasRows)
                {
                    MessageBox.Show(" Cadrastro existente","Ops",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cn.Close();
                    limpaCampo();

                }
                else
                {
                    if(!objDados.IsClosed) {objDados.Close();}
                    strSql = "insert into Login(IDCadrastro,Senha)values(@Cadrastro,@Senha)";
                    cm.Parameters.Add("@Cadrastro", SqlDbType.VarChar).Value = TxbCriarCadrastro.Text;
                    cm.Parameters.Add("@Senha", SqlDbType.VarChar).Value = TxbCriarSenha.Text;
                    cm.CommandText = strSql;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Novo Cadrastro inserido", "Inserindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    limpaCampo();
                    if (cn.State == System.Data.ConnectionState.Open) { cn.Close(); }

                }
                
                

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);

                if (cn.State == System.Data.ConnectionState.Open) { cn.Close(); }
            }
        }
    }
}
