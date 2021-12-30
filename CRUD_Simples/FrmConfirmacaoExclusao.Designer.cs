namespace CRUD_Simples
{
    partial class FrmConfirmacaoExclusao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirmacaoExclusao));
            this.pnlConfirmacaoCadastro = new System.Windows.Forms.Panel();
            this.btnConfirmacaoCadastro = new System.Windows.Forms.Button();
            this.lblConfirmacaoCadastro = new System.Windows.Forms.Label();
            this.pnlConfirmacaoCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConfirmacaoCadastro
            // 
            this.pnlConfirmacaoCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlConfirmacaoCadastro.Controls.Add(this.btnConfirmacaoCadastro);
            this.pnlConfirmacaoCadastro.Controls.Add(this.lblConfirmacaoCadastro);
            this.pnlConfirmacaoCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfirmacaoCadastro.Location = new System.Drawing.Point(0, 0);
            this.pnlConfirmacaoCadastro.Name = "pnlConfirmacaoCadastro";
            this.pnlConfirmacaoCadastro.Size = new System.Drawing.Size(272, 135);
            this.pnlConfirmacaoCadastro.TabIndex = 1;
            // 
            // btnConfirmacaoCadastro
            // 
            this.btnConfirmacaoCadastro.BackColor = System.Drawing.Color.Green;
            this.btnConfirmacaoCadastro.FlatAppearance.BorderSize = 0;
            this.btnConfirmacaoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmacaoCadastro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmacaoCadastro.ForeColor = System.Drawing.Color.White;
            this.btnConfirmacaoCadastro.Location = new System.Drawing.Point(94, 72);
            this.btnConfirmacaoCadastro.Name = "btnConfirmacaoCadastro";
            this.btnConfirmacaoCadastro.Size = new System.Drawing.Size(84, 31);
            this.btnConfirmacaoCadastro.TabIndex = 4;
            this.btnConfirmacaoCadastro.Text = "OK!";
            this.btnConfirmacaoCadastro.UseVisualStyleBackColor = false;
            this.btnConfirmacaoCadastro.Click += new System.EventHandler(this.btnConfirmacaoCadastro_Click);
            // 
            // lblConfirmacaoCadastro
            // 
            this.lblConfirmacaoCadastro.AutoSize = true;
            this.lblConfirmacaoCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacaoCadastro.ForeColor = System.Drawing.Color.White;
            this.lblConfirmacaoCadastro.Location = new System.Drawing.Point(11, 27);
            this.lblConfirmacaoCadastro.Name = "lblConfirmacaoCadastro";
            this.lblConfirmacaoCadastro.Size = new System.Drawing.Size(258, 21);
            this.lblConfirmacaoCadastro.TabIndex = 1;
            this.lblConfirmacaoCadastro.Text = "Cadastro excluído com sucesso!";
            // 
            // FrmConfirmacaoExclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 135);
            this.Controls.Add(this.pnlConfirmacaoCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfirmacaoExclusao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Sucesso :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConfirmacaoExclusao_FormClosed);
            this.pnlConfirmacaoCadastro.ResumeLayout(false);
            this.pnlConfirmacaoCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfirmacaoCadastro;
        public System.Windows.Forms.Button btnConfirmacaoCadastro;
        private System.Windows.Forms.Label lblConfirmacaoCadastro;
    }
}