using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Microsoft.Office.Interop.Excel;

namespace Advocacia.Relatorio
{
    public static class Exportar_Excel
    {
        static public void ExportarExcel(MetroGrid grid)
        {
            List<double> tamanhoColunas = new List<double>();
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook excelBook = excelApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelBook.Worksheets[1];
            excelApp.Visible = false;

            int n = 0;

            foreach (var col in grid.Columns)
            {
                DataGridViewTextBoxColumn coluna = (DataGridViewTextBoxColumn)col;
               
                if (coluna.Visible)
                {
                    Microsoft.Office.Interop.Excel.Range celula = default(Microsoft.Office.Interop.Excel.Range);
                    celula = excelWorksheet.Cells[1, n + 1];
                    celula.Value = coluna.HeaderText;
                    celula.Font.Bold = true;         
                    celula.Interior.ColorIndex = 41;

                    celula.Columns.AutoFit();
                    var obj = celula.ColumnWidth;
                    if (obj != null)
                    {
                        tamanhoColunas.Add(obj);
                    }
                    else
                    {
                        tamanhoColunas.Add(30);
                    }
                    

                    n += 1;
                }
                
            }

            int i = 2;
            n = 1;
            foreach (var row in grid.Rows)
            {
                DataGridViewRow linha = (DataGridViewRow)row;
                foreach (var col in grid.Columns)
                {
                    DataGridViewTextBoxColumn coluna = (DataGridViewTextBoxColumn)col;
                    if (coluna.Visible)
                    {
                        Microsoft.Office.Interop.Excel.Range celula = default(Microsoft.Office.Interop.Excel.Range);
                        celula = excelWorksheet.Cells[i, n];

                        if (linha.Cells[coluna.Name].Value != null)
                        {   
                            celula.Value = linha.Cells[coluna.Name].Value.ToString();
                            celula.Interior.ColorIndex = 24;
                        }
                        else
                        {
                            celula.Value = linha.Cells[coluna.Name].Value;
                            celula.Interior.ColorIndex = 24;
                        }

                        celula.Columns.AutoFit();
                        var obj = celula.ColumnWidth;
                        if (obj != null)
                        {
                            if (obj > tamanhoColunas[n - 1])
                            {
                                tamanhoColunas[n - 1] = obj;
                                celula.ColumnWidth = obj;
                            }

                        }

                        n += 1;
                    }
                }
                n = 1;
                i += 1;
            }
            excelApp.Visible = true;
        } 
    }
}
