using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pEstadia
    {
        public static List<Estadia> getAll()
        {
            List<Estadia> estadias = new List<Estadia>();

            SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_estadia, id_reserva, id_usuario, fecha_checkin, fecha_checkout, estado FROM ESTADIA");
            sqliteCommand.Connection = Conexion.MiConexion;

            SqliteDataReader dataReader = sqliteCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Estadia estadia = new Estadia();
                estadia.IdEstadia = dataReader.GetInt32(0);
                estadia.IdReserva = dataReader.GetInt32(1);
                estadia.IdUsuario = dataReader.GetInt32(2);
                estadia.FechaCheckin = Convert.ToDateTime(dataReader.GetValue(3));
                estadia.FechaCheckout = dataReader.IsDBNull(4) ? (DateTime?)null : Convert.ToDateTime(dataReader.GetValue(4));
                estadia.Estado = dataReader.GetString(5);
                estadias.Add(estadia);
            }

            return estadias;
        }

        public static Estadia GuardarEstadia(Estadia e)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO ESTADIA (id_reserva, id_usuario, fecha_checkin, fecha_checkout, estado) " +
                "VALUES (@IdReserva, @IdUsuario, @FechaCheckin, @FechaCheckout, @Estado); " +
                "SELECT last_insert_rowid();"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdReserva", e.IdReserva));
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdUsuario", e.IdUsuario));
            sqliteCommand.Parameters.Add(new SqliteParameter("@FechaCheckin", e.FechaCheckin.ToString("yyyy-MM-dd")));
            sqliteCommand.Parameters.Add(new SqliteParameter("@FechaCheckout", e.FechaCheckout.HasValue ? e.FechaCheckout.Value.ToString("yyyy-MM-dd") : (object)DBNull.Value));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Estado", e.Estado));
            sqliteCommand.Connection = Conexion.MiConexion;

            e.IdEstadia = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            return e;
        }

        public static void ModificarEstadia(Estadia e)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE ESTADIA SET id_reserva = @IdReserva, id_usuario = @IdUsuario, " +
                "fecha_checkin = @FechaCheckin, fecha_checkout = @FechaCheckout, estado = @Estado WHERE id_estadia = @Id"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdReserva", e.IdReserva));
            sqliteCommand.Parameters.Add(new SqliteParameter("@IdUsuario", e.IdUsuario));
            sqliteCommand.Parameters.Add(new SqliteParameter("@FechaCheckin", e.FechaCheckin.ToString("yyyy-MM-dd")));
            sqliteCommand.Parameters.Add(new SqliteParameter("@FechaCheckout", e.FechaCheckout.HasValue ? e.FechaCheckout.Value.ToString("yyyy-MM-dd") : (object)DBNull.Value));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Estado", e.Estado));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", e.IdEstadia));
            sqliteCommand.Connection = Conexion.MiConexion;
            sqliteCommand.ExecuteNonQuery();
        }

        public static void EliminarEstadia(int id)
        {
            SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM ESTADIA WHERE id_estadia = @Id");
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
            sqliteCommand.Connection = Conexion.MiConexion;
            sqliteCommand.ExecuteNonQuery();
        }
    }
}
