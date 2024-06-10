namespace BeiraRioFuncionarios.Apresentacao
{
    partial class FormAddFuncionario
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
            this.TxbNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txbNumerotelefone = new System.Windows.Forms.TextBox();
            this.CbxCargo = new System.Windows.Forms.ComboBox();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beiraRioBancoDeDadosDataSet = new BeiraRioFuncionarios.BeiraRioBancoDeDadosDataSet();
            this.cargoTableAdapter = new BeiraRioFuncionarios.BeiraRioBancoDeDadosDataSetTableAdapters.CargoTableAdapter();
            this.DtpDatacontratacao = new System.Windows.Forms.DateTimePicker();
            this.BtnLocaliza = new System.Windows.Forms.Button();
            this.BtnCadastra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxFuncionarios = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new BeiraRioFuncionarios.BeiraRioBancoDeDadosDataSetTableAdapters.FuncionarioTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExclui = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiraRioBancoDeDadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxbNomeFuncionario
            // 
            this.TxbNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNomeFuncionario.Location = new System.Drawing.Point(44, 96);
            this.TxbNomeFuncionario.Name = "TxbNomeFuncionario";
            this.TxbNomeFuncionario.Size = new System.Drawing.Size(200, 26);
            this.TxbNomeFuncionario.TabIndex = 1;
            // 
            // txbNumerotelefone
            // 
            this.txbNumerotelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumerotelefone.Location = new System.Drawing.Point(44, 199);
            this.txbNumerotelefone.Name = "txbNumerotelefone";
            this.txbNumerotelefone.Size = new System.Drawing.Size(200, 26);
            this.txbNumerotelefone.TabIndex = 3;
            // 
            // CbxCargo
            // 
            this.CbxCargo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cargoBindingSource, "IdCargo", true));
            this.CbxCargo.DataSource = this.cargoBindingSource;
            this.CbxCargo.DisplayMember = "Cargo";
            this.CbxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCargo.FormattingEnabled = true;
            this.CbxCargo.Location = new System.Drawing.Point(294, 96);
            this.CbxCargo.Name = "CbxCargo";
            this.CbxCargo.Size = new System.Drawing.Size(150, 26);
            this.CbxCargo.TabIndex = 4;
            this.CbxCargo.ValueMember = "IdCargo";
            this.CbxCargo.SelectedIndexChanged += new System.EventHandler(this.CbxCargo_SelectedIndexChanged);
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataMember = "Cargo";
            this.cargoBindingSource.DataSource = this.beiraRioBancoDeDadosDataSet;
            // 
            // beiraRioBancoDeDadosDataSet
            // 
            this.beiraRioBancoDeDadosDataSet.DataSetName = "BeiraRioBancoDeDadosDataSet";
            this.beiraRioBancoDeDadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cargoTableAdapter
            // 
            this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // DtpDatacontratacao
            // 
            this.DtpDatacontratacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDatacontratacao.Location = new System.Drawing.Point(44, 285);
            this.DtpDatacontratacao.Name = "DtpDatacontratacao";
            this.DtpDatacontratacao.Size = new System.Drawing.Size(400, 26);
            this.DtpDatacontratacao.TabIndex = 5;
            this.DtpDatacontratacao.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // BtnLocaliza
            // 
            this.BtnLocaliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLocaliza.Location = new System.Drawing.Point(198, 343);
            this.BtnLocaliza.Name = "BtnLocaliza";
            this.BtnLocaliza.Size = new System.Drawing.Size(100, 50);
            this.BtnLocaliza.TabIndex = 7;
            this.BtnLocaliza.Text = "localizar";
            this.BtnLocaliza.UseVisualStyleBackColor = false;
            this.BtnLocaliza.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnCadastra
            // 
            this.BtnCadastra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastra.Location = new System.Drawing.Point(44, 343);
            this.BtnCadastra.Name = "BtnCadastra";
            this.BtnCadastra.Size = new System.Drawing.Size(100, 50);
            this.BtnCadastra.TabIndex = 8;
            this.BtnCadastra.Text = "Cadastrar";
            this.BtnCadastra.UseVisualStyleBackColor = false;
            this.BtnCadastra.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data de contratação";
            // 
            // CbxFuncionarios
            // 
            this.CbxFuncionarios.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionarioBindingSource, "IdFuncionario", true));
            this.CbxFuncionarios.DataSource = this.funcionarioBindingSource;
            this.CbxFuncionarios.DisplayMember = "NomeFuncionario";
            this.CbxFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxFuncionarios.FormattingEnabled = true;
            this.CbxFuncionarios.Location = new System.Drawing.Point(294, 197);
            this.CbxFuncionarios.Name = "CbxFuncionarios";
            this.CbxFuncionarios.Size = new System.Drawing.Size(150, 28);
            this.CbxFuncionarios.TabIndex = 13;
            this.CbxFuncionarios.ValueMember = "IdFuncionario";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.beiraRioBancoDeDadosDataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Funcionarios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cargo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Funcionários";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnExclui
            // 
            this.BtnExclui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExclui.Location = new System.Drawing.Point(344, 343);
            this.BtnExclui.Name = "BtnExclui";
            this.BtnExclui.Size = new System.Drawing.Size(100, 50);
            this.BtnExclui.TabIndex = 6;
            this.BtnExclui.Text = "Excluir";
            this.BtnExclui.UseVisualStyleBackColor = false;
            this.BtnExclui.Click += new System.EventHandler(this.BtnExclui_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(198, 399);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(100, 50);
            this.BtnVoltar.TabIndex = 17;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FormAddFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeiraRioFuncionarios.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbxFuncionarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCadastra);
            this.Controls.Add(this.BtnLocaliza);
            this.Controls.Add(this.BtnExclui);
            this.Controls.Add(this.DtpDatacontratacao);
            this.Controls.Add(this.CbxCargo);
            this.Controls.Add(this.txbNumerotelefone);
            this.Controls.Add(this.TxbNomeFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormAddFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.FormAddFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiraRioBancoDeDadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxbNomeFuncionario;
        private System.Windows.Forms.TextBox txbNumerotelefone;
        private System.Windows.Forms.ComboBox CbxCargo;
        private BeiraRioBancoDeDadosDataSet beiraRioBancoDeDadosDataSet;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private BeiraRioBancoDeDadosDataSetTableAdapters.CargoTableAdapter cargoTableAdapter;
        private System.Windows.Forms.DateTimePicker DtpDatacontratacao;
        private System.Windows.Forms.Button BtnLocaliza;
        private System.Windows.Forms.Button BtnCadastra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxFuncionarios;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private BeiraRioBancoDeDadosDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExclui;
        private System.Windows.Forms.Button BtnVoltar;
    }
}