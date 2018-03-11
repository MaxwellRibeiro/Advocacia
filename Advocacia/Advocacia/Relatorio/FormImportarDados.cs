using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advocacia.Advogado;
using Database_Class.Banco_de_Dados;
using MetroFramework;
using MetroFramework.Forms;

namespace Advocacia.Relatorio
{
    public partial class FormImportarDados : MetroForm
    {
        private AdvogadoBd bdAdvogado = new AdvogadoBd();

        private bool isProcessRunning;
        private string src;

        public FormImportarDados()
        {
            InitializeComponent();
        }

        private void FormImportarDados_Load(object sender, EventArgs e)
        {
            src = "";
        }

        private void Enabled(bool permitir)
        {
            btAbrir.Enabled = permitir;
        }

        private async void btAbrir_Click(object sender, EventArgs e)
        {
            Enabled(false);

            openFileDialog.Filter = "Arquivos PDF | *.txt";
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
                List<Database_Class.Classes.Advogado> listaAdvogados = new List<Database_Class.Classes.Advogado>();

                StreamReader file = new StreamReader(src);
                string line = string.Empty;
                while ((line = file.ReadLine()) != null)
                {
                    string[] dadosColetados = line.Split(';');
                    if (dadosColetados.Count() >= 5)
                    {
                        listaAdvogados.Add(new Database_Class.Classes.Advogado
                        {
                            Nome = dadosColetados[0],
                            OAB = dadosColetados[1],
                            Cpf = dadosColetados[2],
                            Telefone = dadosColetados[3],
                            Email = dadosColetados[4]
                        });
                    }
                }

                if (listaAdvogados.Count > 0)
                {
                    bool ok = true;
                    foreach (var advogado in listaAdvogados)
                    {
                        await bdAdvogado.Insert(advogado);

                        if (advogado.Id == 0)
                        {
                            ok = false;
                        }
                    }
                    if (ok)
                    {
                        var result = MetroMessageBox.Show(this, "Registros cadastrados!\nDeseja Visualizá-los?", "Concluido", MessageBoxButtons.YesNo, MessageBoxIcon.Question, this.Height);
                        if (result == DialogResult.Yes)
                        {
                            var frm = new FormAdvogado(/*parametros*/);
                            frm.ShowDialog();
                            frm.Dispose();

                            Close();
                        }
                        else
                        {
                            Close();
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Ocorreu alguma falhar ao cadastrar Registros", "Falha", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, this.Height);
                        Close();
                    }
                }
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
                        MetroMessageBox.Show(this, "\nCarregado com sucesso.", "prosseguir",
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
