using WinFormsApp1.Forms;
using WinFormsApp1.Persistencia;
using WinFormsApp1.Controladores;

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

            // Realiza la migración automática de contraseñas a BCrypt en caso de existir contraseñas en texto plano
            nUsuario.MigrarPasswordsAHash();

            Application.Run(new fLogin());
            Conexion.CloseConexion();
        }
    }
}