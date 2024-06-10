namespace BeiraRioFuncionarios.Apresentacao
{
    partial class FormCadasteMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadasteMe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbCriarCadrastro = new System.Windows.Forms.TextBox();
            this.TxbCriarSenha = new System.Windows.Forms.TextBox();
            this.BtnCadrastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cadrastro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // TxbCriarCadrastro
            // 
            this.TxbCriarCadrastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbCriarCadrastro.Location = new System.Drawing.Point(58, 50);
            this.TxbCriarCadrastro.Name = "TxbCriarCadrastro";
            this.TxbCriarCadrastro.Size = new System.Drawing.Size(250, 26);
            this.TxbCriarCadrastro.TabIndex = 4;
            this.TxbCriarCadrastro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxbCriarSenha
            // 
            this.TxbCriarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbCriarSenha.Location = new System.Drawing.Point(59, 165);
            this.TxbCriarSenha.Name = "TxbCriarSenha";
            this.TxbCriarSenha.Size = new System.Drawing.Size(250, 26);
            this.TxbCriarSenha.TabIndex = 5;
            // 
            // BtnCadrastrar
            // 
            this.BtnCadrastrar.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadrastrar.Location = new System.Drawing.Point(111, 247);
            this.BtnCadrastrar.Name = "BtnCadrastrar";
            this.BtnCadrastrar.Size = new System.Drawing.Size(120, 45);
            this.BtnCadrastrar.TabIndex = 7;
            this.BtnCadrastrar.Text = "Cadastrar";
            this.BtnCadrastrar.UseVisualStyleBackColor = true;
            this.BtnCadrastrar.Click += new System.EventHandler(this.BtnCadrastrar_Click);
            // 
            // FormCadasteMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 361);
            this.Controls.Add(this.BtnCadrastrar);
            this.Controls.Add(this.TxbCriarSenha);
            this.Controls.Add(this.TxbCriarCadrastro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormCadasteMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadrastro ";
            this.Load += new System.EventHandler(this.FormCadaste_Me_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbCriarCadrastro;
        private System.Windows.Forms.TextBox TxbCriarSenha;
        private System.Windows.Forms.Button BtnCadrastrar;
    }
}