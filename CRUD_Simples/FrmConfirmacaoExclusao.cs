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
    public partial class FrmConfirmacaoExclusao : Form
    {
        public FrmConfirmacaoExclusao()
        {
            InitializeComponent();
        }

        // Evento Form Closed //
        private void FrmConfirmacaoExclusao_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormConfirmacaoExclusao = null;
        }

        // Botão Confirma Exclusão //
        private void btnConfirmacaoCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
