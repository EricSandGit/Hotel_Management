using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pHabitacion
    {
        public static List<Habitacion> getAll()
        {
            List<Habitacion> habitaciones = new List<Habitacion>();

            SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_habitacion, numero, camas_individuales, camas_matrimoniales, precio_por_noche FROM HABITACION");
            sqliteCommand.Connection = Conexion.MiConexion;

            SqliteDataReader dataReader = sqliteCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Habitacion habitacion = new Habitacion();
                habitacion.IdHabitacion = dataReader.GetInt32(0);
                habitacion.Numero = dataReader.GetInt32(1);
                habitacion.CamasIndividuales = dataReader.GetInt32(2);
                habitacion.CamasMatrimoniales = dataReader.GetInt32(3);
                habitacion.PrecioPorNoche = dataReader.GetDouble(4);
                habitaciones.Add(habitacion);
            }

            return habitaciones;
        }

        public static Habitacion GuardarHabitacion(Habitacion h)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO HABITACION (numero, camas_individuales, camas_matrimoniales, precio_por_noche) " +
                "VALUES (@Numero, @CamasIndividuales, @CamasMatrimoniales, @PrecioPorNoche); " +
                "SELECT last_insert_rowid();"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@Numero", h.Numero));
            sqliteCommand.Parameters.Add(new SqliteParameter("@CamasIndividuales", h.CamasIndividuales));
            sqliteCommand.Parameters.Add(new SqliteParameter("@CamasMatrimoniales", h.CamasMatrimoniales));
            sqliteCommand.Parameters.Add(new SqliteParameter("@PrecioPorNoche", h.PrecioPorNoche));
            sqliteCommand.Connection = Conexion.MiConexion;

            h.IdHabitacion = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            return h;
        }

        public static void ModificarHabitacion(Habitacion h)
        {
            SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE HABITACION SET numero = @Numero, camas_individuales = @CamasIndividuales, " +
                "camas_matrimoniales = @CamasMatrimoniales, precio_por_noche = @PrecioPorNoche WHERE id_habitacion = @Id"
            );
            sqliteCommand.Parameters.Add(new SqliteParameter("@Numero", h.Numero));
            sqliteCommand.Parameters.Add(new SqliteParameter("@CamasIndividuales", h.CamasIndividuales));
            sqliteCommand.Parameters.Add(new SqliteParameter("@CamasMatrimoniales", h.CamasMatrimoniales));
            sqliteCommand.Parameters.Add(new SqliteParameter("@PrecioPorNoche", h.PrecioPorNoche));
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", h.IdHabitacion));
            sqliteCommand.Connection = Conexion.MiConexion;
            sqliteCommand.ExecuteNonQuery();
        }

        public static void EliminarHabitacion(int id)
        {
            SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM HABITACION WHERE id_habitacion = @Id");
            sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
            sqliteCommand.Connection = Conexion.MiConexion;
            sqliteCommand.ExecuteNonQuery();
        }
    }
}
