namespace BeiraRioFuncionarios.Apresentacao
{
    partial class FormQuadro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CbxEscolha = new System.Windows.Forms.ComboBox();
            this.DgvFuncionario = new System.Windows.Forms.DataGridView();
            this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataContratacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkIdCargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beiraRioBancoDeDadosDataSet = new BeiraRioFuncionarios.BeiraRioBancoDeDadosDataSet();
            this.DgvCliente = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DgvVenda = new System.Windows.Forms.DataGridView();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new BeiraRioFuncionarios.BeiraRioBancoDeDadosDataSetTableAdapters.FuncionarioTableAdapter();
            this.vendaTableAdapter = new BeiraRioFuncionarios.BeiraRioBancoDeDadosDataSetTableAdapters.VendaTableAdapter();
            this.clienteTableAdapter = new BeiraRioFuncionarios.BeiraRioBancoDeDadosDataSetTableAdapters.ClienteTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkIdFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkIdCarroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDeCarroCompradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkIdClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parteFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiraRioBancoDeDadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxEscolha
            // 
            this.CbxEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEscolha.FormattingEnabled = true;
            this.CbxEscolha.Items.AddRange(new object[] {
            "Funcionarios",
            "Clientes",
            "Vendas"});
            this.CbxEscolha.Location = new System.Drawing.Point(22, 39);
            this.CbxEscolha.Name = "CbxEscolha";
            this.CbxEscolha.Size = new System.Drawing.Size(200, 28);
            this.CbxEscolha.TabIndex = 0;
            this.CbxEscolha.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DgvFuncionario
            // 
            this.DgvFuncionario.AllowUserToAddRows = false;
            this.DgvFuncionario.AllowUserToDeleteRows = false;
            this.DgvFuncionario.AutoGenerateColumns = false;
            this.DgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncionarioDataGridViewTextBoxColumn,
            this.nomeFuncionarioDataGridViewTextBoxColumn,
            this.dataContratacaoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.fkIdCargoDataGridViewTextBoxColumn});
            this.DgvFuncionario.DataSource = this.funcionarioBindingSource;
            this.DgvFuncionario.Location = new System.Drawing.Point(22, 94);
            this.DgvFuncionario.Name = "DgvFuncionario";
            this.DgvFuncionario.ReadOnly = true;
            this.DgvFuncionario.Size = new System.Drawing.Size(542, 324);
            this.DgvFuncionario.TabIndex = 1;
            // 
            // idFuncionarioDataGridViewTextBoxColumn
            // 
            this.idFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "IdFuncionario";
            this.idFuncionarioDataGridViewTextBoxColumn.HeaderText = "Funcionario indentificação";
            this.idFuncionarioDataGridViewTextBoxColumn.Name = "idFuncionarioDataGridViewTextBoxColumn";
            this.idFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeFuncionarioDataGridViewTextBoxColumn
            // 
            this.nomeFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "NomeFuncionario";
            this.nomeFuncionarioDataGridViewTextBoxColumn.HeaderText = "Nome do Funcionario";
            this.nomeFuncionarioDataGridViewTextBoxColumn.Name = "nomeFuncionarioDataGridViewTextBoxColumn";
            this.nomeFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataContratacaoDataGridViewTextBoxColumn
            // 
            this.dataContratacaoDataGridViewTextBoxColumn.DataPropertyName = "DataContratacao";
            this.dataContratacaoDataGridViewTextBoxColumn.HeaderText = "Data da Contratação";
            this.dataContratacaoDataGridViewTextBoxColumn.Name = "dataContratacaoDataGridViewTextBoxColumn";
            this.dataContratacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkIdCargoDataGridViewTextBoxColumn
            // 
            this.fkIdCargoDataGridViewTextBoxColumn.DataPropertyName = "FkIdCargo";
            this.fkIdCargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.fkIdCargoDataGridViewTextBoxColumn.Name = "fkIdCargoDataGridViewTextBoxColumn";
            this.fkIdCargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.beiraRioBancoDeDadosDataSet;
            // 
            // beiraRioBancoDeDadosDataSet
            // 
            this.beiraRioBancoDeDadosDataSet.DataSetName = "BeiraRioBancoDeDadosDataSet";
            this.beiraRioBancoDeDadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DgvCliente
            // 
            this.DgvCliente.AllowUserToAddRows = false;
            this.DgvCliente.AllowUserToDeleteRows = false;
            this.DgvCliente.AutoGenerateColumns = false;
            this.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn});
            this.DgvCliente.DataSource = this.clienteBindingSource;
            this.DgvCliente.Location = new System.Drawing.Point(22, 94);
            this.DgvCliente.Name = "DgvCliente";
            this.DgvCliente.ReadOnly = true;
            this.DgvCliente.Size = new System.Drawing.Size(343, 324);
            this.DgvCliente.TabIndex = 2;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.beiraRioBancoDeDadosDataSet;
            // 
            // DgvVenda
            // 
            this.DgvVenda.AllowUserToAddRows = false;
            this.DgvVenda.AllowUserToDeleteRows = false;
            this.DgvVenda.AutoGenerateColumns = false;
            this.DgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.fkIdFuncionarioDataGridViewTextBoxColumn,
            this.fkIdCarroDataGridViewTextBoxColumn,
            this.quantidadeDeCarroCompradoDataGridViewTextBoxColumn,
            this.fkIdClienteDataGridViewTextBoxColumn,
            this.valorCompraDataGridViewTextBoxColumn,
            this.parteFuncionarioDataGridViewTextBoxColumn});
            this.DgvVenda.DataSource = this.vendaBindingSource;
            this.DgvVenda.Location = new System.Drawing.Point(22, 94);
            this.DgvVenda.Name = "DgvVenda";
            this.DgvVenda.ReadOnly = true;
            this.DgvVenda.Size = new System.Drawing.Size(746, 324);
            this.DgvVenda.TabIndex = 3;
            this.DgvVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.beiraRioBancoDeDadosDataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha o campo para a visualização do conteúdo";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdVenda";
            this.Column1.HeaderText = "Indentificação da venda";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // fkIdFuncionarioDataGridViewTextBoxColumn
            // 
            this.fkIdFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Fk_IdFuncionario";
            this.fkIdFuncionarioDataGridViewTextBoxColumn.HeaderText = "Funcionario";
            this.fkIdFuncionarioDataGridViewTextBoxColumn.Name = "fkIdFuncionarioDataGridViewTextBoxColumn";
            this.fkIdFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkIdCarroDataGridViewTextBoxColumn
            // 
            this.fkIdCarroDataGridViewTextBoxColumn.DataPropertyName = "Fk_IdCarro";
            this.fkIdCarroDataGridViewTextBoxColumn.HeaderText = "Carro";
            this.fkIdCarroDataGridViewTextBoxColumn.Name = "fkIdCarroDataGridViewTextBoxColumn";
            this.fkIdCarroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDeCarroCompradoDataGridViewTextBoxColumn
            // 
            this.quantidadeDeCarroCompradoDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeDeCarroComprado";
            this.quantidadeDeCarroCompradoDataGridViewTextBoxColumn.HeaderText = "quantidade comprada";
            this.quantidadeDeCarroCompradoDataGridViewTextBoxColumn.Name = "quantidadeDeCarroCompradoDataGridViewTextBoxColumn";
            this.quantidadeDeCarroCompradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkIdClienteDataGridViewTextBoxColumn
            // 
            this.fkIdClienteDataGridViewTextBoxColumn.DataPropertyName = "FkIdCliente";
            this.fkIdClienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.fkIdClienteDataGridViewTextBoxColumn.Name = "fkIdClienteDataGridViewTextBoxColumn";
            this.fkIdClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorCompraDataGridViewTextBoxColumn
            // 
            this.valorCompraDataGridViewTextBoxColumn.DataPropertyName = "ValorCompra";
            this.valorCompraDataGridViewTextBoxColumn.HeaderText = "Valor da Compra";
            this.valorCompraDataGridViewTextBoxColumn.Name = "valorCompraDataGridViewTextBoxColumn";
            this.valorCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parteFuncionarioDataGridViewTextBoxColumn
            // 
            this.parteFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "ParteFuncionario";
            this.parteFuncionarioDataGridViewTextBoxColumn.HeaderText = "Parte do Funcionario";
            this.parteFuncionarioDataGridViewTextBoxColumn.Name = "parteFuncionarioDataGridViewTextBoxColumn";
            this.parteFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.HeaderText = "Indentificação de Cliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome do Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormQuadro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeiraRioFuncionarios.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvVenda);
            this.Controls.Add(this.DgvCliente);
            this.Controls.Add(this.DgvFuncionario);
            this.Controls.Add(this.CbxEscolha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormQuadro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadro Geral";
            this.Load += new System.EventHandler(this.FormQuadro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiraRioBancoDeDadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxEscolha;
        private System.Windows.Forms.DataGridView DgvFuncionario;
        private System.Windows.Forms.DataGridView DgvCliente;
        private System.Windows.Forms.DataGridView DgvVenda;
        private BeiraRioBancoDeDadosDataSet beiraRioBancoDeDadosDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private BeiraRioBancoDeDadosDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private BeiraRioBancoDeDadosDataSetTableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private BeiraRioBancoDeDadosDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataContratacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkIdCargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkIdFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkIdCarroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDeCarroCompradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkIdClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parteFuncionarioDataGridViewTextBoxColumn;
    }
}