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
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-2526HPK6\SQLEXPRESS;Initial Catalog=BeiraRioBancoDeDados;Integrated Security=True;Encrypt=False");
        SqlCommand cm = new SqlCommand();
        SqlDataReader objDados;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beiraRioBancoDeDadosDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.beiraRioBancoDeDadosDataSet.Cliente);
            // TODO: This line of code loads data into the 'beiraRioBancoDeDadosDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.beiraRioBancoDeDadosDataSet.Carros);
            // TODO: This line of code loads data into the 'beiraRioBancoDeDadosDataSet.Cargo' table. You can move, or remove it, as needed.
            this.cargoTableAdapter.Fill(this.beiraRioBancoDeDadosDataSet.Cargo);
            // TODO: This line of code loads data into the 'beiraRioBancoDeDadosDataSet.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.beiraRioBancoDeDadosDataSet.Funcionario);
            PnlApagaVolta.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (TxbQuantidade.Text == "")
            {
                TxbQuantidade.Text = "1";

            }

            try
            {
                cn.Open();
                string QuantidadeCarro = TxbQuantidade.Text, Valorvenda;
                int ValorCarroint, QuantidadeCarroInt;
                string strSql = "Select * from Carros where IdCarro =  " + CbxIdCarro.SelectedValue;
                cm.Connection = cn;
                cm.CommandText = strSql;
                objDados = cm.ExecuteReader();
                objDados.Read();
                Valorvenda = objDados["valor"].ToString();
                cn.Close();

                ValorCarroint = Convert.ToInt32(Valorvenda);
                QuantidadeCarroInt = Convert.ToInt32(QuantidadeCarro);

                ValorCarroint = ValorCarroint * QuantidadeCarroInt;
                Valorvenda = Convert.ToString(ValorCarroint);
                TxbValorVenda.Text = Valorvenda.ToString();



                if (!objDados.IsClosed) { objDados.Close(); }


                cn.Open();
                string PorcentagemVedendor;
                int PorcentegemVendedorInt;
                string strSql2 = "select * from cargo where idCargo = " + CbxIdCargo.SelectedValue;
                cm.Connection = cn;
                cm.CommandText = strSql2;
                objDados = cm.ExecuteReader();
                objDados.Read();
                PorcentagemVedendor = objDados["PorcentagemPorCompraRealizada"].ToString();
                PorcentegemVendedorInt = Convert.ToInt32(PorcentagemVedendor);
                PorcentegemVendedorInt = (ValorCarroint * PorcentegemVendedorInt) / 100;
                PorcentagemVedendor = Convert.ToString(PorcentegemVendedorInt);
                TxbParteVenderdor.Text = PorcentagemVedendor.ToString();
                PnlApagaVolta.Visible = true;
                cn.Close();


            }
            catch (Exception)
            {

                throw;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                String strSql = "insert into venda (Fk_IdFuncionario,Fk_IdCarro,QuantidadeDeCarroComprado,FkIdCliente,ValorCompra,ParteFuncionario)Values(@Fk_IdFuncionario,@Fk_IdCarro,@QuantidadeDeCarroComprado,@FkIdCliente,@ValorCompra,@ParteFuncionario)";
                cm.Parameters.Clear();
                cm.Parameters.Add("@Fk_IdFuncionario", SqlDbType.VarChar).Value = CbxIdFuncionario.SelectedValue;
                cm.Parameters.Add("@Fk_IdCarro", SqlDbType.VarChar).Value = CbxIdCarro.SelectedValue;
                cm.Parameters.Add("@QuantidadeDeCarroComprado", SqlDbType.VarChar).Value = TxbQuantidade.Text;
                cm.Parameters.Add("@FkIdCliente", SqlDbType.VarChar).Value = CxbIdCliente.SelectedValue;
                cm.Parameters.Add("@ValorCompra", SqlDbType.VarChar).Value = TxbValorVenda.Text;
                cm.Parameters.Add("@ParteFuncionario", SqlDbType.VarChar).Value = TxbParteVenderdor.Text;
                cm.CommandText = strSql;
                cm.ExecuteNonQuery();
                MessageBox.Show("Nova Compra regristrada", "Inserindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PnlApagaVolta.Visible = false;
                cn.Close();
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
