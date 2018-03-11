using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Excel;

namespace Advocacia.Relatorio
{
    public partial class FormOpenRel : Form
    {
        private string src = "";
        public FormOpenRel(string src)
        {
            this.src = src;
            InitializeComponent();
        }


        private void FormOpenRel_Load(object sender, EventArgs e)
        {
            if (src != "")
            {
                pdfVisualizador.src = src;
            }
            else
            {
                MetroMessageBox.Show(this, "\nNão foi Possivel Abrir PDF", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
