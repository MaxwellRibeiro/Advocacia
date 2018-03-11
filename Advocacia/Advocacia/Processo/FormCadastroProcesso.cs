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
using MetroFramework;

namespace Advocacia.Processo
{
    public partial class FormCadastroProcesso : FormBaseCadastro
    {
        public Database_Class.Classes.Processo processo;
        public bool gravou;

        private object copiaProcesso;
        private ProcessoBd bdProcesso = new ProcessoBd();

        public FormCadastroProcesso(Database_Class.Classes.Processo processo)
        {
            this.processo = processo;
            CopiaObjeto(this.processo, ref copiaProcesso);
            InitializeComponent();
        }

        private void Enabled(bool permitir)
        {
            gpPrincipal.Enabled = permitir;
            btSalvar.Enabled = permitir;
        }

        private void FormCadastroProcesso_Load(object sender, EventArgs e)
        {
            Enabled(false);

            CarregaCombos();
            CarregaDados();

            Enabled(true);
        }

        private async void CarregaCombos()
        {
            ClienteBd bdCliente = new ClienteBd();
            ComarcaBd bdComarca = new ComarcaBd();
            AdvogadoBd bdAdvogado = new AdvogadoBd();

            cbCliente.DataSource = await bdCliente.GetAll();
            cbCliente.ValueMember = "Id";
            cbCliente.DisplayMember = "Nome";

            cbComarca.DataSource = await bdComarca.GetAll();
            cbComarca.ValueMember = "Id";
            cbComarca.DisplayMember = "Nome";

            cbAdvogacia.DataSource = await bdAdvogado.GetAll();
            cbAdvogacia.ValueMember = "Id";
            cbAdvogacia.DisplayMember = "Nome";
        }

        private void CarregaDados()
        {
            if (processo != null)
            {
                txtNumero.Text = processo.Numero;
                cbCliente.SelectedValue = processo.IdCliente;
                cbComarca.SelectedValue = processo.IdComarca;
                cbAdvogacia.SelectedValue = processo.IdAdvogado;
            }
        }

        private void LerDados()
        {
            Database_Class.Classes.Cliente dtoCliente = (Database_Class.Classes.Cliente)cbCliente.SelectedItem;
            Database_Class.Classes.Comarca dtoComarca = (Database_Class.Classes.Comarca)cbComarca.SelectedItem;
            Database_Class.Classes.Advogado dtoAdvogado = (Database_Class.Classes.Advogado)cbAdvogacia.SelectedItem;

            if (dtoCliente == null || dtoComarca == null || dtoAdvogado == null)
            {
                return;
            }
            processo.Numero = txtNumero.Text;

            processo.IdCliente = dtoCliente.Id;
            processo.NomeCliente = dtoCliente.Nome;

            processo.IdComarca = dtoComarca.Id;
            processo.NomeComarca = dtoComarca.Nome;

            processo.IdAdvogado = dtoAdvogado.Id;
            processo.NomeAdvogado = dtoAdvogado.Nome;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!VerificarCamposObrigatorios())
            {
                return;
            }

            if (processo == null)
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
            if (txtNumero.Text == "")
            {
                errorProvider.SetError(txtNumero, "Digite um Numero");
                return false;
            }
            errorProvider.SetError(txtNumero, "");
            
            return true;
        }

        private async void Incluir()
        {
            Enabled(false);
            try
            {
                processo = new Database_Class.Classes.Processo();
                LerDados();

                await bdProcesso.Insert(processo);

                if (processo.Id != 0)
                {
                    MetroMessageBox.Show(this, "Processo cadatrado com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    gravou = true;
                    Close();
                }
                else
                {
                    var result = MetroMessageBox.Show(this, "Não foi possivel cadastrar Processo, Deseja tentar novamente?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, this.Height);
                    if (result == DialogResult.Yes)
                    {
                        Incluir();
                    }
                    else
                    {
                        OriginalObjeto(copiaProcesso, processo);
                        gravou = false;
                        Close();
                    }
                }
            }
            catch (Exception e)
            {
                OriginalObjeto(copiaProcesso, processo);
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

                bool sucesso = await bdProcesso.Update(processo);

                if (sucesso)
                {
                    MetroMessageBox.Show(this, "Processo atualizado com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    gravou = true;
                    Close();
                }
                else
                {
                    var result = MetroMessageBox.Show(this, "Não foi possivel atualizar Processo, Deseja tentar novamente?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, this.Height);
                    if (result == DialogResult.Yes)
                    {
                        Atualizar();
                    }
                    else
                    {
                        OriginalObjeto(copiaProcesso, processo);
                        gravou = false;
                        Close();
                    }
                }
            }
            catch (Exception e)
            {
                OriginalObjeto(copiaProcesso, processo);
                MetroMessageBox.Show(this, e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                gravou = false;
            }
            Enabled(true);
        }

        private void FormCadastroProcesso_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!gravou)
            {
                OriginalObjeto(copiaProcesso, processo);
            }
        }
    }
}
