using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Simples
{
    public partial class FrmConfirmacaoCadastro : Form
    {
        public FrmConfirmacaoCadastro()
        {
            InitializeComponent();
        }

        // Evento Form Closed //
        private void FrmConfirmacaoCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormConfirmacaoCadastro = null;
        }

        // Botão Confirmar Cadastro //
        private void btnConfirmacaoCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
