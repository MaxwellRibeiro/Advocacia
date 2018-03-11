namespace Advocacia
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btRelProcesso = new MetroFramework.Controls.MetroTabControl();
            this.pgCadastro = new MetroFramework.Controls.MetroTabPage();
            this.btAndamentoProcessual = new System.Windows.Forms.Button();
            this.btMovimentacao = new System.Windows.Forms.Button();
            this.btProcesso = new System.Windows.Forms.Button();
            this.btCadastroComarca = new System.Windows.Forms.Button();
            this.btCadastroCliente = new System.Windows.Forms.Button();
            this.btAdvogado = new System.Windows.Forms.Button();
            this.pgRelatorio = new MetroFramework.Controls.MetroTabPage();
            this.btImportarDados = new System.Windows.Forms.Button();
            this.btAbrirPDF = new System.Windows.Forms.Button();
            this.btProcessoRel = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btRelProcesso.SuspendLayout();
            this.pgCadastro.SuspendLayout();
            this.pgRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRelProcesso
            // 
            this.btRelProcesso.Controls.Add(this.pgCadastro);
            this.btRelProcesso.Controls.Add(this.pgRelatorio);
            resources.ApplyResources(this.btRelProcesso, "btRelProcesso");
            this.btRelProcesso.Name = "btRelProcesso";
            this.btRelProcesso.SelectedIndex = 0;
            this.btRelProcesso.UseSelectable = true;
            // 
            // pgCadastro
            // 
            this.pgCadastro.Controls.Add(this.btAndamentoProcessual);
            this.pgCadastro.Controls.Add(this.btMovimentacao);
            this.pgCadastro.Controls.Add(this.btProcesso);
            this.pgCadastro.Controls.Add(this.btCadastroComarca);
            this.pgCadastro.Controls.Add(this.btCadastroCliente);
            this.pgCadastro.Controls.Add(this.btAdvogado);
            resources.ApplyResources(this.pgCadastro, "pgCadastro");
            this.pgCadastro.HorizontalScrollbarBarColor = true;
            this.pgCadastro.HorizontalScrollbarHighlightOnWheel = false;
            this.pgCadastro.HorizontalScrollbarSize = 10;
            this.pgCadastro.Name = "pgCadastro";
            this.pgCadastro.VerticalScrollbarBarColor = true;
            this.pgCadastro.VerticalScrollbarHighlightOnWheel = false;
            this.pgCadastro.VerticalScrollbarSize = 10;
            // 
            // btAndamentoProcessual
            // 
            this.btAndamentoProcessual.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAndamentoProcessual.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btAndamentoProcessual.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btAndamentoProcessual, "btAndamentoProcessual");
            this.btAndamentoProcessual.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btAndamentoProcessual.Name = "btAndamentoProcessual";
            this.btAndamentoProcessual.UseVisualStyleBackColor = false;
            this.btAndamentoProcessual.Click += new System.EventHandler(this.btAndamentoProcessual_Click);
            // 
            // btMovimentacao
            // 
            this.btMovimentacao.BackColor = System.Drawing.SystemColors.Highlight;
            this.btMovimentacao.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btMovimentacao.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btMovimentacao, "btMovimentacao");
            this.btMovimentacao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btMovimentacao.Name = "btMovimentacao";
            this.btMovimentacao.UseVisualStyleBackColor = false;
            this.btMovimentacao.Click += new System.EventHandler(this.btMovimentacao_Click);
            // 
            // btProcesso
            // 
            this.btProcesso.BackColor = System.Drawing.SystemColors.Highlight;
            this.btProcesso.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btProcesso.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btProcesso, "btProcesso");
            this.btProcesso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btProcesso.Name = "btProcesso";
            this.btProcesso.UseVisualStyleBackColor = false;
            this.btProcesso.Click += new System.EventHandler(this.btProcesso_Click);
            // 
            // btCadastroComarca
            // 
            this.btCadastroComarca.BackColor = System.Drawing.SystemColors.Highlight;
            this.btCadastroComarca.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btCadastroComarca.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btCadastroComarca, "btCadastroComarca");
            this.btCadastroComarca.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btCadastroComarca.Name = "btCadastroComarca";
            this.btCadastroComarca.UseVisualStyleBackColor = false;
            this.btCadastroComarca.Click += new System.EventHandler(this.btCadastroComarca_Click);
            // 
            // btCadastroCliente
            // 
            this.btCadastroCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btCadastroCliente.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btCadastroCliente.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btCadastroCliente, "btCadastroCliente");
            this.btCadastroCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btCadastroCliente.Name = "btCadastroCliente";
            this.btCadastroCliente.UseVisualStyleBackColor = false;
            this.btCadastroCliente.Click += new System.EventHandler(this.btCadastroCliente_Click);
            // 
            // btAdvogado
            // 
            this.btAdvogado.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAdvogado.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btAdvogado.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btAdvogado, "btAdvogado");
            this.btAdvogado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btAdvogado.Name = "btAdvogado";
            this.btAdvogado.UseVisualStyleBackColor = false;
            this.btAdvogado.Click += new System.EventHandler(this.btAdvogado_Click);
            // 
            // pgRelatorio
            // 
            this.pgRelatorio.Controls.Add(this.btImportarDados);
            this.pgRelatorio.Controls.Add(this.btAbrirPDF);
            this.pgRelatorio.Controls.Add(this.btProcessoRel);
            resources.ApplyResources(this.pgRelatorio, "pgRelatorio");
            this.pgRelatorio.HorizontalScrollbarBarColor = true;
            this.pgRelatorio.HorizontalScrollbarHighlightOnWheel = false;
            this.pgRelatorio.HorizontalScrollbarSize = 10;
            this.pgRelatorio.Name = "pgRelatorio";
            this.pgRelatorio.VerticalScrollbarBarColor = true;
            this.pgRelatorio.VerticalScrollbarHighlightOnWheel = false;
            this.pgRelatorio.VerticalScrollbarSize = 10;
            // 
            // btImportarDados
            // 
            this.btImportarDados.BackColor = System.Drawing.SystemColors.Highlight;
            this.btImportarDados.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btImportarDados.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btImportarDados, "btImportarDados");
            this.btImportarDados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btImportarDados.Name = "btImportarDados";
            this.btImportarDados.UseVisualStyleBackColor = false;
            this.btImportarDados.Click += new System.EventHandler(this.btImportarDados_Click);
            // 
            // btAbrirPDF
            // 
            this.btAbrirPDF.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAbrirPDF.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btAbrirPDF.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btAbrirPDF, "btAbrirPDF");
            this.btAbrirPDF.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btAbrirPDF.Name = "btAbrirPDF";
            this.btAbrirPDF.UseVisualStyleBackColor = false;
            this.btAbrirPDF.Click += new System.EventHandler(this.btAbrirPDF_Click);
            // 
            // btProcessoRel
            // 
            this.btProcessoRel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btProcessoRel.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btProcessoRel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btProcessoRel, "btProcessoRel");
            this.btProcessoRel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btProcessoRel.Name = "btProcessoRel";
            this.btProcessoRel.UseVisualStyleBackColor = false;
            this.btProcessoRel.Click += new System.EventHandler(this.btProcessoRel_Click);
            // 
            // splitContainer
            // 
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // FormPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Advocacia.Properties.Resources.advocacia2;
            this.BackImagePadding = new System.Windows.Forms.Padding(140, 10, 0, 0);
            this.BackMaxSize = 50;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.btRelProcesso);
            this.Name = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.btRelProcesso.ResumeLayout(false);
            this.pgCadastro.ResumeLayout(false);
            this.pgRelatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl btRelProcesso;
        private MetroFramework.Controls.MetroTabPage pgCadastro;
        private MetroFramework.Controls.MetroTabPage pgRelatorio;
        private System.Windows.Forms.Button btCadastroCliente;
        private System.Windows.Forms.Button btCadastroComarca;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btAndamentoProcessual;
        private System.Windows.Forms.Button btMovimentacao;
        private System.Windows.Forms.Button btProcesso;
        private System.Windows.Forms.Button btAdvogado;
        private System.Windows.Forms.Button btProcessoRel;
        private System.Windows.Forms.Button btAbrirPDF;
        private System.Windows.Forms.Button btImportarDados;
    }
}

