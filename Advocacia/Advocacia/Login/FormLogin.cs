using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advocacia.Comarca;
using Database_Class.Banco_de_Dados;
using MaterialSkin;
using MetroFramework;

namespace Advocacia.Login
{
    public partial class FormLogin : MaterialSkin.Controls.MaterialForm
    {
        private LoginBd bdLogin = new LoginBd();
        private Database_Class.Classes.Login login;
        private List<Database_Class.Classes.Login> logins;
        private string Dica_de_Senha;
        public bool Logado;

        public FormLogin()
        {
            InitializeComponent();
            DesignerLogin();
        }

        private void DesignerLogin()
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.LightBlue900, Primary.LightBlue900, Accent.LightBlue700, TextShade.WHITE);
        }

        private async void FormLogin_Load(object sender, EventArgs e)
        {
            Logado = false;
            Dica_de_Senha = "";
            if (!await BuscaLogins())
            {
                MetroMessageBox.Show(this, "\nNão é possivel fazer o Login!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                Logado = false;
            }       
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (VerificarCamposObrigatorios())
            {
                Logar();
            }
            else
            {
                Logado = false;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (VerificarCamposObrigatorios())
                {
                    Logar();
                }
                else
                {
                    Logado = false;
                }
            }  
        }

        private void Logar()
        {
            LerDados();

            if (logins != null)
            {
                var objUsuario = logins.FirstOrDefault(L => L.Usuario == login.Usuario);
                if (objUsuario != null)
                {
                    if (objUsuario.Senha == login.Senha)
                    {
                        Logado = true;
                        Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "\nSenha Errada!\n\nVocê pode visualizar a dica de senha clicando em Relembrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                        Dica_de_Senha = objUsuario.DicaSenha;
                        Logado = false;
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "\nLogin Errado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    Logado = false;
                }
            }
            else
            {
                MetroMessageBox.Show(this, "\nNenhum Login cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                Logado = false;
            }
        }

        private void LerDados()
        {
            login = new Database_Class.Classes.Login
            {
                Usuario = txtLogin.Text,
                Senha = txtSenha.Text
            };

        }

        private bool VerificarCamposObrigatorios()
        {
            if (txtLogin.Text == "")
            {
                errorProvider.SetError(txtLogin, "Digite um Login");
                return false;
            }
            errorProvider.SetError(txtLogin, "");

            if (txtSenha.Text == "")
            {
                errorProvider.SetError(txtSenha, "Digite uma Senha");
                return false;
            }
            errorProvider.SetError(txtSenha, "");

            return true;
        }

        private async Task<bool> BuscaLogins()
        {
            try
            {
                logins = new List<Database_Class.Classes.Login>();
                logins = await bdLogin.GetAll();

                return true;
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);

                return false;
            }
            
        }

        private void lblRelembrar_Click(object sender, EventArgs e)
        {
            if (Dica_de_Senha != "")
            {
                MetroMessageBox.Show(this,"\n"+"Dica: "+Dica_de_Senha, "Dica de Senha:", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
            }
            else
            {
                MetroMessageBox.Show(this, "\nSem Dica de Senha!", "Dica de Senha:", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
