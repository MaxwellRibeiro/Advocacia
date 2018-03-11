namespace Advocacia.Processo
{
    partial class FormCadastroProcesso
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
            this.cbComarca = new MetroFramework.Controls.MetroComboBox();
            this.lblComarca = new MetroFramework.Controls.MetroLabel();
            this.cbCliente = new MetroFramework.Controls.MetroComboBox();
            this.lblCliente = new MetroFramework.Controls.MetroLabel();
            this.cbAdvogacia = new MetroFramework.Controls.MetroComboBox();
            this.lblAdvogado = new MetroFramework.Controls.MetroLabel();
            this.txtNumero = new MetroFramework.Controls.MetroTextBox();
            this.lblNumero = new MetroFramework.Controls.MetroLabel();
            this.btSalvar = new MetroFramework.Controls.MetroButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gpPrincipal
            // 
            this.gpPrincipal.Controls.Add(this.cbComarca);
            this.gpPrincipal.Controls.Add(this.lblComarca);
            this.gpPrincipal.Controls.Add(this.cbCliente);
            this.gpPrincipal.Controls.Add(this.lblCliente);
            this.gpPrincipal.Controls.Add(this.cbAdvogacia);
            this.gpPrincipal.Controls.Add(this.lblAdvogado);
            this.gpPrincipal.Controls.Add(this.txtNumero);
            this.gpPrincipal.Controls.Add(this.lblNumero);
            this.gpPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpPrincipal.Location = new System.Drawing.Point(23, 63);
            this.gpPrincipal.Name = "gpPrincipal";
            this.gpPrincipal.Size = new System.Drawing.Size(457, 155);
            this.gpPrincipal.TabIndex = 11;
            this.gpPrincipal.TabStop = false;
            // 
            // cbComarca
            // 
            this.cbComarca.FormattingEnabled = true;
            this.cbComarca.ItemHeight = 23;
            this.cbComarca.Location = new System.Drawing.Point(98, 45);
            this.cbComarca.Name = "cbComarca";
            this.cbComarca.Size = new System.Drawing.Size(333, 29);
            this.cbComarca.TabIndex = 19;
            this.cbComarca.UseSelectable = true;
            // 
            // lblComarca
            // 
            this.lblComarca.AutoSize = true;
            this.lblComarca.Location = new System.Drawing.Point(22, 48);
            this.lblComarca.Name = "lblComarca";
            this.lblComarca.Size = new System.Drawing.Size(70, 19);
            this.lblComarca.TabIndex = 18;
            this.lblComarca.Text = "Comarca :";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.ItemHeight = 23;
            this.cbCliente.Location = new System.Drawing.Point(98, 80);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(333, 29);
            this.cbCliente.TabIndex = 17;
            this.cbCliente.UseSelectable = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(36, 84);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 19);
            this.lblCliente.TabIndex = 16;
            this.lblCliente.Text = "Cliente :";
            // 
            // cbAdvogacia
            // 
            this.cbAdvogacia.FormattingEnabled = true;
            this.cbAdvogacia.ItemHeight = 23;
            this.cbAdvogacia.Location = new System.Drawing.Point(98, 115);
            this.cbAdvogacia.Name = "cbAdvogacia";
            this.cbAdvogacia.Size = new System.Drawing.Size(333, 29);
            this.cbAdvogacia.TabIndex = 13;
            this.cbAdvogacia.UseSelectable = true;
            // 
            // lblAdvogado
            // 
            this.lblAdvogado.AutoSize = true;
            this.lblAdvogado.Location = new System.Drawing.Point(14, 119);
            this.lblAdvogado.Name = "lblAdvogado";
            this.lblAdvogado.Size = new System.Drawing.Size(78, 19);
            this.lblAdvogado.TabIndex = 12;
            this.lblAdvogado.Text = "Advogado :";
            // 
            // txtNumero
            // 
            // 
            // 
            // 
            this.txtNumero.CustomButton.Image = null;
            this.txtNumero.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.txtNumero.CustomButton.Name = "";
            this.txtNumero.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumero.CustomButton.TabIndex = 1;
            this.txtNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumero.CustomButton.UseSelectable = true;
            this.txtNumero.CustomButton.Visible = false;
            this.txtNumero.Lines = new string[0];
            this.txtNumero.Location = new System.Drawing.Point(98, 16);
            this.txtNumero.MaxLength = 32767;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.ShortcutsEnabled = true;
            this.txtNumero.Size = new System.Drawing.Size(333, 23);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.UseSelectable = true;
            this.txtNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(27, 18);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 19);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número :";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(405, 224);
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
            // FormCadastroProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 271);
            this.Controls.Add(this.gpPrincipal);
            this.Controls.Add(this.btSalvar);
            this.Name = "FormCadastroProcesso";
            this.Text = "Cadastro Processo";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCadastroProcesso_FormClosed);
            this.Load += new System.EventHandler(this.FormCadastroProcesso_Load);
            this.gpPrincipal.ResumeLayout(false);
            this.gpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpPrincipal;
        private MetroFramework.Controls.MetroTextBox txtNumero;
        private MetroFramework.Controls.MetroLabel lblNumero;
        private MetroFramework.Controls.MetroButton btSalvar;
        private MetroFramework.Controls.MetroComboBox cbCliente;
        private MetroFramework.Controls.MetroLabel lblCliente;
        private MetroFramework.Controls.MetroComboBox cbAdvogacia;
        private MetroFramework.Controls.MetroLabel lblAdvogado;
        private MetroFramework.Controls.MetroComboBox cbComarca;
        private MetroFramework.Controls.MetroLabel lblComarca;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}