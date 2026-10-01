using System;
using System.Windows.Forms;

namespace CadastroPetShop
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using FormLogin login = new FormLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new crudMENU(login.UsuarioAutenticado));
            }
        }
    }
}