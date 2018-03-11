namespace Advocacia.Relatorio
{
    partial class FormNovoOpenRel
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
            this.btAbrir = new MetroFramework.Controls.MetroButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(23, 73);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(211, 39);
            this.btAbrir.TabIndex = 0;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseSelectable = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(-1, 134);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(259, 27);
            this.ProgressBar.TabIndex = 1;
            // 
            // FormNovoOpenRel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 160);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.btAbrir);
            this.Name = "FormNovoOpenRel";
            this.Text = "Arquivo Pdf";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormNovoOpenRel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btAbrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroFramework.Controls.MetroProgressBar ProgressBar;
    }
}