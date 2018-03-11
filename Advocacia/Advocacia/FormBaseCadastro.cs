using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Advocacia
{
    public partial class FormBaseCadastro : MetroForm
    {
        //private bool controleThead;
        //private Thread Thread_Spinner;

        public FormBaseCadastro()
        {
            InitializeComponent();
        }

        private void FormBaseCadastro_Load(object sender, EventArgs e)
        {
            //Thread_Spinner = new Thread(Spinner_Executando);
        }

        //public void Progress_Spinner(bool permitir)
        //{
        //    //this.Invoke((MethodInvoker) delegate
        //    //{
        //        if (permitir)
        //        {
        //            //controleThead = true;
        //            ProgressSpinner.Enabled = permitir;
        //            ProgressSpinner.Visible = permitir;

        //            //Thread_Spinner.Start();
        //        }
        //        else
        //        {
        //            //controleThead = false;
        //            ProgressSpinner.Enabled = permitir;
        //            ProgressSpinner.Visible = permitir;
        //        }
        //    //}
        //    //);
        //}

        //private void Spinner_Executando()
        //{
        //    Random rondom = new Random();
        //    int numero;
        //    while (controleThead)
        //    {
        //        numero = rondom.Next(9);
        //        ProgressSpinner.Value += numero;
        //        if (ProgressSpinner.Value > 100) ProgressSpinner.Value = 5;
        //    }
        //}

        public void OriginalObjeto(object Objeto, object ObjetoDestino)
        {
            Funcao_Copia_Objeto(Objeto,ref ObjetoDestino);
        }

        public void CopiaObjeto(object Objeto, ref object ObjetoDestino)
        {
            Funcao_Copia_Objeto(Objeto,ref ObjetoDestino);
        }

        private void Funcao_Copia_Objeto(object Objeto, ref object Destino)
        {
            if (Objeto != null)
            {
                Type TypeObjeto = Objeto.GetType();
                if (Destino == null)
                {
                    Destino = Activator.CreateInstance(TypeObjeto);
                }
                PropertyInfo[] Properties = TypeObjeto.GetProperties();

                foreach (PropertyInfo property in Properties)
                {
                    object PropValue = property.GetValue(Objeto, null);
                    var PropertyInfo = Destino.GetType().GetProperty(property.Name);
                    PropertyInfo.SetValue(Destino, PropValue, null);
                }
            }
        }
    }
}
