namespace Advocacia.Configuracao
{
    partial class FormConfiguracao
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
            this.tgLembrarAcesso = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblExcel = new MetroFramework.Controls.MetroLabel();
            this.tgExcel = new MetroFramework.Controls.MetroToggle();
            this.lblPdf = new MetroFramework.Controls.MetroLabel();
            this.tgPdf = new MetroFramework.Controls.MetroToggle();
            this.gpSistema = new System.Windows.Forms.GroupBox();
            this.gpPossue = new System.Windows.Forms.GroupBox();
            this.btSalvar = new MetroFramework.Controls.MetroButton();
            this.gpLogin = new System.Windows.Forms.GroupBox();
            this.btMudarSenha = new MetroFramework.Controls.MetroButton();
            this.btNovoUsuario = new MetroFramework.Controls.MetroButton();
            this.btMostrarUsuarios = new MetroFramework.Controls.MetroButton();
            this.gpSistema.SuspendLayout();
            this.gpPossue.SuspendLayout();
            this.gpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tgLembrarAcesso
            // 
            this.tgLembrarAcesso.AutoSize = true;
            this.tgLembrarAcesso.DisplayStatus = false;
            this.tgLembrarAcesso.Location = new System.Drawing.Point(362, 18);
            this.tgLembrarAcesso.Name = "tgLembrarAcesso";
            this.tgLembrarAcesso.Size = new System.Drawing.Size(50, 17);
            this.tgLembrarAcesso.TabIndex = 15;
            this.tgLembrarAcesso.Text = "Off";
            this.tgLembrarAcesso.UseSelectable = true;
            this.tgLembrarAcesso.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(332, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Lembrar Acesso (Logar automaticamente no sistema)  :";
            // 
            // lblExcel
            // 
            this.lblExcel.AutoSize = true;
            this.lblExcel.Location = new System.Drawing.Point(6, 16);
            this.lblExcel.Name = "lblExcel";
            this.lblExcel.Size = new System.Drawing.Size(49, 19);
            this.lblExcel.TabIndex = 18;
            this.lblExcel.Text = "Excel  :";
            // 
            // tgExcel
            // 
            this.tgExcel.AutoSize = true;
            this.tgExcel.DisplayStatus = false;
            this.tgExcel.Location = new System.Drawing.Point(61, 18);
            this.tgExcel.Name = "tgExcel";
            this.tgExcel.Size = new System.Drawing.Size(50, 17);
            this.tgExcel.TabIndex = 17;
            this.tgExcel.Text = "Off";
            this.tgExcel.UseSelectable = true;
            this.tgExcel.UseStyleColors = true;
            // 
            // lblPdf
            // 
            this.lblPdf.AutoSize = true;
            this.lblPdf.Location = new System.Drawing.Point(327, 16);
            this.lblPdf.Name = "lblPdf";
            this.lblPdf.Size = new System.Drawing.Size(39, 19);
            this.lblPdf.TabIndex = 20;
            this.lblPdf.Text = "Pdf  :";
            // 
            // tgPdf
            // 
            this.tgPdf.AutoSize = true;
            this.tgPdf.DisplayStatus = false;
            this.tgPdf.Location = new System.Drawing.Point(372, 18);
            this.tgPdf.Name = "tgPdf";
            this.tgPdf.Size = new System.Drawing.Size(50, 17);
            this.tgPdf.TabIndex = 19;
            this.tgPdf.Text = "Off";
            this.tgPdf.UseSelectable = true;
            this.tgPdf.UseStyleColors = true;
            // 
            // gpSistema
            // 
            this.gpSistema.Controls.Add(this.metroLabel1);
            this.gpSistema.Controls.Add(this.tgLembrarAcesso);
            this.gpSistema.Location = new System.Drawing.Point(23, 63);
            this.gpSistema.Name = "gpSistema";
            this.gpSistema.Size = new System.Drawing.Size(434, 50);
            this.gpSistema.TabIndex = 21;
            this.gpSistema.TabStop = false;
            this.gpSistema.Text = " Sistema ";
            // 
            // gpPossue
            // 
            this.gpPossue.Controls.Add(this.lblExcel);
            this.gpPossue.Controls.Add(this.tgExcel);
            this.gpPossue.Controls.Add(this.lblPdf);
            this.gpPossue.Controls.Add(this.tgPdf);
            this.gpPossue.Location = new System.Drawing.Point(23, 119);
            this.gpPossue.Name = "gpPossue";
            this.gpPossue.Size = new System.Drawing.Size(434, 47);
            this.gpPossue.TabIndex = 22;
            this.gpPossue.TabStop = false;
            this.gpPossue.Text = " Possue ";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(382, 232);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 23;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseSelectable = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // gpLogin
            // 
            this.gpLogin.Controls.Add(this.btMostrarUsuarios);
            this.gpLogin.Controls.Add(this.btNovoUsuario);
            this.gpLogin.Controls.Add(this.btMudarSenha);
            this.gpLogin.Location = new System.Drawing.Point(23, 172);
            this.gpLogin.Name = "gpLogin";
            this.gpLogin.Size = new System.Drawing.Size(434, 54);
            this.gpLogin.TabIndex = 24;
            this.gpLogin.TabStop = false;
            this.gpLogin.Text = " Login ";
            // 
            // btMudarSenha
            // 
            this.btMudarSenha.Location = new System.Drawing.Point(6, 18);
            this.btMudarSenha.Name = "btMudarSenha";
            this.btMudarSenha.Size = new System.Drawing.Size(96, 23);
            this.btMudarSenha.TabIndex = 24;
            this.btMudarSenha.Text = "Mudar Senha";
            this.btMudarSenha.UseSelectable = true;
            this.btMudarSenha.Click += new System.EventHandler(this.btMudarSenha_Click);
            // 
            // btNovoUsuario
            // 
            this.btNovoUsuario.Location = new System.Drawing.Point(282, 18);
            this.btNovoUsuario.Name = "btNovoUsuario";
            this.btNovoUsuario.Size = new System.Drawing.Size(140, 23);
            this.btNovoUsuario.TabIndex = 25;
            this.btNovoUsuario.Text = "Cadastrar Novo Usuario";
            this.btNovoUsuario.UseSelectable = true;
            this.btNovoUsuario.Click += new System.EventHandler(this.btNovoUsuario_Click);
            // 
            // btMostrarUsuarios
            // 
            this.btMostrarUsuarios.Location = new System.Drawing.Point(108, 18);
            this.btMostrarUsuarios.Name = "btMostrarUsuarios";
            this.btMostrarUsuarios.Size = new System.Drawing.Size(168, 23);
            this.btMostrarUsuarios.TabIndex = 26;
            this.btMostrarUsuarios.Text = "Mostrar Usuarios Cadastrados";
            this.btMostrarUsuarios.UseSelectable = true;
            this.btMostrarUsuarios.Click += new System.EventHandler(this.btMostrarUsuarios_Click);
            // 
            // FormConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 279);
            this.Controls.Add(this.gpLogin);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gpPossue);
            this.Controls.Add(this.gpSistema);
            this.Name = "FormConfiguracao";
            this.Text = "Configuração";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormConfiguracao_Load);
            this.gpSistema.ResumeLayout(false);
            this.gpSistema.PerformLayout();
            this.gpPossue.ResumeLayout(false);
            this.gpPossue.PerformLayout();
            this.gpLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroToggle tgLembrarAcesso;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblExcel;
        private MetroFramework.Controls.MetroToggle tgExcel;
        private MetroFramework.Controls.MetroLabel lblPdf;
        private MetroFramework.Controls.MetroToggle tgPdf;
        private System.Windows.Forms.GroupBox gpSistema;
        private System.Windows.Forms.GroupBox gpPossue;
        private MetroFramework.Controls.MetroButton btSalvar;
        private System.Windows.Forms.GroupBox gpLogin;
        private MetroFramework.Controls.MetroButton btMostrarUsuarios;
        private MetroFramework.Controls.MetroButton btNovoUsuario;
        private MetroFramework.Controls.MetroButton btMudarSenha;
    }
}