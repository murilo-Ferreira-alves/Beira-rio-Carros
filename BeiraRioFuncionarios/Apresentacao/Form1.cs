using BeiraRioFuncionarios.Apresentacao;
using BeiraRioFuncionarios.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BeiraRioFuncionarios
{
    public partial class Form1 : Form
    {




        public Form1()
        {

            InitializeComponent();

        }
        public void limpaCampo1()
        {
            TxbCadrastro.Text = "";
            TxbSenha.Text = "";

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();    
        }
            
        private void BtnCadrasteMe_Click(object sender, EventArgs e)
        {
            FormCadasteMe cad = new FormCadasteMe();
            cad.Show();
        }

        private void BtnEntra_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(); 
            controle.Acessar(TxbCadrastro.Text,TxbSenha.Text);
            if (controle.Mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormPrincipal f = new FormPrincipal();
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Cadastro ou senha estão incorretos", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpaCampo1(); 
                }
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxbCadrastro_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
