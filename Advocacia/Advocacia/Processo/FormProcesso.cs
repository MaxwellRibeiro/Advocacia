using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advocacia.Advogado;
using Advocacia.Comarca;
using Advocacia.Relatorio;
using Database_Class.Banco_de_Dados;
using MetroFramework;

namespace Advocacia.Processo
{
    public partial class FormProcesso : FormBase
    {
        private ProcessoBd bdProcesso = new ProcessoBd();
        List<Database_Class.Classes.Processo> ListaProcesso = new List<Database_Class.Classes.Processo>();

        public FormProcesso()
        {
            InitializeComponent();
        }

        private void FormProcesso_Load(object sender, EventArgs e)
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
            ListaProcesso = await CarregaDados();
            bindingSource.DataSource = ListaProcesso;

            AtualizarGrid();
        }

        private async Task<List<Database_Class.Classes.Processo>> CarregaDados()
        {
            return await bdProcesso.GetAll();
        }

        public override void btInserir_Click(object sender, EventArgs e)
        {
            base.btInserir_Click(sender, e);

            Enabled(false);

            var frm = new FormCadastroProcesso(null);
            frm.ShowDialog();

            if (frm.gravou)
            {
                bindingSource.Add(frm.processo);
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
                var obj = (Database_Class.Classes.Processo)Grid.CurrentRow.DataBoundItem;

                var frm = new FormCadastroProcesso(obj);
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
                var obj = (Database_Class.Classes.Processo)Grid.CurrentRow.DataBoundItem;
                var result = MetroMessageBox.Show(this, $"Deseja mesmo deletar o Processo com o Número: {obj.Numero}?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool sucesso = await bdProcesso.Delete(obj.Id);
                    if (sucesso)
                    {
                        MetroMessageBox.Show(this, "Processo deletado com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSource.Remove(obj);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Não foi possivel deletar o Processo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
