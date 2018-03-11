using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database_Class.Banco_de_Dados;

namespace Advocacia.Relatorio
{
     public class PrintDocument
    {
        private Database_Class.Classes.Cliente clienteByProcesso;
        private Database_Class.Classes.Processo processo;
        private List<Database_Class.Classes.Movimentacao> movimentoacoesByProcesso;

        public void GerarRelPrintDocument(Database_Class.Classes.Cliente clienteByProcesso,Database_Class.Classes.Processo processo,List<Database_Class.Classes.Movimentacao> movimentoacoesByProcesso)
        {
            this.clienteByProcesso = clienteByProcesso;
            this.processo = processo;
            this.movimentoacoesByProcesso = movimentoacoesByProcesso;

            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            pd.DocumentName = "Movimentacoes_do_Processo";
            pd.PrintPage += imprimir;
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.WindowState = FormWindowState.Maximized;
            ppd.PrintPreviewControl.Zoom = 1;
            ppd.ShowDialog();
        }

        public void imprimir(object sender, PrintPageEventArgs ev)
        {
            //Confegurações de Página
            float linhasPorPagina = 0;
            float posicaoVertical = 0;
            float contador = 0;
            float margemSuperior = 20;
            float margenEsquerda = 20;
            float margemDireita = 20;
            float alturaFonte = 0;
            string linha = "";
            System.Drawing.Font fonte = new System.Drawing.Font("Arial", 10);
            alturaFonte = fonte.GetHeight(ev.Graphics);
            linhasPorPagina = ev.MarginBounds.Height / alturaFonte;

            linha = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
            contador++;

            linha = "\t\t\t\t\t   INFORMAÇÕES DO PROCESSO";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
            contador++;

            linha = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
            contador++;

            linha = "Número: "+processo.Numero;
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
            contador += 2;

            linha = "Comarca: " + processo.NomeComarca; 
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
            contador += 2;

            linha = "Cliente: " + clienteByProcesso.Nome;
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
            contador += 2;

            linha = "Telefone: "+clienteByProcesso.Telefone;
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
            contador++;

            linha = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
            contador++;

            linha = "\t\t\t\t\t  MOVIMENTAÇÕES DO PROCESSO";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
            contador++;

            linha = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
            contador++;
            foreach (var movimentacao in movimentoacoesByProcesso)
            {

                linha = "Data: "+ movimentacao.Data.ToShortDateString()+"\t\t\t\tSituação: "+ movimentacao.SituacaoAndamentoProcessual;
                posicaoVertical = margemSuperior + contador * alturaFonte;
                ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
                contador++;

                linha = "Oberservação: "+ movimentacao.Observacao;
                posicaoVertical = margemSuperior + contador * alturaFonte;
                ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
                contador+=2;
            }
            contador--;
            linha = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margenEsquerda, posicaoVertical);
            contador++;
        }
    }
}
