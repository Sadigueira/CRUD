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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

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

        // Evento Form Closed //
        private void FrmCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormCadastro = null;
        }

        // Load Formulário //
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;

            txtId.Clear();
            txtNome.Clear();
            txtBairro.Clear();
            txtEndereco.Clear();

            btnAdicionar.Enabled = true;
            btnProcurar.Enabled = true;
            btnEditar.Enabled = false;
            btnGravar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;

            epValida.Clear();
        }

        // Botão Adicionar //
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;

            txtNome.Focus();

            btnAdicionar.Enabled = false;
            btnProcurar.Enabled = false;
            btnEditar.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
        }

        // Botão Cancelar //
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;

            txtId.Clear();
            txtNome.Clear();
            txtBairro.Clear();
            txtEndereco.Clear();

            btnAdicionar.Enabled = true;
            btnProcurar.Enabled = true;
            btnEditar.Enabled = false;
            btnGravar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;

            epValida.Clear();
        }

        // Botão Procurar //
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProcurarCadastro == null)
                MeusFormularios.FormProcurarCadastro = new FrmProcurarCadastro(this);
            MeusFormularios.FormProcurarCadastro.ShowDialog();
        }

        // Validando caixas de texto //
        private bool ValidaNome()
        {
            if (txtNome.Text.Trim() == string.Empty)
            {
                epValida.SetError(txtNome, "Campo nome é obrigatório!");
                txtNome.Focus();
                return false;
            }
            return true;
        }

        // Botão Gravar //
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (this.ValidaNome())
            {
                if(string.IsNullOrEmpty(txtId.Text))
                {
                    string txtQuery = "INSERT INTO tbCrud (NOME, ENDERECO, BAIRRO) VALUES ('" + txtNome.Text + "','" + txtEndereco.Text + "','" + txtBairro.Text + "')";
                    ExecuteQuery(txtQuery);

                    if (MeusFormularios.FormConfirmacaoCadastro == null)
                        MeusFormularios.FormConfirmacaoCadastro = new FrmConfirmacaoCadastro();
                    MeusFormularios.FormConfirmacaoCadastro.ShowDialog();
                }

                else
                {
                    string txtQuery = "UPDATE tbCrud SET NOME = '" + txtNome.Text + "', ENDERECO = '" + txtEndereco.Text + "', BAIRRO = '" + txtBairro.Text + "' WHERE ID = '" + txtId.Text + "'";
                    ExecuteQuery(txtQuery);

                    if (MeusFormularios.FormConfirmacaoEdicao == null)
                        MeusFormularios.FormConfirmacaoEdicao = new FrmConfirmacaoEdicao();
                    MeusFormularios.FormConfirmacaoEdicao.ShowDialog();
                }

                txtId.Enabled = false;
                txtNome.Enabled = false;
                txtEndereco.Enabled = false;
                txtBairro.Enabled = false;

                txtId.Clear();
                txtNome.Clear();
                txtBairro.Clear();
                txtEndereco.Clear();

                btnAdicionar.Enabled = true;
                btnProcurar.Enabled = true;
                btnEditar.Enabled = false;
                btnGravar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = false;

                epValida.Clear();
            }
        }

        // Botão Editar //
        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;

            txtNome.Focus();
        }

        // Botão Excluir //
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormAvisoExclusaoCadastro == null)
                MeusFormularios.FormAvisoExclusaoCadastro = new FrmAvisoExclusaoCadastro(this);
            MeusFormularios.FormAvisoExclusaoCadastro.ShowDialog();
        }
    }
}
