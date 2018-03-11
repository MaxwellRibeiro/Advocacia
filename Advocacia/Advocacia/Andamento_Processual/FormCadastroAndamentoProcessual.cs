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

namespace Advocacia.Andamento_Processual
{
    public partial class FormCadastroAndamentoProcessual : FormBaseCadastro
    {
        public AndamentoProcessual andamentoProcessual;
        public bool gravou;

        private object copiaAndamentoProcessual;
        private AndamentoProcessualBd bdAndamentoProcessual = new AndamentoProcessualBd();

        public FormCadastroAndamentoProcessual(AndamentoProcessual andamentoProcessual)
        {
            this.andamentoProcessual = andamentoProcessual;
            CopiaObjeto(this.andamentoProcessual, ref copiaAndamentoProcessual);
            InitializeComponent();
        }

        private void Enabled(bool permitir)
        {
            gpPrincipal.Enabled = permitir;
            btSalvar.Enabled = permitir;
        }

        private void FormCadastroAndamentoProcessual_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void CarregaDados()
        {
            if (andamentoProcessual != null)
            {
                txtSituacao.Text = andamentoProcessual.Situacao;
            }
        }

        private void LerDados()
        {
            andamentoProcessual.Situacao = txtSituacao.Text;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!VerificarCamposObrigatorios())
            {
                return;
            }


            if (andamentoProcessual == null)
            {
                Incluir();
            }
            else
            {
                Atualizar();
            }
        }

        private bool VerificarCamposObrigatorios()
        {
            if (txtSituacao.Text == "")
            {
                errorProvider.SetError(txtSituacao, "Digite uma Situação");
                return false;
            }
            errorProvider.SetError(txtSituacao, "");

            return true;
        }

        private async void Incluir()
        {
            Enabled(false);
            try
            {
                andamentoProcessual = new AndamentoProcessual();
                LerDados();

                await bdAndamentoProcessual.Insert(andamentoProcessual);

                if (andamentoProcessual.Id != 0)
                {
                    MetroMessageBox.Show(this, "Andamento Processual cadatrado com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    gravou = true;
                    Close();
                }
                else
                {
                    var result = MetroMessageBox.Show(this, "Não foi possivel cadastrar Andamento Processual, Deseja tentar novamente?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, this.Height);
                    if (result == DialogResult.Yes)
                    {
                        Incluir();
                    }
                    else
                    {
                        OriginalObjeto(copiaAndamentoProcessual, andamentoProcessual);
                        gravou = false;
                        Close();
                    }
                }
            }
            catch (Exception e)
            {
                OriginalObjeto(copiaAndamentoProcessual, andamentoProcessual);
                MetroMessageBox.Show(this, e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                gravou = false;
            }
            Enabled(true);
        }

        private async void Atualizar()
        {
            Enabled(false);
            try
            {
                LerDados();

                bool sucesso = await bdAndamentoProcessual.Update(andamentoProcessual);

                if (sucesso)
                {
                    MetroMessageBox.Show(this, "Andamento Processual atualizada com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    gravou = true;
                    Close();
                }
                else
                {
                    var result = MetroMessageBox.Show(this, "Não foi possivel atualizar Andamento Processual, Deseja tentar novamente?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, this.Height);
                    if (result == DialogResult.Yes)
                    {
                        Atualizar();
                    }
                    else
                    {
                        OriginalObjeto(copiaAndamentoProcessual, andamentoProcessual);
                        gravou = false;
                        Close();
                    }
                }
            }
            catch (Exception e)
            {
                OriginalObjeto(copiaAndamentoProcessual, andamentoProcessual);
                MetroMessageBox.Show(this, e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                gravou = false;
            }
            Enabled(true);
        }

        private void FormCadastroAndamentoProcessual_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!gravou)
            {
                OriginalObjeto(copiaAndamentoProcessual, andamentoProcessual);
            }
        }
    }
}
