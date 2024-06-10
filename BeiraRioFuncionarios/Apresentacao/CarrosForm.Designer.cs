namespace BeiraRioFuncionarios.Apresentacao
{
    partial class CarrosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarrosForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxIdCarros = new System.Windows.Forms.ComboBox();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beiraRioBancoDeDadosDataSet = new BeiraRioFuncionarios.BeiraRioBancoDeDadosDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.picGol = new System.Windows.Forms.PictureBox();
            this.carrosTableAdapter = new BeiraRioFuncionarios.BeiraRioBancoDeDadosDataSetTableAdapters.CarrosTableAdapter();
            this.PicOpala = new System.Windows.Forms.PictureBox();
            this.picCelta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiraRioBancoDeDadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicOpala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCelta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ANO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "VALOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "MARCA";
            // 
            // CbxIdCarros
            // 
            this.CbxIdCarros.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.carrosBindingSource, "IdCarro", true));
            this.CbxIdCarros.DataSource = this.carrosBindingSource;
            this.CbxIdCarros.DisplayMember = "NomeCarro";
            this.CbxIdCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxIdCarros.FormattingEnabled = true;
            this.CbxIdCarros.Location = new System.Drawing.Point(259, 22);
            this.CbxIdCarros.Name = "CbxIdCarros";
            this.CbxIdCarros.Size = new System.Drawing.Size(200, 28);
            this.CbxIdCarros.TabIndex = 4;
            this.CbxIdCarros.ValueMember = "IdCarro";
            this.CbxIdCarros.SelectedIndexChanged += new System.EventHandler(this.CbxIdCarros_SelectedIndexChanged);
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "Carros";
            this.carrosBindingSource.DataSource = this.beiraRioBancoDeDadosDataSet;
            // 
            // beiraRioBancoDeDadosDataSet
            // 
            this.beiraRioBancoDeDadosDataSet.DataSetName = "BeiraRioBancoDeDadosDataSet";
            this.beiraRioBancoDeDadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carrosBindingSource, "ano", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 26);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carrosBindingSource, "Marca", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 26);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carrosBindingSource, "Valor", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 26);
            this.textBox3.TabIndex = 7;
            // 
            // picGol
            // 
            this.picGol.Image = ((System.Drawing.Image)(resources.GetObject("picGol.Image")));
            this.picGol.Location = new System.Drawing.Point(166, 77);
            this.picGol.Name = "picGol";
            this.picGol.Size = new System.Drawing.Size(293, 211);
            this.picGol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGol.TabIndex = 8;
            this.picGol.TabStop = false;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
            // 
            // PicOpala
            // 
            this.PicOpala.Image = ((System.Drawing.Image)(resources.GetObject("PicOpala.Image")));
            this.PicOpala.Location = new System.Drawing.Point(166, 77);
            this.PicOpala.Name = "PicOpala";
            this.PicOpala.Size = new System.Drawing.Size(293, 211);
            this.PicOpala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicOpala.TabIndex = 9;
            this.PicOpala.TabStop = false;
            // 
            // picCelta
            // 
            this.picCelta.Image = ((System.Drawing.Image)(resources.GetObject("picCelta.Image")));
            this.picCelta.Location = new System.Drawing.Point(166, 77);
            this.picCelta.Name = "picCelta";
            this.picCelta.Size = new System.Drawing.Size(293, 211);
            this.picCelta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCelta.TabIndex = 10;
            this.picCelta.TabStop = false;
            // 
            // CarrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeiraRioFuncionarios.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 348);
            this.Controls.Add(this.picCelta);
            this.Controls.Add(this.PicOpala);
            this.Controls.Add(this.picGol);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CbxIdCarros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CarrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Carros à Venda";
            this.Load += new System.EventHandler(this.CarrosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiraRioBancoDeDadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicOpala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCelta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxIdCarros;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox picGol;
        private BeiraRioBancoDeDadosDataSet beiraRioBancoDeDadosDataSet;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private BeiraRioBancoDeDadosDataSetTableAdapters.CarrosTableAdapter carrosTableAdapter;
        private System.Windows.Forms.PictureBox PicOpala;
        private System.Windows.Forms.PictureBox picCelta;
    }
}