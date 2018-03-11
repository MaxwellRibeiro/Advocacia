namespace Advocacia.Login
{
    partial class FormLogin
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
            this.txtLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblEsqueceuSenha = new MaterialSkin.Controls.MaterialLabel();
            this.lblLembrar = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblRelembrar = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Depth = 0;
            this.txtLogin.Hint = "Login";
            this.txtLogin.Location = new System.Drawing.Point(12, 86);
            this.txtLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.Size = new System.Drawing.Size(317, 23);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.Hint = "Senha";
            this.txtSenha.Location = new System.Drawing.Point(12, 126);
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(317, 23);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = false;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // btLogin
            // 
            this.btLogin.Depth = 0;
            this.btLogin.Location = new System.Drawing.Point(254, 279);
            this.btLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLogin.Name = "btLogin";
            this.btLogin.Primary = true;
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 308);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(317, 1);
            this.materialDivider1.TabIndex = 1;
            // 
            // lblEsqueceuSenha
            // 
            this.lblEsqueceuSenha.AutoSize = true;
            this.lblEsqueceuSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblEsqueceuSenha.Depth = 0;
            this.lblEsqueceuSenha.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEsqueceuSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEsqueceuSenha.Location = new System.Drawing.Point(12, 312);
            this.lblEsqueceuSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            this.lblEsqueceuSenha.Size = new System.Drawing.Size(138, 19);
            this.lblEsqueceuSenha.TabIndex = 4;
            this.lblEsqueceuSenha.Text = "Esqueceu a senha?";
            // 
            // lblLembrar
            // 
            this.lblLembrar.Depth = 0;
            this.lblLembrar.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblLembrar.Location = new System.Drawing.Point(12, 152);
            this.lblLembrar.Margin = new System.Windows.Forms.Padding(0);
            this.lblLembrar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lblLembrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLembrar.Name = "lblLembrar";
            this.lblLembrar.Ripple = true;
            this.lblLembrar.Size = new System.Drawing.Size(138, 21);
            this.lblLembrar.TabIndex = 5;
            this.lblLembrar.Text = "Lembrar Acesso";
            this.lblLembrar.UseVisualStyleBackColor = true;
            // 
            // lblRelembrar
            // 
            this.lblRelembrar.AutoSize = true;
            this.lblRelembrar.BackColor = System.Drawing.Color.Transparent;
            this.lblRelembrar.Depth = 0;
            this.lblRelembrar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRelembrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRelembrar.Location = new System.Drawing.Point(250, 312);
            this.lblRelembrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRelembrar.Name = "lblRelembrar";
            this.lblRelembrar.Size = new System.Drawing.Size(77, 19);
            this.lblRelembrar.TabIndex = 6;
            this.lblRelembrar.Text = "Relembrar";
            this.lblRelembrar.Click += new System.EventHandler(this.lblRelembrar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 416);
            this.Controls.Add(this.lblRelembrar);
            this.Controls.Add(this.lblLembrar);
            this.Controls.Add(this.lblEsqueceuSenha);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialRaisedButton btLogin;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblEsqueceuSenha;
        private MaterialSkin.Controls.MaterialCheckBox lblLembrar;
        private MaterialSkin.Controls.MaterialLabel lblRelembrar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}