using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Persistencia
{
    internal static class Conexion
    {
        private static readonly string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HotelDB.db");
        private static SqliteConnection miConexion = new SqliteConnection($"Data Source={dbPath}");

        public static void OpenConexion()
        {

            if (miConexion.State == System.Data.ConnectionState.Closed)
            {
                miConexion.Open();
            }
        }



        public static void CloseConexion()
        {
            miConexion.Close();
        }

        public static SqliteConnection MiConexion { get { return miConexion; } }
    }
}

