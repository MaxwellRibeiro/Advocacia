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
using Database_Class.Classes;
using MetroFramework;

namespace Advocacia.Andamento_Processual
{
    public partial class FormAndamentoProcessual : FormBase
    {
        private AndamentoProcessualBd bdAndamentoProcessual = new AndamentoProcessualBd();
        List<Database_Class.Classes.AndamentoProcessual> ListaAndamentoProcessual = new List<Database_Class.Classes.AndamentoProcessual>();

        public FormAndamentoProcessual()
        {
            InitializeComponent();
        }

        private void FormAndamentoProcessual_Load(object sender, EventArgs e)
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
            ListaAndamentoProcessual = await CarregaDados();
            bindingSource.DataSource = ListaAndamentoProcessual;

            AtualizarGrid();
        }

        private async Task<List<Database_Class.Classes.AndamentoProcessual>> CarregaDados()
        {
            return await bdAndamentoProcessual.GetAll();
        }

        public override void btInserir_Click(object sender, EventArgs e)
        {
            base.btInserir_Click(sender, e);

            Enabled(false);

            var frm = new FormCadastroAndamentoProcessual(null);
            frm.ShowDialog();

            if (frm.gravou)
            {
                bindingSource.Add(frm.andamentoProcessual);
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
                var obj = (AndamentoProcessual)Grid.CurrentRow.DataBoundItem;

                var frm = new FormCadastroAndamentoProcessual(obj);
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
                var obj = (Database_Class.Classes.AndamentoProcessual)Grid.CurrentRow.DataBoundItem;
                var result = MetroMessageBox.Show(this, $"Deseja mesmo deletar o Andamento Processual com a situação: {obj.Situacao}?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool sucesso = await bdAndamentoProcessual.Delete(obj.Id);
                    if (sucesso)
                    {
                        MetroMessageBox.Show(this, "Andamento Processual deletado com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSource.Remove(obj);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Não foi possivel deletar o Andamento Processual", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
