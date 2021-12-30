namespace CRUD_Simples
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDesenvolvedor = new System.Windows.Forms.Label();
            this.btnProcurarCadastro = new System.Windows.Forms.Button();
            this.txtProcurarCadastro = new System.Windows.Forms.TextBox();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCrud = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlPrincipal.Controls.Add(this.pictureBox1);
            this.pnlPrincipal.Controls.Add(this.lblDesenvolvedor);
            this.pnlPrincipal.Controls.Add(this.btnProcurarCadastro);
            this.pnlPrincipal.Controls.Add(this.txtProcurarCadastro);
            this.pnlPrincipal.Controls.Add(this.btnRecarregar);
            this.pnlPrincipal.Controls.Add(this.btnSair);
            this.pnlPrincipal.Controls.Add(this.btnAdicionar);
            this.pnlPrincipal.Controls.Add(this.dgvPrincipal);
            this.pnlPrincipal.Controls.Add(this.lblCrud);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(633, 468);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRUD_Simples.Properties.Resources.S_Traço_Diminuido;
            this.pictureBox1.Location = new System.Drawing.Point(571, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblDesenvolvedor
            // 
            this.lblDesenvolvedor.AutoSize = true;
            this.lblDesenvolvedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesenvolvedor.ForeColor = System.Drawing.Color.White;
            this.lblDesenvolvedor.Location = new System.Drawing.Point(365, 420);
            this.lblDesenvolvedor.Name = "lblDesenvolvedor";
            this.lblDesenvolvedor.Size = new System.Drawing.Size(200, 20);
            this.lblDesenvolvedor.TabIndex = 7;
            this.lblDesenvolvedor.Text = "Developed by: Sadigueira";
            // 
            // btnProcurarCadastro
            // 
            this.btnProcurarCadastro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarCadastro.Location = new System.Drawing.Point(419, 82);
            this.btnProcurarCadastro.Name = "btnProcurarCadastro";
            this.btnProcurarCadastro.Size = new System.Drawing.Size(84, 31);
            this.btnProcurarCadastro.TabIndex = 2;
            this.btnProcurarCadastro.Text = "Procurar";
            this.btnProcurarCadastro.UseVisualStyleBackColor = true;
            this.btnProcurarCadastro.Click += new System.EventHandler(this.btnProcurarCadastro_Click);
            // 
            // txtProcurarCadastro
            // 
            this.txtProcurarCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurarCadastro.Location = new System.Drawing.Point(35, 86);
            this.txtProcurarCadastro.Name = "txtProcurarCadastro";
            this.txtProcurarCadastro.Size = new System.Drawing.Size(368, 27);
            this.txtProcurarCadastro.TabIndex = 1;
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecarregar.Location = new System.Drawing.Point(124, 416);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(88, 31);
            this.btnRecarregar.TabIndex = 5;
            this.btnRecarregar.Text = "Recarregar";
            this.btnRecarregar.UseVisualStyleBackColor = true;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(218, 416);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(84, 31);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(34, 416);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(84, 31);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.ENDERECO,
            this.BAIRRO});
            this.dgvPrincipal.Location = new System.Drawing.Point(34, 134);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.Size = new System.Drawing.Size(565, 261);
            this.dgvPrincipal.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 155;
            // 
            // ENDERECO
            // 
            this.ENDERECO.DataPropertyName = "ENDERECO";
            this.ENDERECO.HeaderText = "Endereço";
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.ReadOnly = true;
            this.ENDERECO.Width = 155;
            // 
            // BAIRRO
            // 
            this.BAIRRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BAIRRO.DataPropertyName = "BAIRRO";
            this.BAIRRO.HeaderText = "Bairro";
            this.BAIRRO.Name = "BAIRRO";
            this.BAIRRO.ReadOnly = true;
            // 
            // lblCrud
            // 
            this.lblCrud.AutoSize = true;
            this.lblCrud.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrud.ForeColor = System.Drawing.Color.White;
            this.lblCrud.Location = new System.Drawing.Point(31, 41);
            this.lblCrud.Name = "lblCrud";
            this.lblCrud.Size = new System.Drawing.Size(152, 24);
            this.lblCrud.TabIndex = 0;
            this.lblCrud.Text = "CRUD SIMPLES";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 468);
            this.Controls.Add(this.pnlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: CRUD :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.Label lblCrud;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO;
        private System.Windows.Forms.Button btnRecarregar;
        public System.Windows.Forms.Button btnProcurarCadastro;
        public System.Windows.Forms.TextBox txtProcurarCadastro;
        private System.Windows.Forms.Label lblDesenvolvedor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

