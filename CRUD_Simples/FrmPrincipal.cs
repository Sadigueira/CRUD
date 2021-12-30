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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
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

        // Load Formulário //
        private void LoadData()
        {
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string CommandText = "SELECT * FROM tbCrud ";
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                dgvPrincipal.DataSource = DT;
                txtProcurarCadastro.Clear();
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

        // Evento Form Closed //
        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormPrincipal = null;
        }

        // Botão Sair //
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Botão Adicionar //
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCadastro == null)
                MeusFormularios.FormCadastro = new FrmCadastro();
            MeusFormularios.FormCadastro.ShowDialog();
        }

        // Load Formulário //
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            txtProcurarCadastro.Focus();
            LoadData();
        }

        // Botão Recarregar //
        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            LoadData();
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
                dgvPrincipal.DataSource = DT;
                txtProcurarCadastro.Clear();
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

        // Botão Procurar //
        private void btnProcurarCadastro_Click(object sender, EventArgs e)
        {
            LoadDataNome();
        }
    }
}
