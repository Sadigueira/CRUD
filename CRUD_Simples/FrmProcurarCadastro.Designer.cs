namespace CRUD_Simples
{
    partial class FrmProcurarCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProcurarCadastro));
            this.pnlProcurarCadastro = new System.Windows.Forms.Panel();
            this.dgvProcurarCadastro = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcurarCadastro = new System.Windows.Forms.Button();
            this.txtProcurarCadastro = new System.Windows.Forms.TextBox();
            this.pnlProcurarCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurarCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProcurarCadastro
            // 
            this.pnlProcurarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlProcurarCadastro.Controls.Add(this.dgvProcurarCadastro);
            this.pnlProcurarCadastro.Controls.Add(this.btnProcurarCadastro);
            this.pnlProcurarCadastro.Controls.Add(this.txtProcurarCadastro);
            this.pnlProcurarCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProcurarCadastro.Location = new System.Drawing.Point(0, 0);
            this.pnlProcurarCadastro.Name = "pnlProcurarCadastro";
            this.pnlProcurarCadastro.Size = new System.Drawing.Size(540, 450);
            this.pnlProcurarCadastro.TabIndex = 0;
            // 
            // dgvProcurarCadastro
            // 
            this.dgvProcurarCadastro.AllowUserToAddRows = false;
            this.dgvProcurarCadastro.AllowUserToDeleteRows = false;
            this.dgvProcurarCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcurarCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.ENDERECO,
            this.BAIRRO});
            this.dgvProcurarCadastro.Location = new System.Drawing.Point(12, 89);
            this.dgvProcurarCadastro.Name = "dgvProcurarCadastro";
            this.dgvProcurarCadastro.ReadOnly = true;
            this.dgvProcurarCadastro.Size = new System.Drawing.Size(516, 349);
            this.dgvProcurarCadastro.TabIndex = 12;
            this.dgvProcurarCadastro.DoubleClick += new System.EventHandler(this.dgvProcurarCadastro_DoubleClick);
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
            this.NOME.Width = 138;
            // 
            // ENDERECO
            // 
            this.ENDERECO.DataPropertyName = "ENDERECO";
            this.ENDERECO.HeaderText = "Endereço";
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.ReadOnly = true;
            this.ENDERECO.Width = 138;
            // 
            // BAIRRO
            // 
            this.BAIRRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BAIRRO.DataPropertyName = "BAIRRO";
            this.BAIRRO.HeaderText = "Bairro";
            this.BAIRRO.Name = "BAIRRO";
            this.BAIRRO.ReadOnly = true;
            // 
            // btnProcurarCadastro
            // 
            this.btnProcurarCadastro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarCadastro.Location = new System.Drawing.Point(425, 36);
            this.btnProcurarCadastro.Name = "btnProcurarCadastro";
            this.btnProcurarCadastro.Size = new System.Drawing.Size(84, 31);
            this.btnProcurarCadastro.TabIndex = 11;
            this.btnProcurarCadastro.Text = "Procurar";
            this.btnProcurarCadastro.UseVisualStyleBackColor = true;
            this.btnProcurarCadastro.Click += new System.EventHandler(this.btnProcurarCadastro_Click);
            // 
            // txtProcurarCadastro
            // 
            this.txtProcurarCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurarCadastro.Location = new System.Drawing.Point(37, 36);
            this.txtProcurarCadastro.Name = "txtProcurarCadastro";
            this.txtProcurarCadastro.Size = new System.Drawing.Size(368, 27);
            this.txtProcurarCadastro.TabIndex = 10;
            // 
            // FrmProcurarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.pnlProcurarCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProcurarCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Procurar Cadastro :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProcurarCadastro_FormClosed);
            this.pnlProcurarCadastro.ResumeLayout(false);
            this.pnlProcurarCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurarCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProcurarCadastro;
        public System.Windows.Forms.TextBox txtProcurarCadastro;
        public System.Windows.Forms.Button btnProcurarCadastro;
        private System.Windows.Forms.DataGridView dgvProcurarCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO;
    }
}