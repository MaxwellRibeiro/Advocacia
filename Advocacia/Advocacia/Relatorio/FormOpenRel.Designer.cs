namespace Advocacia.Relatorio
{
    partial class FormOpenRel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpenRel));
            this.pdfVisualizador = new AxAcroPDFLib.AxAcroPDF();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pdfVisualizador)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfVisualizador
            // 
            this.pdfVisualizador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfVisualizador.Enabled = true;
            this.pdfVisualizador.Location = new System.Drawing.Point(0, 0);
            this.pdfVisualizador.Name = "pdfVisualizador";
            this.pdfVisualizador.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfVisualizador.OcxState")));
            this.pdfVisualizador.Size = new System.Drawing.Size(529, 419);
            this.pdfVisualizador.TabIndex = 0;
            this.pdfVisualizador.UseWaitCursor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormOpenRel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(529, 419);
            this.Controls.Add(this.pdfVisualizador);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOpenRel";
            this.Text = "Arquivo Pdf";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormOpenRel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pdfVisualizador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF pdfVisualizador;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}