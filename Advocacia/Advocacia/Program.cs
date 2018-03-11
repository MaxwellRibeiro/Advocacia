using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advocacia.Login;

namespace Advocacia
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var frmLogin = new FormLogin();
            //frmLogin.ShowDialog();
            //var acessoLiberado = frmLogin.Logado;
            //frmLogin.Dispose();

            //if (acessoLiberado)
            //{
                Application.Run(new FormPrincipal());
            //}



        }
    }
}
