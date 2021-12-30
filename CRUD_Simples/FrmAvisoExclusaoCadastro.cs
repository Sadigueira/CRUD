using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CRUD_Simples
{
    public partial class FrmAvisoExclusaoCadastro : Form
    {
        FrmCadastro fp;

        public FrmAvisoExclusaoCadastro(FrmCadastro f)
        {
            InitializeComponent();
            fp = f;
        }

        // Evento Form Closed //
        private void FrmAvisoExclusaoCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormAvisoExclusaoCadastro = null;
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;

        //set connection
        private void SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source=dbCrud.sdb;Version=3;New=False;Compress=True;");
        }

        //set executequery
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        // Botão não confirmar //
        private void btnNaoConfirmaExclusao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Botão Confirmar Exclusão //
        private void btnConfirmacaoExclusao_Click(object sender, EventArgs e)
        {
            string txtQuery = "DELETE FROM tbCrud where ID = '" + fp.txtId.Text + "'";
            ExecuteQuery(txtQuery);
            this.Close();

            if (MeusFormularios.FormConfirmacaoExclusao == null)
                MeusFormularios.FormConfirmacaoExclusao = new FrmConfirmacaoExclusao();
            MeusFormularios.FormConfirmacaoExclusao.ShowDialog();

            fp.txtId.Enabled = false;
            fp.txtNome.Enabled = false;
            fp.txtEndereco.Enabled = false;
            fp.txtBairro.Enabled = false;

            fp.txtId.Clear();
            fp.txtNome.Clear();
            fp.txtBairro.Clear();
            fp.txtEndereco.Clear();

            fp.btnAdicionar.Enabled = true;
            fp.btnProcurar.Enabled = true;
            fp.btnEditar.Enabled = false;
            fp.btnGravar.Enabled = false;
            fp.btnExcluir.Enabled = false;
            fp.btnCancelar.Enabled = false;

            fp.epValida.Clear();
        }
    }
}
