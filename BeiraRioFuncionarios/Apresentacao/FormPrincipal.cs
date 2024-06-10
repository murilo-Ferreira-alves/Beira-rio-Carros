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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenda FV = new FormVenda();
            FV.ShowDialog();    
        }

        private void cadrastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void novoCadrastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void excluirCadrastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sssToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarrosForm cf = new CarrosForm();
            cf.ShowDialog();    
        }

        private void cadrastroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoCadastroDeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadasteMe cad = new FormCadasteMe();
            cad.Show();
        }

        private void excluirCadastroDeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ExCadastroForm Ex = new ExCadastroForm();
            Ex.Show();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroClineteForm Ccf = new CadastroClineteForm();
            Ccf.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void novoFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddFuncionario FAF = new FormAddFuncionario();
            FAF.ShowDialog();
        }

        private void excluirFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quadroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuadro FQ = new FormQuadro();
            FQ.ShowDialog();
        }
    }
}
