namespace Advocacia.Movimentacao
{
    partial class FormCadastroMovimentacao
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
            this.cbAndamentoProcessual = new MetroFramework.Controls.MetroComboBox();
            this.cbProcesso = new MetroFramework.Controls.MetroComboBox();
            this.lblAndamentoProcessual = new MetroFramework.Controls.MetroLabel();
            this.dtData = new MetroFramework.Controls.MetroDateTime();
            this.lblData = new MetroFramework.Controls.MetroLabel();
            this.txtObservacao = new MetroFramework.Controls.MetroTextBox();
            this.lblProcesso = new MetroFramework.Controls.MetroLabel();
            this.lblObservacao = new MetroFramework.Controls.MetroLabel();
            this.btSalvar = new MetroFramework.Controls.MetroButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gpPrincipal
            // 
            this.gpPrincipal.Controls.Add(this.cbAndamentoProcessual);
            this.gpPrincipal.Controls.Add(this.cbProcesso);
            this.gpPrincipal.Controls.Add(this.lblAndamentoProcessual);
            this.gpPrincipal.Controls.Add(this.dtData);
            this.gpPrincipal.Controls.Add(this.lblData);
            this.gpPrincipal.Controls.Add(this.txtObservacao);
            this.gpPrincipal.Controls.Add(this.lblProcesso);
            this.gpPrincipal.Controls.Add(this.lblObservacao);
            this.gpPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpPrincipal.Location = new System.Drawing.Point(23, 63);
            this.gpPrincipal.Name = "gpPrincipal";
            this.gpPrincipal.Size = new System.Drawing.Size(517, 195);
            this.gpPrincipal.TabIndex = 11;
            this.gpPrincipal.TabStop = false;
            // 
            // cbAndamentoProcessual
            // 
            this.cbAndamentoProcessual.FormattingEnabled = true;
            this.cbAndamentoProcessual.ItemHeight = 23;
            this.cbAndamentoProcessual.Location = new System.Drawing.Point(162, 87);
            this.cbAndamentoProcessual.Name = "cbAndamentoProcessual";
            this.cbAndamentoProcessual.Size = new System.Drawing.Size(333, 29);
            this.cbAndamentoProcessual.TabIndex = 12;
            this.cbAndamentoProcessual.UseSelectable = true;
            // 
            // cbProcesso
            // 
            this.cbProcesso.FormattingEnabled = true;
            this.cbProcesso.ItemHeight = 23;
            this.cbProcesso.Location = new System.Drawing.Point(162, 52);
            this.cbProcesso.Name = "cbProcesso";
            this.cbProcesso.Size = new System.Drawing.Size(333, 29);
            this.cbProcesso.TabIndex = 11;
            this.cbProcesso.UseSelectable = true;
            // 
            // lblAndamentoProcessual
            // 
            this.lblAndamentoProcessual.AutoSize = true;
            this.lblAndamentoProcessual.Location = new System.Drawing.Point(6, 87);
            this.lblAndamentoProcessual.Name = "lblAndamentoProcessual";
            this.lblAndamentoProcessual.Size = new System.Drawing.Size(150, 19);
            this.lblAndamentoProcessual.TabIndex = 4;
            this.lblAndamentoProcessual.Text = "Andamento Processual :";
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(162, 17);
            this.dtData.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(252, 29);
            this.dtData.TabIndex = 10;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(113, 20);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(43, 19);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data :";
            // 
            // txtObservacao
            // 
            // 
            // 
            // 
            this.txtObservacao.CustomButton.Image = null;
            this.txtObservacao.CustomButton.Location = new System.Drawing.Point(269, 2);
            this.txtObservacao.CustomButton.Name = "";
            this.txtObservacao.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.txtObservacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObservacao.CustomButton.TabIndex = 1;
            this.txtObservacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObservacao.CustomButton.UseSelectable = true;
            this.txtObservacao.CustomButton.Visible = false;
            this.txtObservacao.Lines = new string[0];
            this.txtObservacao.Location = new System.Drawing.Point(162, 122);
            this.txtObservacao.MaxLength = 32767;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.PasswordChar = '\0';
            this.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacao.SelectedText = "";
            this.txtObservacao.SelectionLength = 0;
            this.txtObservacao.SelectionStart = 0;
            this.txtObservacao.ShortcutsEnabled = true;
            this.txtObservacao.Size = new System.Drawing.Size(333, 66);
            this.txtObservacao.TabIndex = 8;
            this.txtObservacao.UseSelectable = true;
            this.txtObservacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblProcesso
            // 
            this.lblProcesso.AutoSize = true;
            this.lblProcesso.Location = new System.Drawing.Point(88, 55);
            this.lblProcesso.Name = "lblProcesso";
            this.lblProcesso.Size = new System.Drawing.Size(68, 19);
            this.lblProcesso.TabIndex = 2;
            this.lblProcesso.Text = "Processo :";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(69, 124);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(87, 19);
            this.lblObservacao.TabIndex = 6;
            this.lblObservacao.Text = "Observação :";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(465, 264);
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
            // FormCadastroMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 308);
            this.Controls.Add(this.gpPrincipal);
            this.Controls.Add(this.btSalvar);
            this.Name = "FormCadastroMovimentacao";
            this.Text = "Cadastro Movimentação";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCadastroMovimentacao_FormClosed);
            this.Load += new System.EventHandler(this.FormCadastroMovimentacao_Load);
            this.gpPrincipal.ResumeLayout(false);
            this.gpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpPrincipal;
        private MetroFramework.Controls.MetroTextBox txtObservacao;
        private MetroFramework.Controls.MetroLabel lblProcesso;
        private MetroFramework.Controls.MetroLabel lblObservacao;
        private MetroFramework.Controls.MetroLabel lblAndamentoProcessual;
        private MetroFramework.Controls.MetroButton btSalvar;
        private MetroFramework.Controls.MetroDateTime dtData;
        private MetroFramework.Controls.MetroLabel lblData;
        private MetroFramework.Controls.MetroComboBox cbAndamentoProcessual;
        private MetroFramework.Controls.MetroComboBox cbProcesso;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}