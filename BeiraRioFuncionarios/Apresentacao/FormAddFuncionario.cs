using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeiraRioFuncionarios.Apresentacao
{
    public partial class FormAddFuncionario : Form
    {
        public FormAddFuncionario()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-2526HPK6\SQLEXPRESS;Initial Catalog=BeiraRioBancoDeDados;Integrated Security=True;Encrypt=False");
        SqlCommand cm = new SqlCommand();
        private void FormAddFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beiraRioBancoDeDadosDataSet.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.beiraRioBancoDeDadosDataSet.Funcionario);
            // TODO: This line of code loads data into the 'beiraRioBancoDeDadosDataSet.Cargo' table. You can move, or remove it, as needed.
            this.cargoTableAdapter.Fill(this.beiraRioBancoDeDadosDataSet.Cargo);
            BloqueioCampo2();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void BloqueioCampo1()
        {
            TxbNomeFuncionario.Enabled = false;
            DtpDatacontratacao.Enabled = false;
            txbNumerotelefone.Enabled = false;
            CbxCargo.Enabled = false;
            BtnCadastra.Enabled = false;
            CbxFuncionarios.Enabled = true;
            BtnExclui.Enabled = true;
            BtnVoltar.Visible = true;
        }
        public void BloqueioCampo2()
        {
            TxbNomeFuncionario.Enabled= true;
            DtpDatacontratacao.Enabled = true;
            txbNumerotelefone.Enabled = true;
            CbxCargo.Enabled = true;
            BtnCadastra.Enabled = true;
            CbxFuncionarios.Enabled = false;
            BtnExclui.Enabled = false;
            BtnVoltar.Visible = false;
         }
        public void limpacampo()
        {
            txbNumerotelefone.Text = "";
            TxbNomeFuncionario.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == System.Data.ConnectionState.Closed) { cn.Open();}

                string strSql = "insert into funcionario(NomeFuncionario,DataContratacao,Telefone,FkidCargo)values(@NomeFuncionario,@DataContratacao,@Telefone,@FkidCargo)";
                cm.Parameters.Clear(); 
                cm.Parameters.Add("@NomeFuncionario", SqlDbType.VarChar).Value = TxbNomeFuncionario.Text;
                cm.Parameters.Add("@DataContratacao", SqlDbType.VarChar).Value = DtpDatacontratacao.Value;
                cm.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txbNumerotelefone.Text;
                cm.Parameters.Add("@FkidCargo", SqlDbType.VarChar).Value = CbxCargo.SelectedValue;
                cm.Connection = cn;
                cm.CommandText = strSql;
                cm.ExecuteNonQuery();
                MessageBox.Show("Novo funcionario inserido", "Inserindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                limpacampo();

                if (cn.State == System.Data.ConnectionState.Open) { cn.Close(); }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro verifique os dados digitados", "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                limpacampo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BloqueioCampo1();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            BloqueioCampo2();
        }

        private void CbxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnExclui_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == System.Data.ConnectionState.Closed) { cn.Open(); }

                string strSQL = "delete from funcionario where IdFuncionario =" + CbxFuncionarios.SelectedValue;
                cm.Connection = cn;
                cm.CommandText = strSQL;
                cm.ExecuteNonQuery();
                MessageBox.Show("Cadastro excluido ", "Excluindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
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
