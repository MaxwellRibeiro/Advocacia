using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advocacia.Advogado;
using Advocacia.Andamento_Processual;
using Advocacia.Comarca;
using Advocacia.Configuracao;
using Advocacia.Movimentacao;
using Advocacia.Processo;
using Advocacia.Relatorio;
using Database_Class.Banco_de_Dados;
using Database_Class.Classes;
using Database_Class.User_Control;
using MetroFramework.Forms;

namespace Advocacia
{
    public partial class FormPrincipal : MetroForm
    {
        //private ParametroBd bdParametro = new ParametroBd();
        //private List<Parametro> parametros; 

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private async void FormPrincipal_Load(object sender, EventArgs e)
        {
            //if (!await CarregarParametros())
            //{
            //    parametros = null;
            //}

            UCInicio ucInicio = new UCInicio();
            ucInicio.Dock = DockStyle.Fill;
            splitContainer.Panel1.Controls.Add(ucInicio);
        }

        //private async Task<bool> CarregarParametros()
        //{
        //    parametros = new List<Parametro>();
        //    try
        //    {
        //        parametros = await bdParametro.GetAll();
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //}

        private void btAdvogado_Click(object sender, EventArgs e)
        {
            var frm = new FormAdvogado(/*parametros*/);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btAndamentoProcessual_Click(object sender, EventArgs e)
        {
            var frm = new FormAndamentoProcessual();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btCadastroCliente_Click(object sender, EventArgs e)
        {
            var frm = new FormCliente();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btCadastroComarca_Click(object sender, EventArgs e)
        {
            var frm = new FormComarca();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btMovimentacao_Click(object sender, EventArgs e)
        {
            var frm = new FormMovimentacao();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btProcesso_Click(object sender, EventArgs e)
        {
            var frm = new FormProcesso();
            frm.ShowDialog();
            frm.Dispose();
        }

        //private void btConfiguracao_Click(object sender, EventArgs e)
        //{
        //    var frm = new FormConfiguracao(parametros);
        //    frm.ShowDialog();
        //    frm.Dispose();
        //}

        private void btProcessoRel_Click(object sender, EventArgs e)
        {
            var frm = new FormProcessoRel();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btAbrirPDF_Click(object sender, EventArgs e)
        {
            var frm = new FormNovoOpenRel();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btImportarDados_Click(object sender, EventArgs e)
        {
            var frm = new FormImportarDados();
            frm.ShowDialog();
            frm.Dispose();
        }

        //private void btAdvogado_Click(object sender, EventArgs e)
        //{
        //    //PrintDocument pd = new PrintDocument();
        //    //pd.DocumentName = "Exemplo";
        //    //pd.PrintPage += imprimir;
        //    //PrintPreviewDialog ppd = new PrintPreviewDialog();
        //    //ppd.Document = pd;
        //    //ppd.ShowDialog();
        //}
        //public async void imprimir(object sender, PrintPageEventArgs ev)
        //{
        //    ComarcaBd bdComarca = new ComarcaBd();
        //    List<Database_Class.Classes.Comarca> comarcas = await bdComarca.GetAll();

        //    //Confegurações de Página
        //    float linhasPorPagina = 0;
        //    float posicaoVertical = 0;
        //    float contador = 0;
        //    float margemSuperior = 20;
        //    float margenEsquerda = 20;
        //    float margemDireita = 20;
        //    float alturaFonte = 0;
        //    string linha = "";
        //    Font fonte = new Font("Arial",10);
        //    alturaFonte = fonte.GetHeight(ev.Graphics);
        //    linhasPorPagina = ev.MarginBounds.Height/alturaFonte;

        //    //Título
        //    linha = "Código\t\tCategoria";
        //    posicaoVertical = margemSuperior + contador*alturaFonte;
        //    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
        //    contador += 2;

        //    foreach (var comarca in comarcas)
        //    {
        //        linha = comarca.Nome;
        //        posicaoVertical = margemSuperior + contador*alturaFonte;
        //        ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
        //        contador++;
        //    }

        //}

    }
}
