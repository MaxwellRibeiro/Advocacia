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

namespace Advocacia.Advogado
{
    public partial class FormCadastroAdvogado : FormBaseCadastro
    {
        public Database_Class.Classes.Advogado advogado;
        public bool gravou;

        private object copiaAdvogado;
        private AdvogadoBd bdAdvogado = new AdvogadoBd();

        public FormCadastroAdvogado(Database_Class.Classes.Advogado advogado)
        {
            this.advogado = advogado;
            CopiaObjeto(this.advogado, ref copiaAdvogado);
            InitializeComponent();
        }

        private void Enabled(bool permitir)
        {
            gpPrincipal.Enabled = permitir;
            btSalvar.Enabled = permitir;
        }

        private void FormCadastroAdvogado_Load(object sender, EventArgs e)
        {
            Enabled(false);

            CarregaDados();

            Enabled(true);
        }

        private void CarregaDados()
        {
            if (advogado != null)
            {
                txtNome.Text = advogado.Nome;
                txtOAB.Text = advogado.OAB ?? "";
                txtCpf.Text = advogado.Cpf ?? "";
                txtTelefone.Text = advogado.Telefone ?? "";
                txtEmail.Text = advogado.Email ?? "";
            }
        }

        private void LerDados()
        {
            advogado.Nome = txtNome.Text;
            advogado.OAB = txtOAB.Text != "" ? txtOAB.Text : null;
            advogado.Cpf = txtCpf.Text != "" ? txtCpf.Text : null;
            advogado.Telefone = txtTelefone.Text != "" ? txtTelefone.Text : null;
            advogado.Email = txtEmail.Text != "" ? txtEmail.Text : null;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!VerificarCamposObrigatorios())
            {
                return;
            }


            if (advogado == null)
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
            if (txtNome.Text == "")
            {
                errorProvider.SetError(txtNome, "Digite um Nome");
                return false;
            }
            errorProvider.SetError(txtNome, "");

            return true;
        }

        private async void Incluir()
        {
            Enabled(false);
            try
            {
                advogado = new Database_Class.Classes.Advogado();
                LerDados();

                await bdAdvogado.Insert(advogado);

                if (advogado.Id != 0)
                {
                    MetroMessageBox.Show(this, "Advogado cadatrado com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    gravou = true;
                    Close();
                }
                else
                {
                    var result = MetroMessageBox.Show(this, "Não foi possivel cadastrar Advogado, Deseja tentar novamente?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, this.Height);
                    if (result == DialogResult.Yes)
                    {
                        Incluir();
                    }
                    else
                    {
                        OriginalObjeto(copiaAdvogado, advogado);
                        gravou = false;
                        Close();
                    }
                }
            }
            catch (Exception e)
            {
                OriginalObjeto(copiaAdvogado, advogado);
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

                bool sucesso = await bdAdvogado.Update(advogado);

                if (sucesso)
                {
                    MetroMessageBox.Show(this, "Advogado atualizado com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    gravou = true;
                    Close();
                }
                else
                {
                    var result = MetroMessageBox.Show(this, "Não foi possivel atualizar Advogado, Deseja tentar novamente?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, this.Height);
                    if (result == DialogResult.Yes)
                    {
                        Atualizar();
                    }
                    else
                    {
                        OriginalObjeto(copiaAdvogado, advogado);
                        gravou = false;
                        Close();
                    }
                }
            }
            catch (Exception e)
            {
                OriginalObjeto(copiaAdvogado, advogado);
                MetroMessageBox.Show(this, e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                gravou = false;
            }
            Enabled(true);
        }

        private void FormCadastroAdvogado_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!gravou)
            {
                OriginalObjeto(copiaAdvogado, advogado);
            }
        }
    }
}
