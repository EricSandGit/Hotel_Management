using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pGastoExtra
    {
        public static List<GastoExtra> getAll()
        {
            List<GastoExtra> gastos = new List<GastoExtra>();

            SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_gasto, id_estadia, concepto, monto, fecha FROM GASTO_EXTRA");
            sqliteCommand.Connection = Conexion.MiConexion;

            SqliteDataReader dataReader = sqliteCommand.ExecuteReader();

            while (dataReader.Read())
            {
                GastoExtra gasto = new GastoExtra();
                gasto.IdGasto = dataReader.GetInt32(0);
                gasto.IdEstadia = dataReader.GetInt32(1);
                gasto.Concepto = dataReader.GetString(2);
                gasto.Monto = dataReader.GetDouble(3);
                gasto.Fecha = Convert.ToDateTime(dataReader.GetValue(4));
                gastos.Add(gasto);
            }

            return gastos;
        }

        public static GastoExtra GuardarGastoExtra(GastoExtra g)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO GASTO_EXTRA (id_estadia, concepto, monto, fecha) " +
                "VALUES (@IdEstadia, @Concepto, @Monto, @Fecha); " +
                "SELECT last_insert_rowid();"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdEstadia", g.IdEstadia));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Concepto", g.Concepto));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Monto", g.Monto));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Fecha", g.Fecha.ToString("yyyy-MM-dd HH:mm:ss")));
            sqliteCommand.Connection = Conexion.MiConexion;

            g.IdGasto = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            return g;
        }

        public static void ModificarGastoExtra(GastoExtra g)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE GASTO_EXTRA SET id_estadia = @IdEstadia, concepto = @Concepto, " +
                "monto = @Monto, fecha = @Fecha WHERE id_gasto = @Id"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdEstadia", g.IdEstadia));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Concepto", g.Concepto));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Monto", g.Monto));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Fecha", g.Fecha.ToString("yyyy-MM-dd HH:mm:ss")));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", g.IdGasto));
            sqliteCommand.Connection = Conexion.MiConexion;
            sqliteCommand.ExecuteNonQuery();
        }

        public static void EliminarGastoExtra(int id)
        {
            SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM GASTO_EXTRA WHERE id_gasto = @Id");
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
            sqliteCommand.Connection = Conexion.MiConexion;
            sqliteCommand.ExecuteNonQuery();
        }
    }
}
