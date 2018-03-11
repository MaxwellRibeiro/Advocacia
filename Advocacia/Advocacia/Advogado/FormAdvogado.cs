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

namespace Advocacia.Advogado
{
    public partial class FormAdvogado : FormBase
    {
        //private List<Parametro> parametros;
        private AdvogadoBd bdAdvogado = new AdvogadoBd();
        List<Database_Class.Classes.Advogado> ListaAdvogado = new List<Database_Class.Classes.Advogado>();

        public FormAdvogado(/*List<Parametro> parametros*/)
        {
            //this.parametros = parametros;
            InitializeComponent();
        }

        private void FormAdvogado_Load(object sender, EventArgs e)
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
            ListaAdvogado = await CarregaDados();
            bindingSource.DataSource = ListaAdvogado;

            AtualizarGrid();
        }

        private async Task<List<Database_Class.Classes.Advogado>> CarregaDados()
        {
            return await bdAdvogado.GetAll();
        }

        public override void btInserir_Click(object sender, EventArgs e)
        {
            base.btInserir_Click(sender, e);

            Enabled(false);

            var frm = new FormCadastroAdvogado(null);
            frm.ShowDialog();

            if (frm.gravou)
            {
                bindingSource.Add(frm.advogado);
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
                var obj = (Database_Class.Classes.Advogado)Grid.CurrentRow.DataBoundItem;

                var frm = new FormCadastroAdvogado(obj);
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
                var obj = (Database_Class.Classes.Advogado)Grid.CurrentRow.DataBoundItem;
                var result = MetroMessageBox.Show(this, $"Deseja mesmo deletar o Advogado com o nome: {obj.Nome}?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool sucesso = await bdAdvogado.Delete(obj.Id);
                    if (sucesso)
                    {
                        MetroMessageBox.Show(this, "Advogado deletado com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSource.Remove(obj);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Não foi possivel deletar o Advogado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //if (parametros == null)
            //{
            //    return;
            //}

            //if (parametros.Count >= 2 && parametros[2].Byte)
            //{
                Exportar_Excel.ExportarExcel(Grid);
            //}
            //else
            //{
            //    MetroMessageBox.Show(this, "\nInstale o software Microsoft Excel para gerar a planilha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}
