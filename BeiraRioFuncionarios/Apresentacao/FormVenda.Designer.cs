namespace BeiraRioFuncionarios.Apresentacao
{
    partial class FormVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenda));
            this.CbxIdFuncionario = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beiraRioBancoDeDadosDataSet = new BeiraRioFuncionarios.BeiraRioBancoDeDadosDataSet();
            this.CbxIdCargo = new System.Windows.Forms.ComboBox();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CbxIdCarro = new System.Windows.Forms.ComboBox();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CxbIdCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxbQuantidade = new System.Windows.Forms.TextBox();
            this.TxbParteVenderdor = new System.Windows.Forms.TextBox();
            this.TxbValorVenda = new System.Windows.Forms.TextBox();
            this.PnlApagaVolta = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.funcionarioTableAdapter = new BeiraRioFuncionarios.BeiraRioBancoDeDadosDataSetTableAdapters.FuncionarioTableAdapter();
            this.cargoTableAdapter = new BeiraRioFuncionarios.BeiraRioBancoDeDadosDataSetTableAdapters.CargoTableAdapter();
            this.carrosTableAdapter = new BeiraRioFuncionarios.BeiraRioBancoDeDadosDataSetTableAdapters.CarrosTableAdapter();
            this.clienteTableAdapter = new BeiraRioFuncionarios.BeiraRioBancoDeDadosDataSetTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiraRioBancoDeDadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.PnlApagaVolta.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxIdFuncionario
            // 
            this.CbxIdFuncionario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionarioBindingSource, "IdFuncionario", true));
            this.CbxIdFuncionario.DataSource = this.funcionarioBindingSource;
            this.CbxIdFuncionario.DisplayMember = "NomeFuncionario";
            this.CbxIdFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxIdFuncionario.FormattingEnabled = true;
            this.CbxIdFuncionario.Location = new System.Drawing.Point(27, 66);
            this.CbxIdFuncionario.Name = "CbxIdFuncionario";
            this.CbxIdFuncionario.Size = new System.Drawing.Size(250, 28);
            this.CbxIdFuncionario.TabIndex = 1;
            this.CbxIdFuncionario.ValueMember = "IdFuncionario";
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
            // CbxIdCargo
            // 
            this.CbxIdCargo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cargoBindingSource, "IdCargo", true));
            this.CbxIdCargo.DataSource = this.cargoBindingSource;
            this.CbxIdCargo.DisplayMember = "Cargo";
            this.CbxIdCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxIdCargo.FormattingEnabled = true;
            this.CbxIdCargo.Location = new System.Drawing.Point(27, 141);
            this.CbxIdCargo.Name = "CbxIdCargo";
            this.CbxIdCargo.Size = new System.Drawing.Size(250, 28);
            this.CbxIdCargo.TabIndex = 2;
            this.CbxIdCargo.ValueMember = "IdCargo";
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataMember = "Cargo";
            this.cargoBindingSource.DataSource = this.beiraRioBancoDeDadosDataSet;
            // 
            // CbxIdCarro
            // 
            this.CbxIdCarro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.carrosBindingSource, "IdCarro", true));
            this.CbxIdCarro.DataSource = this.carrosBindingSource;
            this.CbxIdCarro.DisplayMember = "NomeCarro";
            this.CbxIdCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxIdCarro.FormattingEnabled = true;
            this.CbxIdCarro.Location = new System.Drawing.Point(27, 213);
            this.CbxIdCarro.Name = "CbxIdCarro";
            this.CbxIdCarro.Size = new System.Drawing.Size(250, 28);
            this.CbxIdCarro.TabIndex = 3;
            this.CbxIdCarro.ValueMember = "IdCarro";
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "Carros";
            this.carrosBindingSource.DataSource = this.beiraRioBancoDeDadosDataSet;
            // 
            // CxbIdCliente
            // 
            this.CxbIdCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "IdCliente", true));
            this.CxbIdCliente.DataSource = this.clienteBindingSource;
            this.CxbIdCliente.DisplayMember = "NomeCliente";
            this.CxbIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CxbIdCliente.FormattingEnabled = true;
            this.CxbIdCliente.Location = new System.Drawing.Point(418, 66);
            this.CxbIdCliente.Name = "CxbIdCliente";
            this.CxbIdCliente.Size = new System.Drawing.Size(250, 28);
            this.CxbIdCliente.TabIndex = 4;
            this.CxbIdCliente.ValueMember = "IdCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.beiraRioBancoDeDadosDataSet;
            // 
            // TxbQuantidade
            // 
            this.TxbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbQuantidade.Location = new System.Drawing.Point(418, 143);
            this.TxbQuantidade.Name = "TxbQuantidade";
            this.TxbQuantidade.Size = new System.Drawing.Size(100, 26);
            this.TxbQuantidade.TabIndex = 5;
            // 
            // TxbParteVenderdor
            // 
            this.TxbParteVenderdor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbParteVenderdor.Location = new System.Drawing.Point(212, 88);
            this.TxbParteVenderdor.Name = "TxbParteVenderdor";
            this.TxbParteVenderdor.Size = new System.Drawing.Size(180, 26);
            this.TxbParteVenderdor.TabIndex = 6;
            // 
            // TxbValorVenda
            // 
            this.TxbValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbValorVenda.Location = new System.Drawing.Point(0, 88);
            this.TxbValorVenda.Name = "TxbValorVenda";
            this.TxbValorVenda.Size = new System.Drawing.Size(180, 26);
            this.TxbValorVenda.TabIndex = 7;
            // 
            // PnlApagaVolta
            // 
            this.PnlApagaVolta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlApagaVolta.BackgroundImage")));
            this.PnlApagaVolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlApagaVolta.Controls.Add(this.TxbValorVenda);
            this.PnlApagaVolta.Controls.Add(this.TxbParteVenderdor);
            this.PnlApagaVolta.Controls.Add(this.label5);
            this.PnlApagaVolta.Controls.Add(this.label6);
            this.PnlApagaVolta.Location = new System.Drawing.Point(294, 251);
            this.PnlApagaVolta.Name = "PnlApagaVolta";
            this.PnlApagaVolta.Size = new System.Drawing.Size(407, 188);
            this.PnlApagaVolta.TabIndex = 8;
            this.PnlApagaVolta.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor de venda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(209, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Porcentagem do vendedor";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar Venda";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(27, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Confirmar Compra";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cargo do vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carros";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantidade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Venda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(415, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Cliente";
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // cargoTableAdapter
            // 
            this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PnlApagaVolta);
            this.Controls.Add(this.TxbQuantidade);
            this.Controls.Add(this.CxbIdCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxIdCarro);
            this.Controls.Add(this.CbxIdCargo);
            this.Controls.Add(this.CbxIdFuncionario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Venda Cadrastro";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiraRioBancoDeDadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.PnlApagaVolta.ResumeLayout(false);
            this.PnlApagaVolta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CbxIdFuncionario;
        private System.Windows.Forms.ComboBox CbxIdCargo;
        private System.Windows.Forms.ComboBox CbxIdCarro;
        private System.Windows.Forms.ComboBox CxbIdCliente;
        private System.Windows.Forms.TextBox TxbQuantidade;
        private System.Windows.Forms.TextBox TxbParteVenderdor;
        private System.Windows.Forms.TextBox TxbValorVenda;
        private System.Windows.Forms.Panel PnlApagaVolta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private BeiraRioBancoDeDadosDataSet beiraRioBancoDeDadosDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private BeiraRioBancoDeDadosDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private BeiraRioBancoDeDadosDataSetTableAdapters.CargoTableAdapter cargoTableAdapter;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private BeiraRioBancoDeDadosDataSetTableAdapters.CarrosTableAdapter carrosTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private BeiraRioBancoDeDadosDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}