using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Simples
{
    class MeusFormularios
    {
        public static FrmPrincipal FormPrincipal { get; set; }
        public static FrmCadastro FormCadastro { get; set; }
        public static FrmProcurarCadastro FormProcurarCadastro { get; set; }
        public static FrmConfirmacaoCadastro FormConfirmacaoCadastro { get; set; }
        public static FrmAvisoExclusaoCadastro FormAvisoExclusaoCadastro { get; set; }
        public static FrmConfirmacaoExclusao FormConfirmacaoExclusao { get; set; }
        public static FrmConfirmacaoEdicao FormConfirmacaoEdicao { get; set; }
    }
}
