using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advocacia.Relatorio;
using Database_Class.Banco_de_Dados;
using MetroFramework;

namespace Advocacia.Comarca
{
    public partial class FormComarca : FormBase
    {
        private ComarcaBd bdComarca = new ComarcaBd();
        List<Database_Class.Classes.Comarca> ListaComarca = new List<Database_Class.Classes.Comarca>();

        public FormComarca()
        {
            InitializeComponent();
        }

        public void AtualizarGrid()
        {
            Grid.Update();
            Grid.Refresh();
        }

        private async void CarregaGrid()
        {
            ListaComarca = await CarregaDados();
            bindingSource.DataSource = ListaComarca;

            AtualizarGrid();
        }

        private void FormComarca_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private async Task<List<Database_Class.Classes.Comarca>> CarregaDados()
        {
            return await bdComarca.GetAll();
        }

        public override void btInserir_Click(object sender, EventArgs e)
        {
            base.btInserir_Click(sender, e);

            Enabled(false);

            var frm = new FormCadastroComarca(null);
            frm.ShowDialog();

            if (frm.gravou)
            {
                bindingSource.Add(frm.comarca);
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
                var obj = (Database_Class.Classes.Comarca)Grid.CurrentRow.DataBoundItem;

                var frm = new FormCadastroComarca(obj);
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
                var obj = (Database_Class.Classes.Comarca)Grid.CurrentRow.DataBoundItem;
                var result = MetroMessageBox.Show(this, $"Deseja mesmo deletar a Comarca com o nome: {obj.Nome}?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool sucesso = await bdComarca.Delete(obj.Id);
                    if (sucesso)
                    {
                        MetroMessageBox.Show(this, "Comarca deletada com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSource.Remove(obj);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Não foi possivel deletar a Comarca", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
