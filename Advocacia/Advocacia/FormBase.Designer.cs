namespace Advocacia
{
    partial class FormBase
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
            this.tsOpcao = new System.Windows.Forms.ToolStrip();
            this.btInserir = new System.Windows.Forms.ToolStripLabel();
            this.btAlterar = new System.Windows.Forms.ToolStripLabel();
            this.btExcluir = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btExcel = new System.Windows.Forms.ToolStripLabel();
            this.tsOpcao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsOpcao
            // 
            this.tsOpcao.AutoSize = false;
            this.tsOpcao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsOpcao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsOpcao.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsOpcao.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsOpcao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tsOpcao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btInserir,
            this.btAlterar,
            this.btExcluir,
            this.toolStripSeparator1,
            this.btExcel});
            this.tsOpcao.Location = new System.Drawing.Point(20, 60);
            this.tsOpcao.Name = "tsOpcao";
            this.tsOpcao.Padding = new System.Windows.Forms.Padding(0);
            this.tsOpcao.Size = new System.Drawing.Size(1330, 46);
            this.tsOpcao.TabIndex = 0;
            this.tsOpcao.Text = "toolStrip1";
            // 
            // btInserir
            // 
            this.btInserir.AutoSize = false;
            this.btInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btInserir.Image = global::Advocacia.Properties.Resources.Add_32;
            this.btInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btInserir.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(45, 45);
            this.btInserir.ToolTipText = "Adicionar";
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            this.btInserir.MouseLeave += new System.EventHandler(this.btInserir_MouseLeave);
            this.btInserir.MouseHover += new System.EventHandler(this.btInserir_MouseHover);
            // 
            // btAlterar
            // 
            this.btAlterar.AutoSize = false;
            this.btAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAlterar.Image = global::Advocacia.Properties.Resources.Change_32;
            this.btAlterar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btAlterar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(45, 45);
            this.btAlterar.ToolTipText = "Alterar";
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            this.btAlterar.MouseLeave += new System.EventHandler(this.btAlterar_MouseLeave);
            this.btAlterar.MouseHover += new System.EventHandler(this.btAlterar_MouseHover);
            // 
            // btExcluir
            // 
            this.btExcluir.AutoSize = false;
            this.btExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btExcluir.Image = global::Advocacia.Properties.Resources.Delete_32;
            this.btExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btExcluir.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(45, 45);
            this.btExcluir.ToolTipText = "Excluir";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            this.btExcluir.MouseLeave += new System.EventHandler(this.btExcluir_MouseLeave);
            this.btExcluir.MouseHover += new System.EventHandler(this.btExcluir_MouseHover);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // btExcel
            // 
            this.btExcel.AutoSize = false;
            this.btExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btExcel.Image = global::Advocacia.Properties.Resources.Excel_32;
            this.btExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btExcel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(45, 45);
            this.btExcel.ToolTipText = "Excluir";
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            this.btExcel.MouseLeave += new System.EventHandler(this.btExcel_MouseLeave);
            this.btExcel.MouseHover += new System.EventHandler(this.btExcel_MouseHover);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Advocacia.Properties.Resources.advocacia2;
            this.BackImagePadding = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(1370, 453);
            this.Controls.Add(this.tsOpcao);
            this.Name = "FormBase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsOpcao.ResumeLayout(false);
            this.tsOpcao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsOpcao;
        private System.Windows.Forms.ToolStripLabel btInserir;
        private System.Windows.Forms.ToolStripLabel btAlterar;
        private System.Windows.Forms.ToolStripLabel btExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel btExcel;
    }
}