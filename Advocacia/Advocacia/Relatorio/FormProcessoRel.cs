using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database_Class.Banco_de_Dados;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework;
using MetroFramework.Forms;
using Color = iTextSharp.text.Color;
using Font = Microsoft.Office.Interop.Excel.Font;
using Image = iTextSharp.text.Image;

namespace Advocacia.Relatorio
{
    public partial class FormProcessoRel : MetroForm
    {
        private List<Database_Class.Classes.Processo> processos;
        private List<Database_Class.Classes.Movimentacao> movimentacaos;
        private Document doc;
        private FileStream arquivo;
        private PdfWriter writer;
        private string src;

        public FormProcessoRel()
        {
            InitializeComponent();
        }

        private void FormProcessoRel_Load(object sender, EventArgs e)
        {
            src = "C:\\Users\\Maxwell\\Documents\\pdf\\";
            CarregaCombo();
        }

        private async void CarregaCombo()
        {
            ClienteBd bdCliente = new ClienteBd();
            ProcessoBd bdProcesso = new ProcessoBd();
            MovimentacaoBd bdMovimentacao = new MovimentacaoBd();

            processos = new List<Database_Class.Classes.Processo>();
            processos = await bdProcesso.GetAll();

            movimentacaos = new List<Database_Class.Classes.Movimentacao>();
            movimentacaos = await bdMovimentacao.GetAll();

            cbCliente.DataSource = await bdCliente.GetAll();
            cbCliente.ValueMember = "Id";
            cbCliente.DisplayMember = "Nome";
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            if (!VerificarCamposObrigatorios())
            {
                return;
            }

            GerarRelatorio();
        }

        private bool VerificarCamposObrigatorios()
        {
            if (cbProcesso.SelectedItem == null)
            {
                errorProvider.SetError(cbProcesso, "Selecione um Cliente que tenha Processo(s)");
                return false;
            }
            errorProvider.SetError(cbProcesso, "");


            return true;
        }

        private void GerarRelatorio()
        {        
            var processo = (Database_Class.Classes.Processo)cbProcesso.SelectedItem;

            if (movimentacaos != null && movimentacaos.Count > 0)
            {
                var movimentoacoesByProcesso = movimentacaos.Where(M => M.IdProcesso == processo.Id).ToList();

                if (movimentoacoesByProcesso.Count != 0)
                {
                    movimentoacoesByProcesso = movimentoacoesByProcesso.OrderBy(O => O.Data).ToList();

                    var clienteByProcesso = (Database_Class.Classes.Cliente)cbCliente.SelectedItem;
                    if (clienteByProcesso.Id == processo.IdCliente)
                    {
                        if (cbPdf.Checked)
                        {
                            src += $@"Rel.MovimentacoesProcesso_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}-{DateTime.Now.Hour}_{DateTime.Now.Minute}_{DateTime.Now.Second}.pdf";

                            MontarDocumento(clienteByProcesso, processo, movimentoacoesByProcesso);

                            var frm = new FormOpenRel(src);
                            frm.ShowDialog();
                            frm.Dispose();

                            if (File.Exists(src))
                            {
                                try
                                {
                                    File.Delete(src);
                                }
                                catch (IOException ex)
                                {
                                    MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                                }

                                Close();
                            }
                        }
                        else
                        {
                            PrintDocument print = new PrintDocument();
                            print.GerarRelPrintDocument(clienteByProcesso, processo, movimentoacoesByProcesso);

                            Close();
                        }              
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "\nNão foi possivel gerar o Relatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "\nNão foi possivel gerar o Relatório\n\nProcesso sem Movimentos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "\nNão foi possivel gerar o Relatório\nNão existe Movimentos cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, this.Height);
            }
        }

        private void MontarDocumento(Database_Class.Classes.Cliente cliente, Database_Class.Classes.Processo processo, List<Database_Class.Classes.Movimentacao> movimentacoes)
        {
            CriarDocumento();
            CabecalhoDocumento();
            CorpoDocumento(cliente, processo, movimentacoes);
            RodapeDocumento();
            FecharDocumento();
        }

        private void CriarDocumento()
        {
            doc = new Document(iTextSharp.text.PageSize.A4, 20, 20, 20, 20);
            arquivo = new FileStream(src, FileMode.Create);
            writer = PdfWriter.GetInstance(doc, arquivo);
            doc.Open();

            doc.AddAuthor("Maxwell");
            doc.AddCreator("Relatório Processos");
            doc.AddKeywords("Advocacia");
            doc.AddSubject("Relatório Processos");
            doc.AddTitle("Relatório Processos");
        }

        private void CabecalhoDocumento()
        {
            iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 8, iTextSharp.text.Font.NORMAL, Color.BLACK);
            iTextSharp.text.Font titulo = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 8, iTextSharp.text.Font.BOLD, Color.BLACK);
            float[] sizes = new float[] { 1f, 3f, 1f };

            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 100f;
            table.SetWidths(sizes);

            iTextSharp.text.Image foot;
            foot = iTextSharp.text.Image.GetInstance(@"D:\Documentos\Ciência da Computação\Advocacia\Img\advocacia.png");
            foot.ScalePercent(60);

            PdfPCell cell = new PdfPCell(foot);
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Border = 0;
            cell.BorderWidthTop = 1.5f;
            cell.BorderWidthBottom = 1.5f;
            cell.PaddingTop = 10f;
            cell.PaddingBottom = 10f;
            cell.PaddingLeft = -60f;
            table.AddCell(cell);

            PdfPTable micros = new PdfPTable(1);
            cell = new PdfPCell(new Phrase("Advocacia", font));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            micros.AddCell(cell);
            cell = new PdfPCell(new Phrase("Relatório Movimentações do Processo", titulo));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            micros.AddCell(cell);

            cell = new PdfPCell(micros);
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Border = 0;
            cell.BorderWidthTop = 1.5f;
            cell.BorderWidthBottom = 1.5f;
            cell.PaddingTop = 10f;
            table.AddCell(cell);


            micros = new PdfPTable(1);
            cell = new PdfPCell(new Phrase("Página: " + (doc.PageNumber + 1), font));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            micros.AddCell(cell);

            cell = new PdfPCell(micros);
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Border = 0;
            cell.BorderWidthTop = 1.5f;
            cell.BorderWidthBottom = 1.5f;
            cell.PaddingTop = 10f;
            table.AddCell(cell);

            doc.Add(table);
            writer.Flush();
        }

        private void CorpoDocumento(Database_Class.Classes.Cliente cliente, Database_Class.Classes.Processo processo, List<Database_Class.Classes.Movimentacao> movimentacoes)
        {
            PdfPTable table = new PdfPTable(5);
            iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 8, iTextSharp.text.Font.NORMAL, Color.BLACK);
            iTextSharp.text.Font titulo = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 8, iTextSharp.text.Font.BOLD, Color.BLACK);

            float[] colsW = { 10, 10, 10, 10, 10 };
            table.SetWidths(colsW);
            table.HeaderRows = 1;
            table.WidthPercentage = 100f;

            table.DefaultCell.Border = PdfPCell.BOTTOM_BORDER;
            table.DefaultCell.BorderColor = Color.BLACK;
            table.DefaultCell.BorderColorBottom = Color.BLACK;
            table.DefaultCell.Padding = 10;

            var cell = getNewCell("Informações Gerais Sobre o Processo", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER);
            cell.Colspan = 5;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            table.AddCell(getNewCell("Número", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, Color.BLACK, Color.WHITE));
            table.AddCell(getNewCell("Comarca", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, Color.BLACK, Color.WHITE));
            table.AddCell(getNewCell("Cliente", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, Color.BLACK, Color.WHITE));
            table.AddCell(getNewCell("Telefone", titulo, Element.ALIGN_RIGHT, 10, PdfPCell.BOTTOM_BORDER, Color.BLACK, Color.WHITE));
            table.AddCell(getNewCell("Cpf", titulo, Element.ALIGN_RIGHT, 10, PdfPCell.BOTTOM_BORDER, Color.BLACK, Color.WHITE));

            table.AddCell(getNewCell(processo.Numero, font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER));
            table.AddCell(getNewCell(processo.NomeComarca, font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER));
            table.AddCell(getNewCell(cliente.Nome, font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER));
            table.AddCell(getNewCell(cliente.Telefone, font, Element.ALIGN_RIGHT, 5, PdfPCell.BOTTOM_BORDER));
            table.AddCell(getNewCell(cliente.Cpf, font, Element.ALIGN_RIGHT, 5, PdfPCell.BOTTOM_BORDER));

            doc.Add(table);

            //-----------------------------------------------------------------------------------------------------------------
            table = new PdfPTable(3);
            font = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 8, iTextSharp.text.Font.NORMAL, Color.BLACK);
            titulo = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 8, iTextSharp.text.Font.BOLD, Color.BLACK);

            float[] colsM = { 10, 10, 10 };
            table.SetWidths(colsM);
            table.HeaderRows = 1;
            table.WidthPercentage = 100f;

            table.DefaultCell.Border = PdfPCell.BOTTOM_BORDER;
            table.DefaultCell.BorderColor = Color.BLACK;
            table.DefaultCell.BorderColorBottom = Color.BLACK;
            table.DefaultCell.Padding = 10;

            cell = getNewCell("Movimentações do Processo", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER);
            cell.Colspan = 3;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            table.AddCell(getNewCell("Data", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, Color.BLACK, Color.WHITE));
            table.AddCell(getNewCell("Situacao", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, Color.BLACK, Color.WHITE));
            table.AddCell(getNewCell("Observacao", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, Color.BLACK, Color.WHITE));

            foreach (var movimentacao in movimentacoes)
            {
                table.AddCell(getNewCell(movimentacao.Data.ToLongDateString(), font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER));
                table.AddCell(getNewCell(movimentacao.SituacaoAndamentoProcessual, font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER));
                table.AddCell(getNewCell(movimentacao.Observacao, font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER));
            }

            doc.Add(table);
            writer.Flush();
        }

        private void RodapeDocumento()
        {
            iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 8, iTextSharp.text.Font.NORMAL, Color.BLACK);
            iTextSharp.text.Font negrito = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 8, iTextSharp.text.Font.BOLD, Color.BLACK);
            float[] sizes = new float[] { 1.0f, 3.5f, 1f };

            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 100f;
            table.SetWidths(sizes);

            PdfPCell cell = new PdfPCell(new Phrase("", negrito));
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Border = 0;
            cell.BorderWidthTop = 1.5f;
            cell.PaddingLeft = 1f;
            cell.PaddingTop = 1f;
            table.AddCell(cell);

            PdfPTable micros = new PdfPTable(1);
            cell = new PdfPCell(new Phrase("Maxwell", negrito));
            cell.Border = 0;
            cell.PaddingLeft = -100f;
            micros.AddCell(cell);
            cell = new PdfPCell(new Phrase("(35)98416-0583", font));
            cell.Border = 0;
            cell.PaddingLeft = -100f;
            micros.AddCell(cell);
            cell = new PdfPCell(new Phrase("maxwellmataribeiro@hotmail.com", font));
            cell.Border = 0;
            cell.PaddingLeft = -100f;
            micros.AddCell(cell);

            cell = new PdfPCell(micros);
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Border = 0;
            cell.BorderWidthTop = 1.5f;
            cell.PaddingTop = 10f;
            table.AddCell(cell);

            micros = new PdfPTable(1);
            cell = new PdfPCell(new Phrase(DateTime.Today.ToString("dd/MM/yyyy"), font));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            micros.AddCell(cell);
            cell = new PdfPCell(new Phrase(DateTime.Now.ToString("HH:mm:ss"), font));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            micros.AddCell(cell);

            cell = new PdfPCell(micros);
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Border = 0;
            cell.BorderWidthTop = 1.5f;
            cell.PaddingTop = 10f;
            table.AddCell(cell);

            doc.Add(table);
        }

        private void FecharDocumento()
        {
            doc.Close();
            arquivo.Close();
        }

        private PdfPCell getNewCell(string Texto, iTextSharp.text.Font Fonte, int Alinhamento, float Espacamento, int Borda, Color CorBorda, Color CorFundo)
        {
            var cell = new PdfPCell(new Phrase(Texto, Fonte));
            cell.HorizontalAlignment = Alinhamento;
            cell.Padding = Espacamento;
            cell.Border = Borda;
            cell.BorderColor = CorBorda;
            cell.BackgroundColor = CorFundo;

            return cell;
        }

        private PdfPCell getNewCell(string Texto, iTextSharp.text.Font Fonte, int Alinhamento, float Espacamento, int Borda, Color CorBorda)
        {
            return getNewCell(Texto, Fonte, Alinhamento, Espacamento, Borda, CorBorda, Color.BLACK);
        }

        private PdfPCell getNewCell(string Texto, iTextSharp.text.Font Fonte, int Alinhamento = 0, float Espacamento = 5, int Borda = 0)
        {
            return getNewCell(Texto, Fonte, Alinhamento, Espacamento, Borda, Color.BLACK, Color.WHITE);
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCliente.SelectedItem == null || processos == null)
            {
                return;
            }

            var cliente = (Database_Class.Classes.Cliente) cbCliente.SelectedItem;
            var filtroProcessos = processos.Where(P => P.IdCliente == cliente.Id).ToList();

            cbProcesso.DataSource = filtroProcessos;
            cbProcesso.ValueMember = "Id";
            cbProcesso.DisplayMember = "Numero";
        }

       
    }

    public class dtoRel
    {
        public Document Documento { get; set; }
        public FileStream Arquivo { get; set; }
    }
}
