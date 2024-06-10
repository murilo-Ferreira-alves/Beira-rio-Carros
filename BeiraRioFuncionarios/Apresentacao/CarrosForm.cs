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
    public partial class CarrosForm : Form
    {
        public CarrosForm()
        {
            InitializeComponent();
        }

        private void CarrosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beiraRioBancoDeDadosDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.beiraRioBancoDeDadosDataSet.Carros);
            Carropicture();

        }
        public void Carropicture()
        {
            int Comparador = (int)CbxIdCarros.SelectedValue;
            if(Comparador == 1)
            {
                PicOpala.Visible = false;
                picGol.Visible = false;
                picCelta.Visible = false;

                PicOpala.Visible = true;
            }
            else if(Comparador == 2)
            {
                PicOpala.Visible = false;
                picGol.Visible = false;
                picCelta.Visible = false;

                picCelta.Visible = true;
            }
            else if (Comparador == 3)
            {
                PicOpala.Visible = false;
                picGol.Visible = false;
                picCelta.Visible = false;

                picGol.Visible = true;


            }


        }

        private void CbxIdCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carropicture();
        }
    }
}
