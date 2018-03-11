using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Advocacia
{
    public partial class FormBase : MetroForm
    {
        public FormBase()
        {
            InitializeComponent();
        }

        public void Enabled_Opcao(bool permissao)
        {
            tsOpcao.Enabled = permissao;

            btInserir.Image = global::Advocacia.Properties.Resources.Add_32;
            btAlterar.Image = global::Advocacia.Properties.Resources.Change_32;
            btExcluir.Image = global::Advocacia.Properties.Resources.Delete_32;
        }

        public virtual void btInserir_Click(object sender, EventArgs e)
        {

        }

        public virtual void btAlterar_Click(object sender, EventArgs e)
        {

        }

        public virtual void btExcluir_Click(object sender, EventArgs e)
        {

        }

        public virtual void btExcel_Click(object sender, EventArgs e)
        {

        }

        private void btInserir_MouseHover(object sender, EventArgs e)
        {
            btInserir.Image = global::Advocacia.Properties.Resources.Add_40;
        }

        private void btInserir_MouseLeave(object sender, EventArgs e)
        {
            btInserir.Image = global::Advocacia.Properties.Resources.Add_32;
        }

        private void btAlterar_MouseHover(object sender, EventArgs e)
        {
            btAlterar.Image = global::Advocacia.Properties.Resources.Change_40;
        }

        private void btAlterar_MouseLeave(object sender, EventArgs e)
        {
            btAlterar.Image = global::Advocacia.Properties.Resources.Change_32;
        }

        private void btExcluir_MouseHover(object sender, EventArgs e)
        {
            btExcluir.Image = global::Advocacia.Properties.Resources.Delete_40;
        }

        private void btExcluir_MouseLeave(object sender, EventArgs e)
        { 
            btExcluir.Image = global::Advocacia.Properties.Resources.Delete_32;
        }

        private void btExcel_MouseHover(object sender, EventArgs e)
        {
            btExcel.Image = global::Advocacia.Properties.Resources.Excel_40;
        }

        private void btExcel_MouseLeave(object sender, EventArgs e)
        {
            btExcel.Image = global::Advocacia.Properties.Resources.Excel_32;
        }
    }
}
