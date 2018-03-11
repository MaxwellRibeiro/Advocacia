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
using Database_Class.Enum;
using MetroFramework;

namespace Advocacia.Cliente
{
    public partial class FormCadastroCliente : FormBaseCadastro
    {

        public Database_Class.Classes.Cliente cliente;
        public bool gravou;
        private object copiaCliente;
        private ClienteBd bdCliente = new ClienteBd();

        public FormCadastroCliente(Database_Class.Classes.Cliente cliente)
        {
            this.cliente = cliente;
            CopiaObjeto(this.cliente, ref copiaCliente);
            InitializeComponent();
        }

        private void Enabled(bool permitir)
        {
            gpPrincipal.Enabled = permitir;
            btSalvar.Enabled = permitir;
        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            Enabled(false);
            dtDataNascimento.Text = DateTime.Now.ToLongDateString();
            dtDataNascimento.Value = DateTime.Now;
            CarregaCombo();
            CarregaDados();
            Enabled(true);
        }

        private void CarregaCombo()
        {
            cbEstadoCivil.DataSource = Enum.GetNames(typeof (EnumByCliente.EstadoCivil));
        }

        private void CarregaDados()
        {
            if (cliente != null)
            {
                txtNome.Text = cliente.Nome;
                dtDataNascimento.Value = cliente.DataNascimento;
                txtTelefone.Text = cliente.Telefone;
                txtCpf.Text = cliente.Cpf;
                txtProfissao.Text = cliente.Profissao;
                txtEndereco.Text = cliente.Endereco;
                txtRg.Text = cliente.Rg ?? "";
                txtNomePai.Text = cliente.NomePai ?? "";
                txtNomeMae.Text = cliente.NomeMae ?? "";
                txtEmail.Text = cliente.Email ?? "";

                cbEstadoCivil.SelectedIndex = (int)cliente.EstadoCivil;
            }
        }

        private void LerDados()
        {
            cliente.Nome = txtNome.Text;
            cliente.DataNascimento = dtDataNascimento.Value;
            cliente.DataNascimentoByGrid = cliente.DataNascimento.ToString("dd/MM/yyyy");
            cliente.Telefone = txtTelefone.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Profissao = txtProfissao.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Rg = txtRg.Text != "" ? txtRg.Text : null;
            cliente.NomePai = txtNomePai.Text != "" ? txtNomePai.Text : null;
            cliente.NomeMae = txtNomeMae.Text != "" ? txtNomeMae.Text : null;
            cliente.Email = txtEmail.Text != "" ? txtEmail.Text : null;

            cliente.EstadoCivil = (EnumByCliente.EstadoCivil)Enum.Parse(typeof(EnumByCliente.EstadoCivil), cbEstadoCivil.SelectedValue.ToString());
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!VerificarCamposObrigatorios())
            {
                return;
            }

            if (cliente == null)
            {
                Incluir();
            }
            else
            {
                Atualizar();
            }
        }

        public bool VerificarCamposObrigatorios()
        {
            if (txtNome.Text == "")
            {
                errorProvider.SetError(txtNome, "Digite um Nome");
                return false;
            }
            errorProvider.SetError(txtNome, "");

            if (txtProfissao.Text == "")
            {
                errorProvider.SetError(txtProfissao, "Digite sua Profissão");
                return false;
            }
            errorProvider.SetError(txtProfissao, "");

            if (txtEndereco.Text == "")
            {
                errorProvider.SetError(txtEndereco, "Digite seu Endereço");
                return false;
            }
            errorProvider.SetError(txtEndereco, "");

            if (txtCpf.Text == "")
            {
                errorProvider.SetError(txtCpf, "Digite seu Cpf");
                return false;
            }
            errorProvider.SetError(txtCpf, "");

            if (txtTelefone.Text == "")
            {
                errorProvider.SetError(txtTelefone, "Digite o Telefone");
                return false;
            }
            errorProvider.SetError(txtTelefone, "");
           
            return true;
        }


        private async void Incluir()
        {
            Enabled(false);
            try
            {
                cliente = new Database_Class.Classes.Cliente();
                LerDados();

                await bdCliente.Insert(cliente);

                if (cliente.Id != 0)
                {
                    MetroMessageBox.Show(this, "Cliente cadatrado com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    gravou = true;
                    Close();
                }
                else
                {
                    var result = MetroMessageBox.Show(this, "Não foi possivel cadastrar Cliente, Deseja tentar novamente?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, this.Height);
                    if (result == DialogResult.Yes)
                    {
                        Incluir();
                    }
                    else
                    {
                        OriginalObjeto(copiaCliente, cliente);
                        gravou = false;
                        Close();
                    }
                }
            }
            catch (Exception e)
            {
                OriginalObjeto(copiaCliente, cliente);
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

                bool sucesso = await bdCliente.Update(cliente);

                if (sucesso)
                {
                    MetroMessageBox.Show(this, "Cliente atualizado com sucesso", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    gravou = true;
                    Close();
                }
                else
                {
                    var result = MetroMessageBox.Show(this, "Não foi possivel atualizar Cliente, Deseja tentar novamente?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, this.Height);
                    if (result == DialogResult.Yes)
                    {
                        Atualizar();
                    }
                    else
                    {
                        OriginalObjeto(copiaCliente, cliente);
                        gravou = false;
                        Close();
                    }
                }
            }
            catch (Exception e)
            {
                OriginalObjeto(copiaCliente, cliente);
                MetroMessageBox.Show(this, e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                gravou = false;
            }
            Enabled(true);
        }


        private void FormCadastroCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!gravou)
            {
                OriginalObjeto(copiaCliente, cliente);
            }
        }

        private void dtDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            if (dtDataNascimento.Value > DateTime.Now)
            {
                MetroMessageBox.Show(this, "Data Inválida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                dtDataNascimento.Value = DateTime.Now;
            }
        }
    }
}
