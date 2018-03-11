namespace Advocacia.Cliente
{
    partial class FormCadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gpPrincipal = new System.Windows.Forms.GroupBox();
            this.gpPais = new System.Windows.Forms.GroupBox();
            this.lblNomePai = new MetroFramework.Controls.MetroLabel();
            this.txtNomePai = new MetroFramework.Controls.MetroTextBox();
            this.txtNomeMae = new MetroFramework.Controls.MetroTextBox();
            this.lblNomeMae = new MetroFramework.Controls.MetroLabel();
            this.gpPessoal = new System.Windows.Forms.GroupBox();
            this.cbEstadoCivil = new MetroFramework.Controls.MetroComboBox();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.dtDataNascimento = new MetroFramework.Controls.MetroDateTime();
            this.lblTelefone = new MetroFramework.Controls.MetroLabel();
            this.txtTelefone = new MetroFramework.Controls.MetroTextBox();
            this.lblEstadoCivil = new MetroFramework.Controls.MetroLabel();
            this.lblEndereco = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblDataNascimento = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtEndereco = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.lblCpf = new MetroFramework.Controls.MetroLabel();
            this.txtRg = new MetroFramework.Controls.MetroTextBox();
            this.txtCpf = new MetroFramework.Controls.MetroTextBox();
            this.lblRg = new MetroFramework.Controls.MetroLabel();
            this.lblProfissao = new MetroFramework.Controls.MetroLabel();
            this.txtProfissao = new MetroFramework.Controls.MetroTextBox();
            this.btSalvar = new MetroFramework.Controls.MetroButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpPrincipal.SuspendLayout();
            this.gpPais.SuspendLayout();
            this.gpPessoal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gpPrincipal
            // 
            this.gpPrincipal.Controls.Add(this.gpPais);
            this.gpPrincipal.Controls.Add(this.gpPessoal);
            this.gpPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpPrincipal.Location = new System.Drawing.Point(23, 63);
            this.gpPrincipal.Name = "gpPrincipal";
            this.gpPrincipal.Size = new System.Drawing.Size(963, 288);
            this.gpPrincipal.TabIndex = 10;
            this.gpPrincipal.TabStop = false;
            // 
            // gpPais
            // 
            this.gpPais.Controls.Add(this.lblNomePai);
            this.gpPais.Controls.Add(this.txtNomePai);
            this.gpPais.Controls.Add(this.txtNomeMae);
            this.gpPais.Controls.Add(this.lblNomeMae);
            this.gpPais.Location = new System.Drawing.Point(7, 213);
            this.gpPais.Name = "gpPais";
            this.gpPais.Size = new System.Drawing.Size(950, 61);
            this.gpPais.TabIndex = 28;
            this.gpPais.TabStop = false;
            this.gpPais.Text = " Nome dos Pais";
            // 
            // lblNomePai
            // 
            this.lblNomePai.AutoSize = true;
            this.lblNomePai.Location = new System.Drawing.Point(12, 19);
            this.lblNomePai.Name = "lblNomePai";
            this.lblNomePai.Size = new System.Drawing.Size(74, 19);
            this.lblNomePai.TabIndex = 18;
            this.lblNomePai.Text = "Nome Pai :";
            // 
            // txtNomePai
            // 
            // 
            // 
            // 
            this.txtNomePai.CustomButton.Image = null;
            this.txtNomePai.CustomButton.Location = new System.Drawing.Point(349, 1);
            this.txtNomePai.CustomButton.Name = "";
            this.txtNomePai.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomePai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomePai.CustomButton.TabIndex = 1;
            this.txtNomePai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomePai.CustomButton.UseSelectable = true;
            this.txtNomePai.CustomButton.Visible = false;
            this.txtNomePai.Lines = new string[0];
            this.txtNomePai.Location = new System.Drawing.Point(92, 19);
            this.txtNomePai.MaxLength = 32767;
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.PasswordChar = '\0';
            this.txtNomePai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomePai.SelectedText = "";
            this.txtNomePai.SelectionLength = 0;
            this.txtNomePai.SelectionStart = 0;
            this.txtNomePai.ShortcutsEnabled = true;
            this.txtNomePai.Size = new System.Drawing.Size(371, 23);
            this.txtNomePai.TabIndex = 0;
            this.txtNomePai.UseSelectable = true;
            this.txtNomePai.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomePai.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNomeMae
            // 
            // 
            // 
            // 
            this.txtNomeMae.CustomButton.Image = null;
            this.txtNomeMae.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.txtNomeMae.CustomButton.Name = "";
            this.txtNomeMae.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeMae.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeMae.CustomButton.TabIndex = 1;
            this.txtNomeMae.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeMae.CustomButton.UseSelectable = true;
            this.txtNomeMae.CustomButton.Visible = false;
            this.txtNomeMae.Lines = new string[0];
            this.txtNomeMae.Location = new System.Drawing.Point(558, 19);
            this.txtNomeMae.MaxLength = 32767;
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.PasswordChar = '\0';
            this.txtNomeMae.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeMae.SelectedText = "";
            this.txtNomeMae.SelectionLength = 0;
            this.txtNomeMae.SelectionStart = 0;
            this.txtNomeMae.ShortcutsEnabled = true;
            this.txtNomeMae.Size = new System.Drawing.Size(381, 23);
            this.txtNomeMae.TabIndex = 1;
            this.txtNomeMae.UseSelectable = true;
            this.txtNomeMae.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeMae.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNomeMae
            // 
            this.lblNomeMae.AutoSize = true;
            this.lblNomeMae.Location = new System.Drawing.Point(469, 19);
            this.lblNomeMae.Name = "lblNomeMae";
            this.lblNomeMae.Size = new System.Drawing.Size(83, 19);
            this.lblNomeMae.TabIndex = 20;
            this.lblNomeMae.Text = "Nome Mãe :";
            // 
            // gpPessoal
            // 
            this.gpPessoal.Controls.Add(this.cbEstadoCivil);
            this.gpPessoal.Controls.Add(this.lblNome);
            this.gpPessoal.Controls.Add(this.dtDataNascimento);
            this.gpPessoal.Controls.Add(this.lblTelefone);
            this.gpPessoal.Controls.Add(this.txtTelefone);
            this.gpPessoal.Controls.Add(this.lblEstadoCivil);
            this.gpPessoal.Controls.Add(this.lblEndereco);
            this.gpPessoal.Controls.Add(this.txtEmail);
            this.gpPessoal.Controls.Add(this.lblDataNascimento);
            this.gpPessoal.Controls.Add(this.lblEmail);
            this.gpPessoal.Controls.Add(this.txtEndereco);
            this.gpPessoal.Controls.Add(this.txtNome);
            this.gpPessoal.Controls.Add(this.lblCpf);
            this.gpPessoal.Controls.Add(this.txtRg);
            this.gpPessoal.Controls.Add(this.txtCpf);
            this.gpPessoal.Controls.Add(this.lblRg);
            this.gpPessoal.Controls.Add(this.lblProfissao);
            this.gpPessoal.Controls.Add(this.txtProfissao);
            this.gpPessoal.Location = new System.Drawing.Point(6, 19);
            this.gpPessoal.Name = "gpPessoal";
            this.gpPessoal.Size = new System.Drawing.Size(951, 188);
            this.gpPessoal.TabIndex = 27;
            this.gpPessoal.TabStop = false;
            this.gpPessoal.Text = " Informações Pessoais ";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.ItemHeight = 23;
            this.cbEstadoCivil.Location = new System.Drawing.Point(692, 145);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(248, 29);
            this.cbEstadoCivil.TabIndex = 8;
            this.cbEstadoCivil.UseSelectable = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(34, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome :";
            // 
            // dtDataNascimento
            // 
            this.dtDataNascimento.Location = new System.Drawing.Point(691, 23);
            this.dtDataNascimento.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataNascimento.Name = "dtDataNascimento";
            this.dtDataNascimento.Size = new System.Drawing.Size(249, 29);
            this.dtDataNascimento.TabIndex = 4;
            this.dtDataNascimento.ValueChanged += new System.EventHandler(this.dtDataNascimento_ValueChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(621, 120);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(64, 19);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone :";
            // 
            // txtTelefone
            // 
            // 
            // 
            // 
            this.txtTelefone.CustomButton.Image = null;
            this.txtTelefone.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtTelefone.CustomButton.Name = "";
            this.txtTelefone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefone.CustomButton.TabIndex = 1;
            this.txtTelefone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefone.CustomButton.UseSelectable = true;
            this.txtTelefone.CustomButton.Visible = false;
            this.txtTelefone.Lines = new string[0];
            this.txtTelefone.Location = new System.Drawing.Point(691, 116);
            this.txtTelefone.MaxLength = 32767;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.ShortcutsEnabled = true;
            this.txtTelefone.Size = new System.Drawing.Size(249, 23);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.UseSelectable = true;
            this.txtTelefone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(602, 150);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(83, 19);
            this.lblEstadoCivil.TabIndex = 24;
            this.lblEstadoCivil.Text = "Estado Civil :";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(16, 116);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(71, 19);
            this.lblEndereco.TabIndex = 6;
            this.lblEndereco.Text = "Endereço :";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(371, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(93, 84);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(393, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(550, 26);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(135, 19);
            this.lblDataNascimento.TabIndex = 2;
            this.lblDataNascimento.Text = "Data de Nascimento :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(39, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 19);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email :";
            // 
            // txtEndereco
            // 
            // 
            // 
            // 
            this.txtEndereco.CustomButton.Image = null;
            this.txtEndereco.CustomButton.Location = new System.Drawing.Point(337, 2);
            this.txtEndereco.CustomButton.Name = "";
            this.txtEndereco.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.txtEndereco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEndereco.CustomButton.TabIndex = 1;
            this.txtEndereco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEndereco.CustomButton.UseSelectable = true;
            this.txtEndereco.CustomButton.Visible = false;
            this.txtEndereco.Lines = new string[0];
            this.txtEndereco.Location = new System.Drawing.Point(93, 116);
            this.txtEndereco.MaxLength = 32767;
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.SelectionLength = 0;
            this.txtEndereco.SelectionStart = 0;
            this.txtEndereco.ShortcutsEnabled = true;
            this.txtEndereco.Size = new System.Drawing.Size(393, 58);
            this.txtEndereco.TabIndex = 3;
            this.txtEndereco.UseSelectable = true;
            this.txtEndereco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEndereco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(371, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(93, 26);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(393, 23);
            this.txtNome.TabIndex = 0;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(648, 91);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(37, 19);
            this.lblCpf.TabIndex = 10;
            this.lblCpf.Text = "Cpf :";
            // 
            // txtRg
            // 
            // 
            // 
            // 
            this.txtRg.CustomButton.Image = null;
            this.txtRg.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtRg.CustomButton.Name = "";
            this.txtRg.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRg.CustomButton.TabIndex = 1;
            this.txtRg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRg.CustomButton.UseSelectable = true;
            this.txtRg.CustomButton.Visible = false;
            this.txtRg.Lines = new string[0];
            this.txtRg.Location = new System.Drawing.Point(691, 58);
            this.txtRg.MaxLength = 32767;
            this.txtRg.Name = "txtRg";
            this.txtRg.PasswordChar = '\0';
            this.txtRg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRg.SelectedText = "";
            this.txtRg.SelectionLength = 0;
            this.txtRg.SelectionStart = 0;
            this.txtRg.ShortcutsEnabled = true;
            this.txtRg.Size = new System.Drawing.Size(249, 23);
            this.txtRg.TabIndex = 5;
            this.txtRg.UseSelectable = true;
            this.txtRg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCpf
            // 
            // 
            // 
            // 
            this.txtCpf.CustomButton.Image = null;
            this.txtCpf.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtCpf.CustomButton.Name = "";
            this.txtCpf.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCpf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCpf.CustomButton.TabIndex = 1;
            this.txtCpf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCpf.CustomButton.UseSelectable = true;
            this.txtCpf.CustomButton.Visible = false;
            this.txtCpf.Lines = new string[0];
            this.txtCpf.Location = new System.Drawing.Point(692, 87);
            this.txtCpf.MaxLength = 32767;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCpf.SelectedText = "";
            this.txtCpf.SelectionLength = 0;
            this.txtCpf.SelectionStart = 0;
            this.txtCpf.ShortcutsEnabled = true;
            this.txtCpf.Size = new System.Drawing.Size(248, 23);
            this.txtCpf.TabIndex = 6;
            this.txtCpf.UseSelectable = true;
            this.txtCpf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCpf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(653, 58);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(32, 19);
            this.lblRg.TabIndex = 14;
            this.lblRg.Text = "Rg :";
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(18, 55);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(69, 19);
            this.lblProfissao.TabIndex = 12;
            this.lblProfissao.Text = "Profissão :";
            // 
            // txtProfissao
            // 
            // 
            // 
            // 
            this.txtProfissao.CustomButton.Image = null;
            this.txtProfissao.CustomButton.Location = new System.Drawing.Point(371, 1);
            this.txtProfissao.CustomButton.Name = "";
            this.txtProfissao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProfissao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProfissao.CustomButton.TabIndex = 1;
            this.txtProfissao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProfissao.CustomButton.UseSelectable = true;
            this.txtProfissao.CustomButton.Visible = false;
            this.txtProfissao.Lines = new string[0];
            this.txtProfissao.Location = new System.Drawing.Point(93, 55);
            this.txtProfissao.MaxLength = 32767;
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.PasswordChar = '\0';
            this.txtProfissao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProfissao.SelectedText = "";
            this.txtProfissao.SelectionLength = 0;
            this.txtProfissao.SelectionStart = 0;
            this.txtProfissao.ShortcutsEnabled = true;
            this.txtProfissao.Size = new System.Drawing.Size(393, 23);
            this.txtProfissao.TabIndex = 1;
            this.txtProfissao.UseSelectable = true;
            this.txtProfissao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProfissao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(911, 362);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseSelectable = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 402);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gpPrincipal);
            this.Name = "FormCadastroCliente";
            this.Text = "Cadastro Cliente";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCadastroCliente_FormClosed);
            this.Load += new System.EventHandler(this.FormCadastroCliente_Load);
            this.gpPrincipal.ResumeLayout(false);
            this.gpPais.ResumeLayout(false);
            this.gpPais.PerformLayout();
            this.gpPessoal.ResumeLayout(false);
            this.gpPessoal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpPrincipal;
        private MetroFramework.Controls.MetroTextBox txtEndereco;
        private MetroFramework.Controls.MetroLabel lblEndereco;
        private MetroFramework.Controls.MetroButton btSalvar;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox txtNomeMae;
        private MetroFramework.Controls.MetroLabel lblNomeMae;
        private MetroFramework.Controls.MetroTextBox txtRg;
        private MetroFramework.Controls.MetroLabel lblRg;
        private MetroFramework.Controls.MetroTextBox txtNomePai;
        private MetroFramework.Controls.MetroLabel lblNomePai;
        private MetroFramework.Controls.MetroTextBox txtProfissao;
        private MetroFramework.Controls.MetroLabel lblProfissao;
        private MetroFramework.Controls.MetroTextBox txtCpf;
        private MetroFramework.Controls.MetroLabel lblCpf;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroLabel lblDataNascimento;
        private MetroFramework.Controls.MetroTextBox txtTelefone;
        private MetroFramework.Controls.MetroLabel lblTelefone;
        private MetroFramework.Controls.MetroLabel lblEstadoCivil;
        private MetroFramework.Controls.MetroDateTime dtDataNascimento;
        private System.Windows.Forms.GroupBox gpPessoal;
        private System.Windows.Forms.GroupBox gpPais;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MetroFramework.Controls.MetroComboBox cbEstadoCivil;
    }
}