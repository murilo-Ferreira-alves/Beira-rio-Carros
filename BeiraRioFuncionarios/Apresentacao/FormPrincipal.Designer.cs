namespace BeiraRioFuncionarios.Apresentacao
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadrastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCadrastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCadastroDeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCadastroDeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCadrastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sssToolStripMenuItem,
            this.cadrastroToolStripMenuItem,
            this.quadroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sssToolStripMenuItem
            // 
            this.sssToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.sssToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sssToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.sssToolStripMenuItem.Name = "sssToolStripMenuItem";
            this.sssToolStripMenuItem.Size = new System.Drawing.Size(102, 36);
            this.sssToolStripMenuItem.Text = "Vendas";
            this.sssToolStripMenuItem.Click += new System.EventHandler(this.sssToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(155, 36);
            this.vendaToolStripMenuItem.Text = "venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(155, 36);
            this.estoqueToolStripMenuItem.Text = "Carros";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // cadrastroToolStripMenuItem
            // 
            this.cadrastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCadrastroToolStripMenuItem,
            this.excluirCadrastroToolStripMenuItem,
            this.funcionarioToolStripMenuItem});
            this.cadrastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadrastroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cadrastroToolStripMenuItem.Name = "cadrastroToolStripMenuItem";
            this.cadrastroToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.cadrastroToolStripMenuItem.Text = "Cadrastro";
            // 
            // novoCadrastroToolStripMenuItem
            // 
            this.novoCadrastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCadastroDeLoginToolStripMenuItem,
            this.excluirCadastroDeLoginToolStripMenuItem});
            this.novoCadrastroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.novoCadrastroToolStripMenuItem.Name = "novoCadrastroToolStripMenuItem";
            this.novoCadrastroToolStripMenuItem.Size = new System.Drawing.Size(213, 36);
            this.novoCadrastroToolStripMenuItem.Text = "Login";
            this.novoCadrastroToolStripMenuItem.Click += new System.EventHandler(this.novoCadrastroToolStripMenuItem_Click);
            // 
            // novoCadastroDeLoginToolStripMenuItem
            // 
            this.novoCadastroDeLoginToolStripMenuItem.Name = "novoCadastroDeLoginToolStripMenuItem";
            this.novoCadastroDeLoginToolStripMenuItem.Size = new System.Drawing.Size(347, 36);
            this.novoCadastroDeLoginToolStripMenuItem.Text = "novo cadastro de login";
            this.novoCadastroDeLoginToolStripMenuItem.Click += new System.EventHandler(this.novoCadastroDeLoginToolStripMenuItem_Click);
            // 
            // excluirCadastroDeLoginToolStripMenuItem
            // 
            this.excluirCadastroDeLoginToolStripMenuItem.Name = "excluirCadastroDeLoginToolStripMenuItem";
            this.excluirCadastroDeLoginToolStripMenuItem.Size = new System.Drawing.Size(347, 36);
            this.excluirCadastroDeLoginToolStripMenuItem.Text = "Excluir cadastro de login";
            this.excluirCadastroDeLoginToolStripMenuItem.Click += new System.EventHandler(this.excluirCadastroDeLoginToolStripMenuItem_Click);
            // 
            // excluirCadrastroToolStripMenuItem
            // 
            this.excluirCadrastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem});
            this.excluirCadrastroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.excluirCadrastroToolStripMenuItem.Name = "excluirCadrastroToolStripMenuItem";
            this.excluirCadrastroToolStripMenuItem.Size = new System.Drawing.Size(213, 36);
            this.excluirCadrastroToolStripMenuItem.Text = "Cliente";
            this.excluirCadrastroToolStripMenuItem.Click += new System.EventHandler(this.excluirCadrastroToolStripMenuItem_Click);
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 36);
            this.novoClienteToolStripMenuItem.Text = "Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoFuncionarioToolStripMenuItem});
            this.funcionarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(213, 36);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            // 
            // novoFuncionarioToolStripMenuItem
            // 
            this.novoFuncionarioToolStripMenuItem.Name = "novoFuncionarioToolStripMenuItem";
            this.novoFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(213, 36);
            this.novoFuncionarioToolStripMenuItem.Text = "Funcionario";
            this.novoFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.novoFuncionarioToolStripMenuItem_Click);
            // 
            // quadroToolStripMenuItem
            // 
            this.quadroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quadroToolStripMenuItem.Name = "quadroToolStripMenuItem";
            this.quadroToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.quadroToolStripMenuItem.Text = "Quadro";
            this.quadroToolStripMenuItem.Click += new System.EventHandler(this.quadroToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de funções";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadrastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCadrastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirCadrastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCadastroDeLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirCadastroDeLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadroToolStripMenuItem;
    }
}