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
using Database_Class.Banco_de_Dados.Repositorio;
using Database_Class.Classes;
using MetroFramework;
using Microsoft.Office.Interop.Excel;

namespace Advocacia.Movimentacao
{
    public partial class FormCadastroMovimentacao : FormBaseCadastro
    {
        public Database_Class.Classes.Movimentacao movimentacao;
        public bool gravou;

        private object copiaMovimentacao;
        private MovimentacaoBd bdMovimentacao = new MovimentacaoBd();

        public FormCadastroMovimentacao(Database_Class.Classes.Movimentacao movimentacao)
        {
            this.movimentacao = movimentacao;
            CopiaObjeto(this.movimentacao, ref copiaMovimentacao);
            InitializeComponent();
        }

        private void Enabled(bool permitir)
        {
            gpPrincipal.Enabled = permitir;
            btSalvar.Enabled = permitir;
        }

        private void FormCadastroMovimentacao_Load(object sender, EventArgs e)
        {
            Enabled(false);

            dtData.Text = DateTime.Now.ToLongDateString();
            dtData.Value = DateTime.Now;
            CarregaCombos();
            CarregaDados();

            Enabled(true);
        }

        private async void CarregaCombos()
        {
            AndamentoProcessualBd bdAndamentoProcessual = new AndamentoProcessualBd();
            ProcessoBd bdProcesso = new ProcessoBd();

            cbAndamentoProcessual.DataSource = await bdAndamentoProcessual.GetAll();
            cbAndamentoProcessual.ValueMember = "Id";
            cbAndamentoProcessual.DisplayMember = "Situacao";

            cbProcesso.DataSource = await bdProcesso.GetAll();
            cbProcesso.ValueMember = "Id";
            cbProcesso.DisplayMember = "Numero";
        }

        private void CarregaDados()
        {
            if (movimentacao != null)
            {
                dtData.Value = movimentacao.Data;
                cbAndamentoProcessual.SelectedValue = movimentacao.IdAndamentoProcessual;
                cbProcesso.SelectedValue = movimentacao.IdProcesso;
                txtObservacao.Text = movimentacao.Observacao ?? "";
            }
        }

        private void LerDados()
        {
            

            AndamentoProcessual dtoAndamentoProcessual = (AndamentoProcessual)cbAndamentoProcessual.SelectedItem;
            Database_Class.Classes.Processo dtoProcesso = (Database_Class.Classes.Processo)cbProcesso.SelectedItem;

            if (dtoAndamentoProcessual == null || dtoProcesso == null)
            {
                return;
            }

            movimentacao.Data = dtData.Value;
            movimentacao.DataByGrid = movimentacao.Data.ToString("dd/MM/yyyy");

            movimentacao.IdAndamentoProcessual = dtoAndamentoProcessual.Id;
            movimentacao.SituacaoAndamentoProcessual = dtoAndamentoProcessual.Situacao;

            movimentacao.IdProcesso = dtoProcesso.Id;
            movimentacao.NumeroProcesso = dtoProcesso.Numero;

            movimentacao.Observacao = txtObservacao.Text != "" ? txtObservacao.Text : null;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (movimentacao == null)
            {
                Incluir();
            }
            else
            {
                Atualizar();
            }
        }

        private async void Incluir()
        {
            Enabled(false);
            try
            {
                movimentacao = new Database_Class.Classes.Movimentacao();
                LerDados();

                await bdMovimentacao.Insert(movimentacao);

                if (movimentacao.Id != 0)
                {
                    MetroMessageBox.Show(this, "Movimentação cadatrada com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    gravou = true;
                    Close();
                }
                else
                {
                    var result = MetroMessageBox.Show(this, "Não foi possivel cadastrar Movimentação, Deseja tentar novamente?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, this.Height);
                    if (result == DialogResult.Yes)
                    {
                        Incluir();
                    }
                    else
                    {
                        OriginalObjeto(copiaMovimentacao, movimentacao);
                        gravou = false;
                        Close();
                    }
                }
            }
            catch (Exception e)
            {
                OriginalObjeto(copiaMovimentacao, movimentacao);
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

                bool sucesso = await bdMovimentacao.Update(movimentacao);

                if (sucesso)
                {
                    MetroMessageBox.Show(this, "Movimentação atualizada com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    gravou = true;
                    Close();
                }
                else
                {
                    var result = MetroMessageBox.Show(this, "Não foi possivel atualizar Movimentação, Deseja tentar novamente?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, this.Height);
                    if (result == DialogResult.Yes)
                    {
                        Atualizar();
                    }
                    else
                    {
                        OriginalObjeto(copiaMovimentacao, movimentacao);
                        gravou = false;
                        Close();
                    }
                }
            }
            catch (Exception e)
            {
                OriginalObjeto(copiaMovimentacao, movimentacao);
                MetroMessageBox.Show(this, e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                gravou = false;
            }
            Enabled(true);
        }

        private void FormCadastroMovimentacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!gravou)
            {
                OriginalObjeto(copiaMovimentacao, movimentacao);
            }
        }
    }
}
