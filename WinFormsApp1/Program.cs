using WinFormsApp1.Controladores;
using WinFormsApp1.Forms;
using WinFormsApp1.Forms.fClientes;
using WinFormsApp1.Forms.fReservas;
using WinFormsApp1.Persistencia;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Conexion.OpenConexion();

            Application.Run(new fLogin());
            Conexion.CloseConexion();
        }
    }
}