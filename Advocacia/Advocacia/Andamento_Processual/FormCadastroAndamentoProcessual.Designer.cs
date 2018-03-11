namespace Advocacia.Andamento_Processual
{
    partial class FormCadastroAndamentoProcessual
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
            this.txtSituacao = new MetroFramework.Controls.MetroTextBox();
            this.lblSituacao = new MetroFramework.Controls.MetroLabel();
            this.btSalvar = new MetroFramework.Controls.MetroButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gpPrincipal
            // 
            this.gpPrincipal.Controls.Add(this.txtSituacao);
            this.gpPrincipal.Controls.Add(this.lblSituacao);
            this.gpPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpPrincipal.Location = new System.Drawing.Point(23, 63);
            this.gpPrincipal.Name = "gpPrincipal";
            this.gpPrincipal.Size = new System.Drawing.Size(441, 49);
            this.gpPrincipal.TabIndex = 11;
            this.gpPrincipal.TabStop = false;
            // 
            // txtSituacao
            // 
            // 
            // 
            // 
            this.txtSituacao.CustomButton.Image = null;
            this.txtSituacao.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.txtSituacao.CustomButton.Name = "";
            this.txtSituacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSituacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSituacao.CustomButton.TabIndex = 1;
            this.txtSituacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSituacao.CustomButton.UseSelectable = true;
            this.txtSituacao.CustomButton.Visible = false;
            this.txtSituacao.Lines = new string[0];
            this.txtSituacao.Location = new System.Drawing.Point(95, 16);
            this.txtSituacao.MaxLength = 32767;
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.PasswordChar = '\0';
            this.txtSituacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSituacao.SelectedText = "";
            this.txtSituacao.SelectionLength = 0;
            this.txtSituacao.SelectionStart = 0;
            this.txtSituacao.ShortcutsEnabled = true;
            this.txtSituacao.Size = new System.Drawing.Size(321, 23);
            this.txtSituacao.TabIndex = 1;
            this.txtSituacao.UseSelectable = true;
            this.txtSituacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSituacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(24, 16);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(65, 19);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação :";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(389, 118);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 10;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseSelectable = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormCadastroAndamentoProcessual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 163);
            this.Controls.Add(this.gpPrincipal);
            this.Controls.Add(this.btSalvar);
            this.Name = "FormCadastroAndamentoProcessual";
            this.Text = "Cadastro Andamento Processual";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCadastroAndamentoProcessual_FormClosed);
            this.Load += new System.EventHandler(this.FormCadastroAndamentoProcessual_Load);
            this.gpPrincipal.ResumeLayout(false);
            this.gpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpPrincipal;
        private MetroFramework.Controls.MetroTextBox txtSituacao;
        private MetroFramework.Controls.MetroLabel lblSituacao;
        private MetroFramework.Controls.MetroButton btSalvar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}