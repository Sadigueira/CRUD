namespace CRUD_Simples
{
    partial class FrmAvisoExclusaoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAvisoExclusaoCadastro));
            this.pnlAvisoExclusaoCadastro = new System.Windows.Forms.Panel();
            this.btnNaoConfirmaExclusao = new System.Windows.Forms.Button();
            this.btnConfirmacaoExclusao = new System.Windows.Forms.Button();
            this.lblConfirmacaoCadastro = new System.Windows.Forms.Label();
            this.pnlAvisoExclusaoCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAvisoExclusaoCadastro
            // 
            this.pnlAvisoExclusaoCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlAvisoExclusaoCadastro.Controls.Add(this.btnNaoConfirmaExclusao);
            this.pnlAvisoExclusaoCadastro.Controls.Add(this.btnConfirmacaoExclusao);
            this.pnlAvisoExclusaoCadastro.Controls.Add(this.lblConfirmacaoCadastro);
            this.pnlAvisoExclusaoCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAvisoExclusaoCadastro.Location = new System.Drawing.Point(0, 0);
            this.pnlAvisoExclusaoCadastro.Name = "pnlAvisoExclusaoCadastro";
            this.pnlAvisoExclusaoCadastro.Size = new System.Drawing.Size(323, 178);
            this.pnlAvisoExclusaoCadastro.TabIndex = 0;
            // 
            // btnNaoConfirmaExclusao
            // 
            this.btnNaoConfirmaExclusao.BackColor = System.Drawing.Color.DarkRed;
            this.btnNaoConfirmaExclusao.FlatAppearance.BorderSize = 0;
            this.btnNaoConfirmaExclusao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaoConfirmaExclusao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaoConfirmaExclusao.ForeColor = System.Drawing.Color.White;
            this.btnNaoConfirmaExclusao.Location = new System.Drawing.Point(74, 94);
            this.btnNaoConfirmaExclusao.Name = "btnNaoConfirmaExclusao";
            this.btnNaoConfirmaExclusao.Size = new System.Drawing.Size(84, 31);
            this.btnNaoConfirmaExclusao.TabIndex = 6;
            this.btnNaoConfirmaExclusao.Text = "NÃO";
            this.btnNaoConfirmaExclusao.UseVisualStyleBackColor = false;
            this.btnNaoConfirmaExclusao.Click += new System.EventHandler(this.btnNaoConfirmaExclusao_Click);
            // 
            // btnConfirmacaoExclusao
            // 
            this.btnConfirmacaoExclusao.BackColor = System.Drawing.Color.Green;
            this.btnConfirmacaoExclusao.FlatAppearance.BorderSize = 0;
            this.btnConfirmacaoExclusao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmacaoExclusao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmacaoExclusao.ForeColor = System.Drawing.Color.White;
            this.btnConfirmacaoExclusao.Location = new System.Drawing.Point(173, 94);
            this.btnConfirmacaoExclusao.Name = "btnConfirmacaoExclusao";
            this.btnConfirmacaoExclusao.Size = new System.Drawing.Size(84, 31);
            this.btnConfirmacaoExclusao.TabIndex = 5;
            this.btnConfirmacaoExclusao.Text = "SIM";
            this.btnConfirmacaoExclusao.UseVisualStyleBackColor = false;
            this.btnConfirmacaoExclusao.Click += new System.EventHandler(this.btnConfirmacaoExclusao_Click);
            // 
            // lblConfirmacaoCadastro
            // 
            this.lblConfirmacaoCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacaoCadastro.ForeColor = System.Drawing.Color.White;
            this.lblConfirmacaoCadastro.Location = new System.Drawing.Point(35, 19);
            this.lblConfirmacaoCadastro.Name = "lblConfirmacaoCadastro";
            this.lblConfirmacaoCadastro.Size = new System.Drawing.Size(264, 53);
            this.lblConfirmacaoCadastro.TabIndex = 2;
            this.lblConfirmacaoCadastro.Text = "Tem certeza que deseja excluír este cadastro?";
            this.lblConfirmacaoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAvisoExclusaoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 178);
            this.Controls.Add(this.pnlAvisoExclusaoCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAvisoExclusaoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Aviso :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAvisoExclusaoCadastro_FormClosed);
            this.pnlAvisoExclusaoCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAvisoExclusaoCadastro;
        private System.Windows.Forms.Label lblConfirmacaoCadastro;
        public System.Windows.Forms.Button btnNaoConfirmaExclusao;
        public System.Windows.Forms.Button btnConfirmacaoExclusao;
    }
}