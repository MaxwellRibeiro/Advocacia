using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace Advocacia.Relatorio
{
    public partial class FormNovoOpenRel : MetroForm
    {
        private bool isProcessRunning;
        private string src;

        public FormNovoOpenRel()
        {
            InitializeComponent();
        }

        private void FormNovoOpenRel_Load(object sender, EventArgs e)
        {
            src = "";
        }

        private void Enabled(bool permitir)
        {
            btAbrir.Enabled = permitir;
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            Enabled(false);

            openFileDialog.Filter = "Arquivos PDF | *.pdf";
            openFileDialog.InitialDirectory = "C:\\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                src = openFileDialog.FileName;     
            }
            else
            {
                return;
            }

            if (!Thread_ProgressBar())
            {
                return;
            }

            if (src != "")
            {
                var frm = new FormOpenRel(src);
                frm.ShowDialog();
                frm.Dispose();          
            }

            Enabled(true);
            Close();
        }

        public void UpdateProgress(int progress)
        {
            ProgressBar.BeginInvoke(
                new Action(() =>
                {
                    ProgressBar.Value = progress;
                }
            ));
        }

        public bool Thread_ProgressBar()
        {

            if (isProcessRunning)
            {
                return false;
            }

            FormNovoOpenRel progressDialog = new FormNovoOpenRel();

            Thread backgroundThread = new Thread(
                new ThreadStart(() =>
                {
                    isProcessRunning = true;

                    for (int n = 0; n < 100; n++)
                    {
                        Thread.Sleep(15);
                        progressDialog.UpdateProgress(n);
                    }
                    if (src != "")
                    {
                        MetroMessageBox.Show(this, "\nCarregado com sucesso.", "Concluido",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "\nNão foi possível abrir.", "Falha",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    }
                    progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));

                    isProcessRunning = false;
                }
            ));
            backgroundThread.Start();

            progressDialog.ShowDialog();

            return true;
        }
    }
}
