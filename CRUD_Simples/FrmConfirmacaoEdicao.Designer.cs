namespace CRUD_Simples
{
    partial class FrmConfirmacaoEdicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirmacaoEdicao));
            this.pnlConfirmacaoEdicao = new System.Windows.Forms.Panel();
            this.btnConfirmacaoEdicao = new System.Windows.Forms.Button();
            this.lblConfirmacaoEdicao = new System.Windows.Forms.Label();
            this.pnlConfirmacaoEdicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConfirmacaoEdicao
            // 
            this.pnlConfirmacaoEdicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlConfirmacaoEdicao.Controls.Add(this.btnConfirmacaoEdicao);
            this.pnlConfirmacaoEdicao.Controls.Add(this.lblConfirmacaoEdicao);
            this.pnlConfirmacaoEdicao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfirmacaoEdicao.Location = new System.Drawing.Point(0, 0);
            this.pnlConfirmacaoEdicao.Name = "pnlConfirmacaoEdicao";
            this.pnlConfirmacaoEdicao.Size = new System.Drawing.Size(280, 135);
            this.pnlConfirmacaoEdicao.TabIndex = 1;
            // 
            // btnConfirmacaoEdicao
            // 
            this.btnConfirmacaoEdicao.BackColor = System.Drawing.Color.Green;
            this.btnConfirmacaoEdicao.FlatAppearance.BorderSize = 0;
            this.btnConfirmacaoEdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmacaoEdicao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmacaoEdicao.ForeColor = System.Drawing.Color.White;
            this.btnConfirmacaoEdicao.Location = new System.Drawing.Point(94, 72);
            this.btnConfirmacaoEdicao.Name = "btnConfirmacaoEdicao";
            this.btnConfirmacaoEdicao.Size = new System.Drawing.Size(84, 31);
            this.btnConfirmacaoEdicao.TabIndex = 4;
            this.btnConfirmacaoEdicao.Text = "OK!";
            this.btnConfirmacaoEdicao.UseVisualStyleBackColor = false;
            this.btnConfirmacaoEdicao.Click += new System.EventHandler(this.btnConfirmacaoEdicao_Click);
            // 
            // lblConfirmacaoEdicao
            // 
            this.lblConfirmacaoEdicao.AutoSize = true;
            this.lblConfirmacaoEdicao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacaoEdicao.ForeColor = System.Drawing.Color.White;
            this.lblConfirmacaoEdicao.Location = new System.Drawing.Point(3, 28);
            this.lblConfirmacaoEdicao.Name = "lblConfirmacaoEdicao";
            this.lblConfirmacaoEdicao.Size = new System.Drawing.Size(277, 21);
            this.lblConfirmacaoEdicao.TabIndex = 1;
            this.lblConfirmacaoEdicao.Text = "Cadastro atualizado com sucesso!";
            // 
            // FrmConfirmacaoEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 135);
            this.Controls.Add(this.pnlConfirmacaoEdicao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfirmacaoEdicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Sucesso :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConfirmacaoEdicao_FormClosed);
            this.pnlConfirmacaoEdicao.ResumeLayout(false);
            this.pnlConfirmacaoEdicao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfirmacaoEdicao;
        public System.Windows.Forms.Button btnConfirmacaoEdicao;
        private System.Windows.Forms.Label lblConfirmacaoEdicao;
    }
}