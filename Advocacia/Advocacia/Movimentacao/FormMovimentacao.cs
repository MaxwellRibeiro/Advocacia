using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advocacia.Comarca;
using Advocacia.Relatorio;
using Database_Class.Banco_de_Dados;
using MetroFramework;

namespace Advocacia.Movimentacao
{
    public partial class FormMovimentacao : FormBase
    {
        private MovimentacaoBd bdMovimentacao = new MovimentacaoBd();
        List<Database_Class.Classes.Movimentacao> ListaMovimentacao = new List<Database_Class.Classes.Movimentacao>();

        public FormMovimentacao()
        {
            InitializeComponent();
        }

        private void FormMovimentacao_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        public void AtualizarGrid()
        {
            Grid.Update();
            Grid.Refresh();
        }

        private async void CarregaGrid()
        {
            ListaMovimentacao = await CarregaDados();

            if (ListaMovimentacao != null)
            {
                foreach (var movimentacao in ListaMovimentacao)
                {
                    movimentacao.DataByGrid = movimentacao.Data.ToString("dd/MM/yyyy");
                }
            }

            bindingSource.DataSource = ListaMovimentacao;

            AtualizarGrid();
        }

        private async Task<List<Database_Class.Classes.Movimentacao>> CarregaDados()
        {
            return await bdMovimentacao.GetAll();
        }

        public override void btInserir_Click(object sender, EventArgs e)
        {
            base.btInserir_Click(sender, e);

            Enabled(false);

            var frm = new FormCadastroMovimentacao(null);
            frm.ShowDialog();

            if (frm.gravou)
            {
                bindingSource.Add(frm.movimentacao);
            }

            frm.Dispose();

            AtualizarGrid();

            Enabled(true);
        }

        public override void btAlterar_Click(object sender, EventArgs e)
        {
            base.btAlterar_Click(sender, e);

            Enabled(false);
            if (Grid.CurrentRow != null)
            {
                var obj = (Database_Class.Classes.Movimentacao)Grid.CurrentRow.DataBoundItem;

                var frm = new FormCadastroMovimentacao(obj);
                frm.ShowDialog();
                frm.Dispose();

                AtualizarGrid();
            }

            Enabled(true);
        }

        public async override void btExcluir_Click(object sender, EventArgs e)
        {
            base.btExcluir_Click(sender, e);

            Enabled(false);
            if (Grid.CurrentRow != null)
            {
                var obj = (Database_Class.Classes.Movimentacao)Grid.CurrentRow.DataBoundItem;
                var result = MetroMessageBox.Show(this, $"Deseja mesmo deletar a Movimentação com a Data: {obj.DataByGrid}?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool sucesso = await bdMovimentacao.Delete(obj.Id);
                    if (sucesso)
                    {
                        MetroMessageBox.Show(this, "Movimentação deletada com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSource.Remove(obj);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Não foi possivel deletar a Movimentação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                AtualizarGrid();
            }

            Enabled(true);
        }

        private void Enabled(bool permitir)
        {
            Enabled_Opcao(permitir);
            Grid.Enabled = permitir;
        }

        public override void btExcel_Click(object sender, EventArgs e)
        {
            base.btExcel_Click(sender, e);

            Exportar_Excel.ExportarExcel(Grid);
        }
    }
}
