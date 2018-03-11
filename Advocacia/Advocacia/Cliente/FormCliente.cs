using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advocacia.Cliente;
using Advocacia.Comarca;
using Advocacia.Relatorio;
using Database_Class.Banco_de_Dados;
using Database_Class.Classes;
using MetroFramework;

namespace Advocacia
{
    public partial class FormCliente : FormBase
    {

        private ClienteBd bdCliente = new ClienteBd();
        List<Database_Class.Classes.Cliente> ListaCliente = new List<Database_Class.Classes.Cliente>();

        public FormCliente()
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
            ListaCliente = await CarregaDados();

            if (ListaCliente != null)
            {
                foreach (var cliente in ListaCliente)
                {
                    cliente.DataNascimentoByGrid = cliente.DataNascimento.ToString("dd/MM/yyyy");
                }
            }

            bindingSource.DataSource = ListaCliente;

            AtualizarGrid();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private async Task<List<Database_Class.Classes.Cliente>> CarregaDados()
        {
            return await bdCliente.GetAll();
        }

        public override void btInserir_Click(object sender, EventArgs e)
        {
            base.btInserir_Click(sender, e);

            Enabled(false);

            var frm = new FormCadastroCliente(null);
            frm.ShowDialog();

            if (frm.gravou)
            {
                bindingSource.Add(frm.cliente);
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
                var obj = (Database_Class.Classes.Cliente)Grid.CurrentRow.DataBoundItem;

                var frm = new FormCadastroCliente(obj);
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
                var obj = (Database_Class.Classes.Cliente)Grid.CurrentRow.DataBoundItem;
                var result = MetroMessageBox.Show(this, $"Deseja mesmo deletar o Cliente com o nome: {obj.Nome}?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool sucesso = await bdCliente.Delete(obj.Id);
                    if (sucesso)
                    {
                        MetroMessageBox.Show(this, "Cliente deletado com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSource.Remove(obj);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Não foi possivel deletar o Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
