using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database_Class.Banco_de_Dados;
using Database_Class.Classes;
using MetroFramework;
using MetroFramework.Forms;

namespace Advocacia.Configuracao
{
    public partial class FormConfiguracao : MetroForm
    {
        private List<Parametro> parametros;
        private ParametroBd bdParametro = new ParametroBd();

        public FormConfiguracao(List<Parametro> parametros)
        {
            this.parametros = parametros;
            InitializeComponent();
        }

        private void FormConfiguracao_Load(object sender, EventArgs e)
        {
            Enabled(false);

            Carregar();

            Enabled(true);
        }

        private void Carregar()
        {
            if (parametros != null)
            {
                if (parametros.FirstOrDefault(P => P.Nome == "LembrarAcesso") != null)
                    tgLembrarAcesso.Checked = parametros.FirstOrDefault(P => P.Nome == "LembrarAcesso").Byte;

                if (parametros.FirstOrDefault(P => P.Nome == "Excel") != null)
                    tgExcel.Checked = parametros.FirstOrDefault(P => P.Nome == "Excel").Byte;

                if (parametros.FirstOrDefault(P => P.Nome == "Pdf") != null)
                    tgPdf.Checked = parametros.FirstOrDefault(P => P.Nome == "Pdf").Byte;
            }
            
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (parametros != null)
            {
                Atualizar();
            }
            else
            {
                MetroMessageBox.Show(this, "Não é possivel Atualizar Configurações", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
            }
        }

        private void Enabled(bool permitir)
        {
            gpLogin.Enabled = permitir;
            gpPossue.Enabled = permitir;
            gpSistema.Enabled = permitir;
            btSalvar.Enabled = permitir;
        }

        private async void Atualizar()
        {
            Enabled(false);
            try
            {
                LerDados();

                bool sucesso = await bdParametro.Update(parametros);

                if (sucesso)
                {
                    MetroMessageBox.Show(this, "Configuração atualizada com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    Close();
                }
                else
                {
                    var result = MetroMessageBox.Show(this, "Não foi possivel atualizar Configuração, Deseja tentar novamente?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, this.Height);
                    if (result == DialogResult.Yes)
                    {
                        Atualizar();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
            }
            Enabled(true);
        }

        private void LerDados()
        {
            foreach (var parametro in parametros)
            {
                if (parametro.Nome == "LembrarAcesso")
                {
                    parametro.Byte = tgLembrarAcesso.Checked;
                }

                if (parametro.Nome == "Excel")
                {
                    parametro.Byte = tgExcel.Checked;
                }

                if (parametro.Nome == "Pdf")
                {
                    parametro.Byte = tgPdf.Checked;
                }
            }
        }

        private void btNovoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btMostrarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btMudarSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
