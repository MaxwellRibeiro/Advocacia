using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Database_Class.Banco_de_Dados;
using MetroFramework;

namespace Advocacia.Comarca
{
    public partial class FormCadastroComarca : FormBaseCadastro
    {
        public Database_Class.Classes.Comarca comarca;
        public bool gravou;

        private object copiaComarca;
        private ComarcaBd bdComarca = new ComarcaBd();

        public FormCadastroComarca(Database_Class.Classes.Comarca comarca)
        {
            this.comarca = comarca;
            CopiaObjeto(this.comarca, ref copiaComarca);          
            InitializeComponent();
        }

        private void Enabled(bool permitir)
        {
            gpPrincipal.Enabled = permitir;
            btSalvar.Enabled = permitir;
        }

        private void FormCadastroComarca_Load(object sender, EventArgs e)
        {
            Enabled(false);

            CarregaDados();

            Enabled(true);
        }

        private void CarregaDados()
        {
            if (comarca != null)
            {
                txtNome.Text = comarca.Nome;
                txtVara.Text = comarca.Vara;
                txtTelefone.Text = comarca.Telefone ?? "";
                txtEndereco.Text = comarca.Endereco ?? "";
            }
        }

        private void LerDados()
        {
            comarca.Nome = txtNome.Text;
            comarca.Vara = txtVara.Text;
            comarca.Telefone = txtTelefone.Text != "" ? txtTelefone.Text : null;
            comarca.Endereco = txtEndereco.Text != "" ? txtEndereco.Text : null;
        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!VerificarCamposObrigatorios())
            {
                return;
            }
           

            if (comarca == null)
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

            if (txtVara.Text == "")
            {
                errorProvider.SetError(txtVara, "Digite uma Vara");
                return false;
            }
            errorProvider.SetError(txtVara, "");

            return true;
        }

        private async void Incluir()
        {
            Enabled(false);
            try
            {
                comarca = new Database_Class.Classes.Comarca();
                LerDados();

                await bdComarca.Insert(comarca);

                if (comarca.Id != 0)
                {
                    MetroMessageBox.Show(this, "Comarca cadatrada com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    gravou = true;
                    Close();
                }
                else
                {
                    var result = MetroMessageBox.Show(this, "Não foi possivel cadastrar Comarca, Deseja tentar novamente?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, this.Height);
                    if (result == DialogResult.Yes)
                    {
                        Incluir();
                    }
                    else
                    {
                        OriginalObjeto(copiaComarca, comarca);
                        gravou = false;
                        Close();
                    }
                }
            }
            catch (Exception e)
            {
                OriginalObjeto(copiaComarca, comarca);
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

                bool sucesso = await bdComarca.Update(comarca);

                if (sucesso)
                {
                    MetroMessageBox.Show(this, "Comarca atualizada com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    gravou = true;
                    Close();
                }
                else
                {
                    var result = MetroMessageBox.Show(this, "Não foi possivel atualizar Comarca, Deseja tentar novamente?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, this.Height);
                    if (result == DialogResult.Yes)
                    {
                        Atualizar();
                    }
                    else
                    {
                        OriginalObjeto(copiaComarca, comarca);
                        gravou = false;
                        Close();
                    }
                }
            }
            catch (Exception e)
            {
                OriginalObjeto(copiaComarca, comarca);
                MetroMessageBox.Show(this, e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                gravou = false;
            }     
            Enabled(true);
        }

        private void FormCadastroComarca_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!gravou)
            {
                OriginalObjeto(copiaComarca, comarca);
            }
        }
    }
}
