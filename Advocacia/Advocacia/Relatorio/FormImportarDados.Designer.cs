namespace Advocacia.Relatorio
{
    partial class FormImportarDados
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
            this.ProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.btAbrir = new MetroFramework.Controls.MetroButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(-1, 124);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(259, 27);
            this.ProgressBar.TabIndex = 3;
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(23, 63);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(211, 39);
            this.btAbrir.TabIndex = 2;
            this.btAbrir.Text = "Abrir Arquivo Txt    (Advogado)";
            this.btAbrir.UseSelectable = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormImportarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 152);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.btAbrir);
            this.Name = "FormImportarDados";
            this.Text = "Importar Dados";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormImportarDados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar ProgressBar;
        private MetroFramework.Controls.MetroButton btAbrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}