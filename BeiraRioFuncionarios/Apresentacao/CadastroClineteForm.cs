using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BeiraRioFuncionarios.Apresentacao
{
    public partial class CadastroClineteForm : Form
    {
        public CadastroClineteForm()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-2526HPK6\SQLEXPRESS;Initial Catalog=BeiraRioBancoDeDados;Integrated Security=True;Encrypt=False");
        SqlCommand cm = new SqlCommand();
        SqlDataReader objDados;

        public void LimpaCampo()
        {
            TxbCpf.Text = "";
            TxbNomeCliente.Text= "";
        
        }

        private void CadastroClineteForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beiraRioBancoDeDadosDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.beiraRioBancoDeDadosDataSet.Cliente);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm.Connection = cn;
                string strSql = "insert into Cliente(NomeCliente,CPF)values(@NomeCliente,@CPF)";
                cm.Parameters.Add("@NomeCliente", SqlDbType.VarChar).Value = TxbNomeCliente.Text;
                cm.Parameters.Add("@CPF", SqlDbType.VarChar).Value = TxbCpf.Text;
                cm.CommandText = strSql;
                cm.ExecuteNonQuery();
                MessageBox.Show("Novo Cliente inserido", "Inserindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();
                LimpaCampo();
                


            }
            catch (Exception )
            {

                MessageBox.Show("Ocorreu um erro verifique os dados digitados", "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaCampo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == System.Data.ConnectionState.Closed) { cn.Open(); }

                string strSQL = "delete from Cliente where IdCliente =" + CbxIdCliente.SelectedValue;
                cm.Connection = cn;
                cm.CommandText = strSQL;
                cm.ExecuteNonQuery();
                MessageBox.Show("Cliente excluido ", "Excluindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (cn.State == System.Data.ConnectionState.Open) { cn.Close(); }




            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

                cn.Close();
            }
        }
    }
}
