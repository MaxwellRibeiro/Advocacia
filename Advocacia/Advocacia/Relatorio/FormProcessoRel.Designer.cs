namespace Advocacia.Relatorio
{
    partial class FormProcessoRel
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
            this.gpFiltro = new System.Windows.Forms.GroupBox();
            this.cbProcesso = new MetroFramework.Controls.MetroComboBox();
            this.cbCliente = new MetroFramework.Controls.MetroComboBox();
            this.lblProcesso = new MetroFramework.Controls.MetroLabel();
            this.lblCliente = new MetroFramework.Controls.MetroLabel();
            this.btGerar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbPdf = new MetroFramework.Controls.MetroCheckBox();
            this.gpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFiltro
            // 
            this.gpFiltro.Controls.Add(this.cbProcesso);
            this.gpFiltro.Controls.Add(this.cbCliente);
            this.gpFiltro.Controls.Add(this.lblProcesso);
            this.gpFiltro.Controls.Add(this.lblCliente);
            this.gpFiltro.Location = new System.Drawing.Point(23, 63);
            this.gpFiltro.Name = "gpFiltro";
            this.gpFiltro.Size = new System.Drawing.Size(483, 85);
            this.gpFiltro.TabIndex = 1;
            this.gpFiltro.TabStop = false;
            this.gpFiltro.Text = " Filtro ";
            // 
            // cbProcesso
            // 
            this.cbProcesso.FormattingEnabled = true;
            this.cbProcesso.ItemHeight = 23;
            this.cbProcesso.Location = new System.Drawing.Point(81, 48);
            this.cbProcesso.Name = "cbProcesso";
            this.cbProcesso.Size = new System.Drawing.Size(377, 29);
            this.cbProcesso.TabIndex = 3;
            this.cbProcesso.UseSelectable = true;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.ItemHeight = 23;
            this.cbCliente.Location = new System.Drawing.Point(81, 13);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(377, 29);
            this.cbCliente.TabIndex = 2;
            this.cbCliente.UseSelectable = true;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // lblProcesso
            // 
            this.lblProcesso.AutoSize = true;
            this.lblProcesso.Location = new System.Drawing.Point(6, 53);
            this.lblProcesso.Name = "lblProcesso";
            this.lblProcesso.Size = new System.Drawing.Size(68, 19);
            this.lblProcesso.TabIndex = 1;
            this.lblProcesso.Text = "Processo :";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(18, 17);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 19);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente :";
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(431, 154);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(75, 23);
            this.btGerar.TabIndex = 2;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbPdf
            // 
            this.cbPdf.AutoSize = true;
            this.cbPdf.Location = new System.Drawing.Point(23, 162);
            this.cbPdf.Name = "cbPdf";
            this.cbPdf.Size = new System.Drawing.Size(171, 15);
            this.cbPdf.TabIndex = 3;
            this.cbPdf.Text = "Possuo Adobe Pdf Instalado";
            this.cbPdf.UseSelectable = true;
            // 
            // FormProcessoRel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 193);
            this.Controls.Add(this.cbPdf);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.gpFiltro);
            this.Name = "FormProcessoRel";
            this.Text = "Relatório Processo";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormProcessoRel_Load);
            this.gpFiltro.ResumeLayout(false);
            this.gpFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpFiltro;
        private MetroFramework.Controls.MetroComboBox cbProcesso;
        private MetroFramework.Controls.MetroComboBox cbCliente;
        private MetroFramework.Controls.MetroLabel lblProcesso;
        private MetroFramework.Controls.MetroLabel lblCliente;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MetroFramework.Controls.MetroCheckBox cbPdf;
    }
}