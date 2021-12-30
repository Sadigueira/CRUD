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
    public partial class FrmProcurarCadastro : Form
    {
        FrmCadastro fp;
        public FrmProcurarCadastro(FrmCadastro f)
        {
            InitializeComponent();
            fp = f;
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private SQLiteDataReader sql_dr;

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

        // set LoadNome
        private void LoadDataNome()
        {
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string CommandText = "SELECT ID, NOME, ENDERECO, BAIRRO FROM tbCrud WHERE NOME LIKE '%" + txtProcurarCadastro.Text + "%'";
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                dgvProcurarCadastro.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql_con.Close();
            }
        }

        // set LoadID
        private void LoadDataID()
        {
            try
            {
                SetConnection();
                sql_con.Open();
                string conexao = "SELECT ID, NOME, ENDERECO, BAIRRO FROM tbCrud WHERE ID LIKE '" + fp.txtId.Text + "'";

                sql_cmd = new SQLiteCommand(conexao, sql_con);

                sql_dr = sql_cmd.ExecuteReader();

                while (sql_dr.Read())
                {
                    fp.txtNome.Text = sql_dr["NOME"].ToString();
                    fp.txtEndereco.Text = sql_dr["ENDERECO"].ToString();
                    fp.txtBairro.Text = sql_dr["BAIRRO"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql_con.Close();
            }

            fp.btnAdicionar.Enabled = false;
            fp.btnProcurar.Enabled = false;
            fp.btnEditar.Enabled = true;
            fp.btnGravar.Enabled = true;
            fp.btnExcluir.Enabled = true;
            fp.btnCancelar.Enabled = true;

        }

        // Evento Form Closed //
        private void FrmProcurarCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormProcurarCadastro = null;
        }

        // Botão Procurar //
        private void btnProcurarCadastro_Click(object sender, EventArgs e)
        {
            LoadDataNome();
        }

        // Double Click no data grid //
        private void dgvProcurarCadastro_DoubleClick(object sender, EventArgs e)
        {
            fp.txtId.Text = this.dgvProcurarCadastro.CurrentRow.Cells[0].Value.ToString();
            Close();
            LoadDataID();
        }
    }
}
