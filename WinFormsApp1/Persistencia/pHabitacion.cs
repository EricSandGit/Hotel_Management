using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Persistencia
{
    internal class pHabitacion : IRepositorio<Habitacion>
    {
        public List<Habitacion> ObtenerTodos()
        {
            List<Habitacion> habitaciones = new List<Habitacion>();

            using (SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_habitacion, numero, camas_individuales, camas_matrimoniales, precio_por_noche FROM HABITACION"))
            {
                sqliteCommand.Connection = Conexion.MiConexion;

                using (SqliteDataReader dataReader = sqliteCommand.ExecuteReader())
                {
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
                }
            }

            return habitaciones;
        }

        public Habitacion ObtenerPorId(int id)
        {
            Habitacion habitacion = null;
            using (SqliteCommand sqliteCommand = new SqliteCommand("SELECT id_habitacion, numero, camas_individuales, camas_matrimoniales, precio_por_noche FROM HABITACION WHERE id_habitacion = @id"))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@id", id));
                sqliteCommand.Connection = Conexion.MiConexion;
                using (SqliteDataReader dataReader = sqliteCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        habitacion = new Habitacion();
                        habitacion.IdHabitacion = dataReader.GetInt32(0);
                        habitacion.Numero = dataReader.GetInt32(1);
                        habitacion.CamasIndividuales = dataReader.GetInt32(2);
                        habitacion.CamasMatrimoniales = dataReader.GetInt32(3);
                        habitacion.PrecioPorNoche = dataReader.GetDouble(4);
                    }
                }
            }
            return habitacion;
        }

        public int Agregar(Habitacion entidad)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand(
                "INSERT INTO HABITACION (numero, camas_individuales, camas_matrimoniales, precio_por_noche) " +
                "VALUES (@Numero, @CamasIndividuales, @CamasMatrimoniales, @PrecioPorNoche); " +
                "SELECT last_insert_rowid();"
            ))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@Numero", entidad.Numero));
                sqliteCommand.Parameters.Add(new SqliteParameter("@CamasIndividuales", entidad.CamasIndividuales));
                sqliteCommand.Parameters.Add(new SqliteParameter("@CamasMatrimoniales", entidad.CamasMatrimoniales));
                sqliteCommand.Parameters.Add(new SqliteParameter("@PrecioPorNoche", entidad.PrecioPorNoche));
                sqliteCommand.Connection = Conexion.MiConexion;

                entidad.IdHabitacion = Convert.ToInt32(sqliteCommand.ExecuteScalar());
            }
            return entidad.IdHabitacion;
        }

        public bool Actualizar(Habitacion entidad)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand(
                "UPDATE HABITACION SET numero = @Numero, camas_individuales = @CamasIndividuales, " +
                "camas_matrimoniales = @CamasMatrimoniales, precio_por_noche = @PrecioPorNoche WHERE id_habitacion = @Id"
            ))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@Numero", entidad.Numero));
                sqliteCommand.Parameters.Add(new SqliteParameter("@CamasIndividuales", entidad.CamasIndividuales));
                sqliteCommand.Parameters.Add(new SqliteParameter("@CamasMatrimoniales", entidad.CamasMatrimoniales));
                sqliteCommand.Parameters.Add(new SqliteParameter("@PrecioPorNoche", entidad.PrecioPorNoche));
                sqliteCommand.Parameters.Add(new SqliteParameter("@Id", entidad.IdHabitacion));
                sqliteCommand.Connection = Conexion.MiConexion;
                int rowsAffected = sqliteCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool Eliminar(int id)
        {
            using (SqliteCommand sqliteCommand = new SqliteCommand("DELETE FROM HABITACION WHERE id_habitacion = @Id"))
            {
                sqliteCommand.Parameters.Add(new SqliteParameter("@Id", id));
                sqliteCommand.Connection = Conexion.MiConexion;
                int rowsAffected = sqliteCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
