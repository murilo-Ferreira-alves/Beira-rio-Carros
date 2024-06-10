namespace BeiraRioFuncionarios
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.LblCadrastro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnEntra = new System.Windows.Forms.Button();
            this.TxbCadrastro = new System.Windows.Forms.TextBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beira Rio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(260, 196);
            this.LblSenha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(74, 29);
            this.LblSenha.TabIndex = 1;
            this.LblSenha.Text = "Senha";
            // 
            // LblCadrastro
            // 
            this.LblCadrastro.AutoSize = true;
            this.LblCadrastro.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadrastro.Location = new System.Drawing.Point(260, 97);
            this.LblCadrastro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCadrastro.Name = "LblCadrastro";
            this.LblCadrastro.Size = new System.Drawing.Size(109, 29);
            this.LblCadrastro.TabIndex = 2;
            this.LblCadrastro.Text = "Cadrastro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(265, 296);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(120, 37);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEntra
            // 
            this.BtnEntra.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntra.Location = new System.Drawing.Point(465, 296);
            this.BtnEntra.Name = "BtnEntra";
            this.BtnEntra.Size = new System.Drawing.Size(120, 37);
            this.BtnEntra.TabIndex = 9;
            this.BtnEntra.Text = "Entra";
            this.BtnEntra.UseVisualStyleBackColor = false;
            this.BtnEntra.Click += new System.EventHandler(this.BtnEntra_Click);
            // 
            // TxbCadrastro
            // 
            this.TxbCadrastro.Location = new System.Drawing.Point(385, 100);
            this.TxbCadrastro.Name = "TxbCadrastro";
            this.TxbCadrastro.Size = new System.Drawing.Size(200, 26);
            this.TxbCadrastro.TabIndex = 11;
            this.TxbCadrastro.TextChanged += new System.EventHandler(this.TxbCadrastro_TextChanged);
            // 
            // TxbSenha
            // 
            this.TxbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSenha.Location = new System.Drawing.Point(385, 199);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.PasswordChar = '*';
            this.TxbSenha.Size = new System.Drawing.Size(200, 29);
            this.TxbSenha.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 426);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.TxbCadrastro);
            this.Controls.Add(this.BtnEntra);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblCadrastro);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.Label LblCadrastro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnEntra;
        private System.Windows.Forms.TextBox TxbCadrastro;
        private System.Windows.Forms.TextBox TxbSenha;
    }
}

