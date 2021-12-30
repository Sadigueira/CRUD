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
    public partial class FrmConfirmacaoEdicao : Form
    {
        public FrmConfirmacaoEdicao()
        {
            InitializeComponent();
        }

        // Evento Form Closed //
        private void FrmConfirmacaoEdicao_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormConfirmacaoEdicao = null;
        }

        // Botão Confirma //
        private void btnConfirmacaoEdicao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
