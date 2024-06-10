using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeiraRioFuncionarios.Apresentacao
{
    public partial class FormQuadro : Form
    {
        public FormQuadro()
        {
            InitializeComponent();
        }

        private void FormQuadro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beiraRioBancoDeDadosDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.beiraRioBancoDeDadosDataSet.Cliente);
            // TODO: This line of code loads data into the 'beiraRioBancoDeDadosDataSet.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.beiraRioBancoDeDadosDataSet.Venda);
            // TODO: This line of code loads data into the 'beiraRioBancoDeDadosDataSet.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.beiraRioBancoDeDadosDataSet.Funcionario);
            
            invisibleDgv();

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void invisibleDgv()
        {
            DgvCliente.Visible = false;
            DgvVenda.Visible = false;
            DgvFuncionario.Visible = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxEscolha.Text == "Funcionarios")
            {
                invisibleDgv();
                DgvFuncionario.Visible=true;
            }
            else if (CbxEscolha.Text == "Clientes")
            {
                invisibleDgv();
                DgvCliente.Visible=true;
            }
            else if (CbxEscolha.Text == "Vendas")
            {
                invisibleDgv();
                DgvVenda.Visible=true;
            }
        }
    }
}
